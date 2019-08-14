using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace MusicHub.Data.Dtos
{
    [XmlType("Song")]
    public class ImportSongsDto
    {
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        public string Duration { get; set; }

        [Required]
        public string CreatedOn { get; set; }

        [Required]
        public string Genre { get; set; }

        public int? AlbumId { get; set; }

        [Required]
        public int WriterId { get; set; }

        [Required]
        [Range(typeof(decimal), "0.00", "79228162514264337593543950335")]
        public decimal Price { get; set; }

    }
}
