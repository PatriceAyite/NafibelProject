using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Nafibel.Data.Model
{
    public class HairStyle : TrackedModel
    {
        [Key]
        public Ulid Id { get; set; }

        [Required]
        [Unicode(true)]
        [MaxLength(255)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Unicode(true)]
        [MaxLength(4000)]
        public string Description { get; set; } = string.Empty;

        public List<HairTypeEnum> HairType { get; set; } =
            new List<HairTypeEnum>();

        public LengthEnum Length { get; set; }

        public SexEnum Sex { get; set; }

        public int? AverageTime { get; set; }

        public MaintenanceLevelEnum MaintenanceLevel { get; set; }

        public ICollection<HairStylePrice> HairStylePrices { get; set; } = new List<HairStylePrice>();

        public ICollection<HairStyleImage> Images { get; set; } = new List<HairStyleImage>();


        public ICollection<HairStyleNameLocale> Locales { get; set; } = new List<HairStyleNameLocale>();

        public List<HairdresserHairStyle> Hairdressers { get; set; } = new List<HairdresserHairStyle>();

    }
}

