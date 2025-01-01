using Microsoft.EntityFrameworkCore;
using Nafibel.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafibel.Services.Dtos
{
    public class ClientDto
    {
        public Ulid id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string CountryCode { get; set; } = "CA";
        public string? State { get; set; }
        public string Region { get; set; } = string.Empty;
        public Point Location { get; set; } = default!;
        public AgeRangeNum AgeRange { get; set; }


        public ClientDto(Client client) 
        {
            id = client.Id;
            AgeRange = client.AgeRange;
            CountryCode = client.CountryCode;
            FirstName = client.FirstName;
            LastName = client.LastName;
            MiddleName = client.MiddleName;
            PhoneNumber = client.PhoneNumber;
            State = client.State;
            Region = client.Region;
            Email = client.Email;
            Location = new System.Drawing.Point((int)client.Location.X, (int)client.Location.Y);
        }  

        public  ClientDto() 
        { 

        }
    }
}
