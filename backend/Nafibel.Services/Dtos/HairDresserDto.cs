using Azure.Core;
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
        public Ulid id { get; set; }
        public string Email { get; set; } = string.Empty;

       
        public string FirstName { get; set; } = string.Empty;

        
        public string LastName { get; set; }
        = string.Empty;

        public string MiddleName { get; set; } = string.Empty;


        
        public string PhoneNumber { get; set; } = string.Empty;

        public HaireDresserTypeEnum type { get; set; }

        
        public string CountryCode { get; set; } = "CA";
        public string? State { get; set; }
        public string Region { get; set; } = null;

        public Point? Location { get; set; }

        public DateTime? Dob { get; set; }

      
        public string? ProfileImage { get; set; }

       
        public string? ProfileText { get; set; }

        public HairDresserDto(Hairdresser hairdresser) 
        {
            id = hairdresser.Id;
            FirstName = hairdresser.FirstName;
            LastName = hairdresser.LastName;
            MiddleName = hairdresser.MiddleName;
            Email = hairdresser.Email;
            Location = hairdresser.Location;
            ProfileImage = hairdresser.ProfileImage;
            ProfileText = hairdresser.ProfileText;
            PhoneNumber = hairdresser.PhoneNumber;
            Region = hairdresser.Region;
            State = hairdresser.State;
            CountryCode = hairdresser.CountryCode;
            Dob = hairdresser.Dob;
            type = hairdresser.type;
            Location = hairdresser.Location;
        }

        public HairDresserDto()
        {

        }

    }
}
