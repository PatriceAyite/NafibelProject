using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Nafibel.Data.Model;
using Nafibel.Data.Repositories;
using Nafibel.Services.Dtos;
using Nafibel.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafibel.Services.Implematations
{
    public class ClientService : IClientService
    {
        private readonly NafibelDbContext _DbContext;
        private readonly ILogger<ClientService> _logger;

        public ClientService(NafibelDbContext dbContext, ILogger<ClientService> logger)
        {
            this._DbContext = dbContext;
            this._logger = logger;
        }

        public async Task<Result<ClientDto>> CreateClient(CreateClientRequestDto request)
        {
            try
            {
                _logger.LogInformation("Creating client in database...");

               
                if (request.Location == null ||
                    request.Location.X == 0 || request.Location.Y == 0)
                {
                    throw new ArgumentException("Invalid location coordinates.");
                }

               
                var location = new NetTopologySuite.Geometries.Point(request.Location.X, request.Location.Y)
                {
                    SRID = 4326 
                };

                
                var client = new Client
                {
                    Id = Ulid.NewUlid(),
                    AgeRange = request.AgeRange,
                    CountryCode = request.CountryCode,
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    MiddleName = request.MiddleName,
                    PhoneNumber = request.PhoneNumber,
                    State = request.State,
                    Region = request.Region,
                    Email = request.Email,
                    Location = location, 
                    IsActive = true,
                    CreatedBy = request.CreatedBy,
                    CreatedOn = request.CreatedOn,
                    ModifiedOn = request.CreatedOn,
                    ModifiedBy = request.CreatedBy
                };

               
                _DbContext.Clients.Add(client);
                await _DbContext.SaveChangesAsync();


                var response = new ClientDto(client);
               

                return new Result<ClientDto>(true) { Model = response };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating client");
                return new Result<ClientDto>(false, "Saving error");
            }
        }

        public async Task<Result> DeleteById(Ulid id)
        {
            try
            {
                _logger.LogInformation("Delete from Database!");
                var client = await _DbContext.Clients.FindAsync(id);
                if(client == null)
                {
                    return new Result<ClientDto>(false, $"Client with Id {id} not found");
                }

                _DbContext.Clients.Remove(client);
                await _DbContext.SaveChangesAsync();

                return new Result<ClientDto>(true) { };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Delete");
                return new Result<ClientDto>(false, "Error delete db");
            }
        }

        public async Task<Result<List<ClientDto>>> GetAll()
        {
            try
            {
                _logger.LogInformation("Get HairDresser from db");
                var clients = await _DbContext.Clients.ToListAsync();

                var list = clients.Select(client => new ClientDto(client));
              

                return new Result<List<ClientDto>>(true) { Model = list.ToList() };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetAll");
                return new Result<List<ClientDto>>(false, "Error fetching from db");
            }


        }

        public async Task<Result<ClientDto>> GetById(Ulid id)
        {
            try
            {
                _logger.LogInformation("Get Client from db");
                var client = await _DbContext.Clients.FindAsync(id);
                if (client == null)
                {
                    return new Result<ClientDto>(false, $"Client with Id {id} not found ");
                }

                var response = new ClientDto(client);


                return new Result<ClientDto>(true) { Model = response };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Client GetAll");
                return new Result<ClientDto>(false, "Error fecthing db");
            }
        }
    }
}
