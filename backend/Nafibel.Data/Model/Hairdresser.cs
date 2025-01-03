﻿using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;

namespace Nafibel.Data.Model
{
    [Index(nameof(Email), IsUnique = true)]
    public class Hairdresser : Person
    {
        public DateTime? Dob { get; set; }

        [Unicode(false)]
        public string? ProfileImage { get; set; }

        [Unicode(true)]
        [MaxLength(4000)]
        public string? ProfileText { get; set;}

        public HaireDresserTypeEnum type { get; set; }


        public List<HairdresserHairStyle> HairStyles { get; set; } = new List<HairdresserHairStyle>();

    }


}
