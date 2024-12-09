using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;

namespace Nafibel.Data.Model
{

    public class Appointment : TrackedModel
    {
        [Key]
        public Ulid Id { get; set; }

        [Required]
        public DateOnly AppointmentDate { get; set; }

        [Required]
        public TimeOnly From { get; set; }  

        [Required]
        public TimeOnly To { get; set; }

        [Required]
        public Ulid HairdresserId { get; set; }

        public Hairdresser? Hairdresser { get; set; }

        [Required]
        public Ulid HairStyleId { get; set; }

        public HairStyle? HairStyle { get; set; }

        public Ulid? ClientId { get; set; }

        public Client? Client { get; set; }

        [Required]
        [Unicode(true)]
        [MaxLength(500)]
        public string ClientName { get; set; } = string.Empty;

        public List<Payment> Payments { get; set; } = new List<Payment>();


        [Required]
        [MaxLength(10)]
        public string CountryCode { get; set; } = "CA";
        public string? State { get; set; }
        public string? Region { get; set; } = null;

        [Required]
        public LocationTypeEnum LocationType { get; set; }

        public Point? Location { get; set; }

    }

    public enum LocationTypeEnum
    {
        Shop,
        ClientHome,
        HairdresserHome
    }
}
