﻿using System.ComponentModel.DataAnnotations;

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

        public HairStyle? HairStyle { get; set; }

        [Required]
        public string CreatedBy { get; set; } = string.Empty;
        [Required]
        public DateTime CreatedOn { get; set; }


    }
}

