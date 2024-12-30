using Microsoft.EntityFrameworkCore;
using Nafibel.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafibel.Services.Dtos
{
    public class HairStyleNameLocaleDto
    {
        public string? Id { get; set; }

        public Ulid HairstyleId { get; set; }

        public HairStyle? HairStyle { get; set; }

        public string Locale { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
    }
}
