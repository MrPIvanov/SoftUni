using System.ComponentModel.DataAnnotations;

namespace MusicHub.Data.Dtos
{
    public class ImportProducersAlbumsDto
    {
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }

        [RegularExpression(@"^[A-Z][a-z]+ [A-Z][a-z]+$")]
        public string Pseudonym { get; set; }

        [RegularExpression(@"^\+359 [0-9]{3} [0-9]{3} [0-9]{3}$")]
        public string PhoneNumber { get; set; }

        public ImportAlbumsDto[] Albums { get; set; }
    }

    public class ImportAlbumsDto
    {
        [Required]
        [StringLength(40, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        public string ReleaseDate { get; set; }
    }
}
