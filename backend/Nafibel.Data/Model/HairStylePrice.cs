using System.ComponentModel.DataAnnotations;

namespace Nafibel.Data.Model
{
    public class HairStylePrice
    {
        [Key]
        public Ulid Id { get; set; }

        [Required]
        public Ulid HairStyleId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public double Price { get; set; }


        public HairStyle HairStyle { get; set; }

    }
}

