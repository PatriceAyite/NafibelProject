using Nafibel.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafibel.Services.Dtos
{

    public class HairStyleDto
    {
        public string? id { get; set; }


        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string? HairType { get; set; }


        public LengthEnum Length { get; set; }

        public SexEnum Sex { get; set; }

        public int? AverageTime { get; set; }

        public MaintenanceLevelEnum MaintenanceLevel { get; set; }
    }
}
