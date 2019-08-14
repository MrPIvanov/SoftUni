using System.ComponentModel.DataAnnotations;

namespace MusicHub.Data.Dtos
{
    public class ImportWritersDto
    {

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }

        [RegularExpression(@"^[A-Z][a-z]+ [A-Z][a-z]+$")]
        public string Pseudonym { get; set; }
    }
}
