﻿using Azure.Core;
using Microsoft.EntityFrameworkCore;
using Nafibel.Data.Model;
using NetTopologySuite.Geometries;
using StringTokenFormatter;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafibel.Services.Dtos
{
    public class HairDresserDto 
    {
        public Ulid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }
        public string CountryCode { get; set; } = "CA";
        public string? State { get; set; }
        public string? Region { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string? ProfileImage { get; set; }
        public string? ProfileText { get; set; }
        public HaireDresserTypeEnum type { get; set; }

        public HairDresserDto(Hairdresser hairdresser)
        {
            Id = hairdresser.Id;
            FirstName = hairdresser.FirstName;
            LastName = hairdresser.LastName;
            MiddleName = hairdresser.MiddleName;
            Email = hairdresser.Email;
            PhoneNumber = hairdresser.PhoneNumber;
            Region = hairdresser.Region;
            State = hairdresser.State;
            CountryCode = hairdresser.CountryCode;
            ProfileImage = hairdresser.ProfileImage;
            ProfileText = hairdresser.ProfileText;
            type = hairdresser.type;

            if (hairdresser.Location != null)
            {
                Latitude = hairdresser.Location.Y;
                Longitude = hairdresser.Location.X;
            }
        }
        public HairDresserDto()
        {

        }

    }
}
