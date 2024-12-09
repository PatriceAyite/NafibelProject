using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Nafibel.Data.Model
{
    [PrimaryKey(nameof(HairdresserId), nameof(HairStyleId))]

    public class HairdresserHairStyle 
    {
        [Required]
        public Ulid HairdresserId { get; set; }

        public Hairdresser Hairdresser { get; set; }

        [Required]
        public Ulid HairStyleId { get; set; }

        public HairStyle HairStyle { get; set; }


        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; }



    }


}
