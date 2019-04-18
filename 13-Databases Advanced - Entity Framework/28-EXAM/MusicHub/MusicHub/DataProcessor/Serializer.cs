namespace MusicHub.DataProcessor
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;
    using Data;
    using MusicHub.Data.Dtos;
    using Newtonsoft.Json;
    using Formatting = Newtonsoft.Json.Formatting;

    public class Serializer
    {
        public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
        {
            var data = context
                .Producers
                .Find(producerId)
                .Albums
                .Select(a => new
                {
                    AlbumName = a.Name,
                    ReleaseDate = a.ReleaseDate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture),
                    ProducerName = a.Producer.Name,

                    Songs = a.Songs.Select(s => new
                    {
                        SongName = s.Name,
                        Price = $"{Math.Round(s.Price, 2):f2}",
                        Writer = s.Writer.Name
                    })
                    .OrderByDescending(x => x.SongName)
                    .ThenBy(x => x.Writer)
                    .ToArray(),

                    AlbumPrice = $"{Math.Round(a.Price, 2):f2}"
                })
                .OrderByDescending(x => decimal.Parse(x.AlbumPrice))
                .ToArray();

            var jsonResult = JsonConvert.SerializeObject(data, Formatting.Indented);

            return jsonResult;
        }

        public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
        {
            var data = context
                .Songs
                .Where(s => s.Duration.TotalSeconds > duration)
                .Select(s => new ExportSongsDto
                {
                    SongName = s.Name,
                    Writer = s.Writer.Name,
                    Performer = context.SongsPerformers.Where(sp => sp.SongId == s.Id)
                                                        .Select(x => $"{x.Performer.FirstName} {x.Performer.LastName}").FirstOrDefault(),

                    AlbumProducer = context.Albums.Where(a => a.Id == s.AlbumId)
                                                    .Select(x => x.Producer.Name).FirstOrDefault(),

                    Duration = s.Duration.ToString("c")
                })
                .OrderBy(x => x.SongName)
                .ThenBy(x => x.Writer)
                .ThenBy(x => x.Performer)
                .ToArray();


            var xmlSerializer = new XmlSerializer(typeof(ExportSongsDto[]), new XmlRootAttribute("Songs"));
            var namespaces = new XmlSerializerNamespaces(new[]
            {
                XmlQualifiedName.Empty,
            });

            var sb = new StringBuilder();
            xmlSerializer.Serialize(new StringWriter(sb), data, namespaces);

            var result = sb.ToString().TrimEnd();

            return result;
        }
    }
}