using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Nafibel.Data.Model
{
    public class HairStyleNameLocale
    {
        [Key]
        public Ulid Id { get; set; }

        [Required] 
        public Ulid HairstyleId { get; set; }

        public HairStyle? HairStyle { get; set; }

        [Required]
        public string Locale { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        public string Name { get; set; } = string.Empty;

        [Unicode(true)]
        [MaxLength(4000)]
        public string Description { get; set; } = string.Empty;

    }
}

