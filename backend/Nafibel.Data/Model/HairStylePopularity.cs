using System.ComponentModel.DataAnnotations;

namespace Nafibel.Data.Model
{
    public class HairStylePopularity
    {
        [Key]
        public Ulid HairStyleId { get; set; }

        [Required]
        [Range(0D,20)]
        public short Popularity { get; set; }

    }

}
