using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment5.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Stream { get; set; }
        [StringLength(20, MinimumLength = 3)]
        [Required]
        public string MusicOn { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Performer { get; set;}
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Musicians { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Groups { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public int Year { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
