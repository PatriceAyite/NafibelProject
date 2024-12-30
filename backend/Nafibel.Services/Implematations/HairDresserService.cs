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
    public class HairDresserService : IHairDresserService
    {
        private readonly NafibelDbContext _DbContext;
        private readonly ILogger<HairDresserService> _logger;

        public HairDresserService(NafibelDbContext dbContext, ILogger<HairDresserService> logger)
        {
            this._DbContext = dbContext;
            this._logger = logger;
        }
         public async Task<Result<HairDresserDto>?> CreateHairDresser(CreateHairDresserRequestDto request)
        {

            try
            {

                _logger.LogInformation("Creating HairDresser to Database");


                var hairdresser = new Hairdresser()
                {
                    Id = Ulid.NewUlid(),
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    MiddleName = request.MiddleName,
                    Email = request.Email,
                    ProfileImage = request.ProfileImage,
                    ProfileText = request.ProfileText,
                    PhoneNumber = request.PhoneNumber,
                    Region = request.Region,
                    State = request.State,
                    CountryCode = request.CountryCode,
                    Dob = request.Dob,
                    ModifiedBy = request.CreatedBy,
                    ModifiedOn = request.CreatedOn,
                    IsActive = true,
                    type = request.type,
                };

                _DbContext.Hairdressers.Add(hairdresser);
                await _DbContext.SaveChangesAsync();

                var response = new HairDresserDto(hairdresser);
                
                return new Result<HairDresserDto>(true) { Model = response };

            } catch (Exception ex)
            {
                _logger.LogError(ex, "CreateHairDresser");
                return new Result<HairDresserDto>(false, "Saving Error");
            }
           
        }

        public async Task<Result> DeleteById(Ulid id)
        {
            try
            {
                _logger.LogInformation("Delete HairDresser from db");
                var hairDresser = await _DbContext.Hairdressers.FindAsync(id);
                
                if (hairDresser == null)
                {
                    return new Result<HairDresserDto>(false, $"HairDresser with Id {id} not found");
                }


                _DbContext.Hairdressers.Remove(hairDresser);
                await _DbContext.SaveChangesAsync();



                return new Result<HairDresserDto>(true) { };
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Delete");
                return new Result<HairDresserDto>(false, "Error delete db");
            }
        }

        //Get all HairDresser 

        public async Task<Result<List<HairDresserDto>>> GetAll()
        {
            try
            {
                _logger.LogInformation("Get HairDresser from db");
                var hairdressers = await _DbContext.Hairdressers.ToListAsync();

                var list = hairdressers.Select(hairdresser => new HairDresserDto(hairdresser));
               

                return new Result<List<HairDresserDto>>(true) { Model = list.ToList() };
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "GetAll");
                return new Result<List<HairDresserDto>>(false, "Error fetching from db");
            }
        }

        public async Task<Result<HairDresserDto>> GetById(Ulid id)
        {
            try
            {
                _logger.LogInformation("Get HairStyle from db");
                var hairDresser = await _DbContext.Hairdressers.FindAsync(id);
                if (hairDresser == null)
                {
                    return new Result<HairDresserDto>(false, $"HairStyle with Id {id} not found");

                }

                var response = new HairDresserDto()
                {
                    id = hairDresser.Id,
                    FirstName = hairDresser.FirstName,
                    LastName = hairDresser.LastName,
                    MiddleName = hairDresser.MiddleName,
                    Email = hairDresser.Email,
                    ProfileImage = hairDresser.ProfileImage,
                    ProfileText = hairDresser.ProfileText,
                    PhoneNumber = hairDresser.PhoneNumber,
                    Region = hairDresser.Region,
                    State = hairDresser.State,
                    CountryCode = hairDresser.CountryCode,
                };

                return new Result<HairDresserDto>(true) { Model = response };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "CreateHiarStyle");
                return new Result<HairDresserDto>(false, "Error fecthing db");
            }
        }
    }
}
