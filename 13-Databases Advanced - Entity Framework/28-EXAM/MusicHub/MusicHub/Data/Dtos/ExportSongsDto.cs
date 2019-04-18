using System.Xml.Serialization;

namespace MusicHub.Data.Dtos
{
    [XmlType("Song")]
    public class ExportSongsDto
    {

        public string SongName { get; set; }

        public string Writer { get; set; }

        public string Performer { get; set; }

        public string AlbumProducer { get; set; }

        public string Duration { get; set; }
    }
}
