namespace MusicHub.DataProcessor
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
    using MusicHub.Data.Dtos;
    using MusicHub.Data.Models;
    using MusicHub.Data.Models.Enums;
    using Newtonsoft.Json;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data";

        public static string ImportWriters(MusicHubDbContext context, string jsonString)
        {
           var allData = JsonConvert.DeserializeObject<ImportWritersDto[]>(jsonString);

            var sb = new StringBuilder();
            var validData = new List<Writer>();

            foreach (var writer in allData)
            {
                if (!IsValid(writer))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var temp = new Writer
                {
                    Name = writer.Name,
                    Pseudonym = writer.Pseudonym
                };

                validData.Add(temp);
                sb.AppendLine($"Imported {temp.Name}");
            }

            context.Writers.AddRange(validData);
            context.SaveChanges();


            return sb.ToString().TrimEnd();
        }

        public static string ImportProducersAlbums(MusicHubDbContext context, string jsonString)
        {
            var allData = JsonConvert.DeserializeObject<ImportProducersAlbumsDto[]>(jsonString);

            var sb = new StringBuilder();
            var validData = new List<Producer>();

            foreach (var dto in allData)
            {
                if (!IsValid(dto) || !dto.Albums.All(IsValid))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var temp = new Producer
                {
                    Name = dto.Name,
                    PhoneNumber = dto.PhoneNumber,
                    Pseudonym = dto.Pseudonym,
                    Albums = dto.Albums.Select(a => new Album
                    {
                        Name = a.Name,
                        ReleaseDate = DateTime.ParseExact(a.ReleaseDate, "dd/M/yyyy", CultureInfo.InvariantCulture)
                   })
                   .ToArray()
                };

                validData.Add(temp);

                if (temp.PhoneNumber == null)
                {
                    sb.AppendLine($"Imported {temp.Name} with no phone number produces {temp.Albums.Count} albums");
                }
                else
                {
                    sb.AppendLine($"Imported {temp.Name} with phone: {temp.PhoneNumber} produces {temp.Albums.Count} albums");
                }
               
            }

            context.Producers.AddRange(validData);
            context.SaveChanges();


            return sb.ToString().TrimEnd();
        }

        public static string ImportSongs(MusicHubDbContext context, string xmlString)
        {
            var xmlSerializer = new XmlSerializer(typeof(ImportSongsDto[]), new XmlRootAttribute("Songs"));
            var allData = (ImportSongsDto[])xmlSerializer.Deserialize(new StringReader(xmlString));

            var sb = new StringBuilder();
            var validData = new List<Song>();

            foreach (var dto in allData)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

               var isValidEnum = Enum.TryParse<Genre>(dto.Genre, out Genre GenreEnum);

                if (!isValidEnum)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var validAlbumsId = context.Albums.Select(a => a.Id).ToArray();
                var validWriterId = context.Writers.Select(w => w.Id).ToArray();

                if (dto.AlbumId != null)
                {
                    int temp = (int)dto.AlbumId;
                    if (!validAlbumsId.Contains(temp))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                   
                }

                if (!validWriterId.Contains(dto.WriterId))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var durationTimeSpan = TimeSpan.ParseExact(dto.Duration, "c", CultureInfo.InvariantCulture);

                var createdOnDateTime = DateTime.ParseExact(dto.CreatedOn, "dd/M/yyyy", CultureInfo.InvariantCulture);


                var tempValid = new Song
                {
                    Name = dto.Name,
                    Duration = durationTimeSpan,
                    CreatedOn = createdOnDateTime,
                    Genre = GenreEnum,
                    AlbumId = dto.AlbumId,
                    WriterId = dto.WriterId,
                    Price = dto.Price                    
                };

                validData.Add(tempValid);
                sb.AppendLine($"Imported {tempValid.Name} ({tempValid.Genre.ToString()} genre) with duration {tempValid.Duration.ToString("c")}");
            }

            context.Songs.AddRange(validData);
            context.SaveChanges();

            string result = sb.ToString().TrimEnd();

            return result;
        }

        public static string ImportSongPerformers(MusicHubDbContext context, string xmlString)
        {
            var xmlSerializer = new XmlSerializer(typeof(ImportSongPerformersDto[]), new XmlRootAttribute("Performers"));
            var allData = (ImportSongPerformersDto[])xmlSerializer.Deserialize(new StringReader(xmlString));

            var sb = new StringBuilder();
            var validData = new List<Performer>();

            foreach (var dto in allData)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var validSongId = context.Songs.Select(s => s.Id).ToArray();
                var allSongsValid = true;

                foreach (var song in dto.PerformersSongs)
                {
                    if (validSongId.Contains(song.Id))
                    {
                        continue;
                    }

                    allSongsValid = false;
                }

                if (!allSongsValid)
                {

                    sb.AppendLine(ErrorMessage);
                    continue;
                }

               
                var tempValid = new Performer
                {
                   FirstName = dto.FirstName,
                   LastName = dto.LastName,
                   Age = dto.Age,
                   NetWorth = dto.NetWorth,
                   PerformerSongs = dto.PerformersSongs.Select(s => new SongPerformer
                   {
                       SongId = s.Id
                   })
                   .ToArray()
                };

                validData.Add(tempValid);
                sb.AppendLine($"Imported {tempValid.FirstName} ({tempValid.PerformerSongs.Count} songs)");
            }

            context.Performers.AddRange(validData);
            context.SaveChanges();

            string result = sb.ToString().TrimEnd();

            return result;
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