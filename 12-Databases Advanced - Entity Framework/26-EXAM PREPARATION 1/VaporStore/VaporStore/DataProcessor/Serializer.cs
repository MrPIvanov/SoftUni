namespace VaporStore.DataProcessor
{
	using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;
    using Data;
    using Newtonsoft.Json;
    using VaporStore.Data.Models;
    using VaporStore.Dtos.Export;

    public static class Serializer
	{
		public static string ExportGamesByGenres(VaporStoreDbContext context, string[] genreNames)
		{
            var usersToExport = context
                .Genres
                .Where(x => genreNames.Contains(x.Name))
                .Select(g => new
                {
                    Id = g.Id,
                    Genre = g.Name,
                    Games = g.Games.Where(y => y.Purchases.Any()).Select(z => new
                    {
                        Id = z.Id,
                        Title = z.Name,
                        Developer = z.Developer.Name,
                        Tags = string.Join(", ", z.GameTags.Select(t => t.Tag.Name).ToArray()),
                        Players = z.Purchases.Count
                    })
                    .OrderByDescending(x => x.Players)
                    .ThenBy(x => x.Id)
                    .ToArray(),
                    TotalPlayers = g.Games.Select(x => x.Purchases.Count).Sum()
                })
                .ToArray();

            

            var jsonToExport = JsonConvert.SerializeObject(usersToExport, Newtonsoft.Json.Formatting.Indented);

            return jsonToExport;
        }

		public static string ExportUserPurchasesByType(VaporStoreDbContext context, string storeType)
		{
            var validData = context
                .Users
                .Select(x => new ExportUsersDto
                {
                    Username = x.Username,
                    Purchases = x.Cards
                        .SelectMany(p => p.Purchases)
                        .Where(t => t.Type.ToString() == storeType)
                        .Select(p => new PurchaseDto
                        {
                            Card = p.Card.Number,
                            Cvc = p.Card.Cvc,
                            Date = p.Date.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture),
                            Game = new GameDto
                            {
                                Genre = p.Game.Genre.Name,
                                Title = p.Game.Name,
                                Price = p.Game.Price
                            }
                        })
                        .OrderBy(d => d.Date)
                        .ToArray(),
                    TotalSpent = x.Cards.SelectMany(p => p.Purchases)
                        .Where(t => t.Type.ToString() == storeType)
                        .Sum(p => p.Game.Price)
                })
                .Where(p => p.Purchases.Any())
                .OrderByDescending(t => t.TotalSpent)
                .ThenBy(u => u.Username)
                .ToArray();

            var serializer = new XmlSerializer(typeof(ExportUsersDto[]), new XmlRootAttribute("Users"));

            var sb = new StringBuilder();

            var namespaces = new XmlSerializerNamespaces(new[]
            {
                new XmlQualifiedName("","")
            });

            serializer.Serialize(new StringWriter(sb), validData, namespaces);

            return sb.ToString().TrimEnd();
        }
	}
}