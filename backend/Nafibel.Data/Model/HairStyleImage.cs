﻿using System.ComponentModel.DataAnnotations;

namespace Nafibel.Data.Model
{
    public class HairStyleImage
    {
        [Required]
        public Ulid Id { get; set; }

        [Required]
        public string AltText { get; set; } = string.Empty;

        [Required]
        public Ulid HairStyleId { get; set; }
        public HairStyle HairStyle { get; set; }

        [Required]
        public byte Order { get; set; }

        [Required]
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; }
    }
}
