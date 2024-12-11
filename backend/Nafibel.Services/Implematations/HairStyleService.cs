using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Nafibel.Data.Model;
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
    public class HairStyleService : IHairStyleService
    {
        private readonly NafibelDbContext _DbContext;

        private readonly ILogger<HairStyleService> _logger;

        public HairStyleService(NafibelDbContext dbContext , ILogger<HairStyleService> logger)
        {
            this._DbContext = dbContext;
            this._logger = logger;
        }

        

        public async Task<Result<HairStyleDto>?> CreateHairStyle (CreateHairStyleRequestDto request)
        {
            try
            {
                _logger.LogInformation("Creating HairStyle to Database");
                var harStyle = new HairStyle()
                {
                    Id = Ulid.NewUlid(),
                    Name = request.Name,
                    Sex = request.Sex,  
                    AverageTime = request.AverageTime,  
                    CreatedBy = request.CreatedBy,
                    CreatedOn = request.CreatedOn,
                    Description = request.Description,
                    IsActive = true,
                    Length = request.Length,
                    HairType = request.HairType,
                    MaintenanceLevel = request.MaintenanceLevel,
                    ModifiedOn = request.CreatedOn,
                    ModifiedBy = request.CreatedBy,

                };

                _DbContext.HairStyles.Add(harStyle);
                await  _DbContext.SaveChangesAsync();
                

                var response = new HairStyleDto()
                {
                    id = harStyle.Id.ToString(),
                    Name = harStyle.Name,
                    Sex = harStyle.Sex,
                    AverageTime = harStyle.AverageTime,
                    Description = harStyle.Description,
                };



                return new Result<HairStyleDto>(true) { Model = response};

            }catch (Exception ex)
            {
                _logger.LogError(ex, "CreateHiarStyle");
                return new Result<HairStyleDto>(false, "Saving Error");
            }
        }

        public Task<List<HairStyleDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<HairStyleDto> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
