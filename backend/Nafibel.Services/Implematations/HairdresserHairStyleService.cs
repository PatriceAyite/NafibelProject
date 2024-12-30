using Microsoft.Extensions.Logging;
using Nafibel.Data.Repositories;
using Nafibel.Services.Dtos;
using Nafibel.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafibel.Services.Implematations
{
    public class HairdresserHairStyleService : IHairdresserHairStyleService
    {

        private readonly NafibelDbContext _DbContext;

        private readonly ILogger<HairdresserHairStyleService> _logger;

        public Task<Result<HairDresserHairStyleDto>?> CreateHairStyle(CreateHairdresserHairStyleRequestDto request)
        {
            throw new NotImplementedException();
        }
    }
}
