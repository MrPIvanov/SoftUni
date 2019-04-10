namespace VaporStore.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Data;
    using Newtonsoft.Json;
    using VaporStore.Data.Models;
    using VaporStore.Dtos.Import;

    public static class Deserializer
    {
        public static string ImportGames(VaporStoreDbContext context, string jsonString)
        {
            var allData = JsonConvert.DeserializeObject<ImportGamesDto[]>(jsonString);

            var sb = new StringBuilder();
            var validData = new List<Game>();

            foreach (var entity in allData)
            {
                if (!IsValid(entity) || entity.Tags.Length == 0)
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                var developer = context.Developers.FirstOrDefault(d => d.Name == entity.Developer);
                var genre = context.Genres.FirstOrDefault(g => g.Name == entity.Genre);

                if (developer == null)
                {
                    developer = new Developer
                    {
                        Name = entity.Developer,
                    };

                    context.Developers.Add(developer);
                    context.SaveChanges();
                }

                if (genre == null)
                {
                    genre = new Genre
                    {
                        Name = entity.Genre
                    };

                    context.Genres.Add(genre);
                    context.SaveChanges();
                }

                var currentEntity = new Game
                {
                    Developer = developer,
                    Name = entity.Name,
                    Genre = genre,
                    Price = entity.Price,
                    ReleaseDate = DateTime.ParseExact(entity.ReleaseDate, "yyyy-MM-dd", CultureInfo.InvariantCulture)
                };

                foreach (var tag in entity.Tags)
                {
                    var current = context.Tags.FirstOrDefault(t => t.Name == tag);

                    if (current == null)
                    {
                        current = new Tag
                        {
                            Name = tag
                        };

                        context.Tags.Add(current);
                        context.SaveChanges();
                    }

                    currentEntity.GameTags.Add(new GameTag
                    {
                        Game = currentEntity,
                        Tag = current
                    });

                }


                validData.Add(currentEntity);
                sb.AppendLine($"Added {currentEntity.Name} ({currentEntity.Genre.Name}) with {currentEntity.GameTags.Count} tags");
            }

            context.Games.AddRange(validData);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportUsers(VaporStoreDbContext context, string jsonString)
        {
            var allUsers = JsonConvert.DeserializeObject<ImportUsersDto[]>(jsonString);

            var sb = new StringBuilder();

            var validUsers = new List<User>();

            foreach (var user in allUsers)
            {
                if (!IsValid(user) || user.Cards.Length == 0)
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                var invalidCard = false;

                foreach (var card in user.Cards)
                {
                    if (!IsValid(card))
                    {
                        invalidCard = true;
                        break;
                    }
                }

                if (invalidCard)
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                var validUser = new User
                {
                    Age = user.Age,
                    Email = user.Email,
                    FullName = user.FullName,
                    Username = user.Username,
                    Cards = user.Cards.Select(c => new Card
                    {
                        Cvc = c.CVC,
                        Number = c.Number,
                        Type = Enum.Parse<CardType>(c.Type)
                    })
                    .ToArray()
                };

                validUsers.Add(validUser);
                sb.AppendLine($"Imported {validUser.Username} with {validUser.Cards.Count} cards");

            }

            context.Users.AddRange(validUsers);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportPurchases(VaporStoreDbContext context, string xmlString)
        {
            var serializer = new XmlSerializer(typeof(ImportPurchaseDto[]), new XmlRootAttribute("Purchases"));

            var allData = (ImportPurchaseDto[])serializer.Deserialize(new StringReader(xmlString));

            var validData = new List<Purchase>();

            var sb = new StringBuilder();

            foreach (var entity in allData)
            {
                if (!IsValid(entity))
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                var validEtity = new Purchase
                {
                    Card = context.Cards.FirstOrDefault(c => c.Number == entity.Card),
                    Game = context.Games.FirstOrDefault(g => g.Name == entity.Title),
                    ProductKey = entity.Key,
                    Type = Enum.Parse<PurchaseType>(entity.Type),
                    Date = DateTime.ParseExact(entity.Date, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture)
                };

                validData.Add(validEtity);
                sb.AppendLine($"Imported {validEtity.Game.Name} for {validEtity.Card.User.Username}");
            }

            context.Purchases.AddRange(validData);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        private static bool IsValid(object entity)
        {
            var validationContext = new ValidationContext(entity);
            var validationResult = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(entity, validationContext, validationResult, true);

            return isValid;
        }
    }
}