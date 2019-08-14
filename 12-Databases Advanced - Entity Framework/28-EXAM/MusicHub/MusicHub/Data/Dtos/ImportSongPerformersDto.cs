using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace MusicHub.Data.Dtos
{
    [XmlType("Performer")]
    public class ImportSongPerformersDto
    {
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string FirstName { get; set; }


        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string LastName { get; set; }

        [Required]
        [Range(18, 70)]
        public int Age { get; set; }

        [Required]
        [Range(typeof(decimal), "0.00", "79228162514264337593543950335")]
        public decimal NetWorth { get; set; }

        [XmlArray("PerformersSongs")]
        public SongDto[] PerformersSongs { get; set; }

    }

    [XmlType("Song")]
    public class SongDto
    {
        [XmlAttribute("id")]
        public int Id { get; set; }
    }
}
