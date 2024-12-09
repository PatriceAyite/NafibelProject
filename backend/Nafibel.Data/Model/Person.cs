using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using StringTokenFormatter;
using NetTopologySuite.Geometries;


namespace Nafibel.Data.Model
{
    public class Person : TrackedModel
    {

        [Key]
        public Ulid Id { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Unicode(true)]
        [MaxLength(255)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [Unicode(true)]
        [MaxLength(255)]
        public string LastName { get; set; }
        = string.Empty;

        [Unicode(true)]
        [MaxLength(255)]
        public string MiddleName { get; set; } = string.Empty;


        [MaxLength(30)] 
        public string PhoneNumber { get; set; } = string.Empty;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="fullNameFormat">ex. {FirstName} {LastName}</param>
        /// <returns></returns>
        public string GetFullName(string fullNameFormat)
        {
            return fullNameFormat.FormatFromObject(this);
        }


        [MaxLength(10)]
        public string CountryCode { get; set; } = "CA";
        public string? State { get; set; }
        public string Region { get; set; } = null;

        public Point? Location { get; set; }
    }
}
