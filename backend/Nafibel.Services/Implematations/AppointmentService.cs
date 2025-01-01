using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Nafibel.Data.Model;
using Nafibel.Data.Repositories;
using Nafibel.Services.Dtos;
using Nafibel.Services.Interfaces;
using NetTopologySuite.Geometries;

namespace Nafibel.Services.Implementations
{
    public class AppointmentService : IAppointment
    {
        private readonly NafibelDbContext _dbContext;
        private readonly ILogger<AppointmentService> _logger;

        public AppointmentService(NafibelDbContext dbContext, ILogger<AppointmentService> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public async Task<Result<AppointmentDto>> CreateAppointment(CreateAppointmentRequestDto request)
        {
            try
            {
                _logger.LogInformation("Starting appointment creation process");

                // Validate location
                Point? location = null;
                if (request.Latitude.HasValue && request.Longitude.HasValue)
                {
                    location = new Point(request.Longitude.Value, request.Latitude.Value) { SRID = 4326 }; // WGS84
                }

                // Validate client existence
                var existingClient = await _dbContext.Clients.FindAsync(request.ClientId);
                if (request.ClientId != null && existingClient == null)
                {
                    return new Result<AppointmentDto>(false, $"Client with ID {request.ClientId} not found.");
                }

                // Create appointment
                var appointment = new Appointment
                {
                    Id = Ulid.NewUlid(),
                    AppointmentDate = request.AppointmentDate,
                    From = request.From,
                    To = request.To,
                    HairdresserId = request.HairdresserId,
                    HairStyleId = request.HairStyleId,
                    ClientId = request.ClientId,
                    ClientName = request.ClientName,
                    CountryCode = request.CountryCode,
                    State = request.State,
                    Region = request.Region,
                    LocationType = (Data.Model.LocationTypeEnum)request.LocationType,
                    Location = location,
                    CreatedBy = request.CreatedBy,
                    CreatedOn = request.CreatedOn,
                    ModifiedBy = request.CreatedBy,
                    ModifiedOn = request.CreatedOn,
                    IsActive = true
                };

                _dbContext.Appointments.Add(appointment);
                await _dbContext.SaveChangesAsync();

                var response = new AppointmentDto(appointment);

                return new Result<AppointmentDto>(true) { Model = response };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while creating appointment");
                return new Result<AppointmentDto>(false, "An error occurred while saving the appointment.");
            }
        }

        public async Task<Result> DeleteById(Ulid id)
        {
            try
            {
                _logger.LogInformation("Delete Appointment from");
                var appointment = await _dbContext.Appointments.FindAsync(id);
                if (appointment == null)
                {
                    return new Result<AppointmentDto>(false, $"Appointment with {id} not found ");
                }

                _dbContext.Appointments.Remove(appointment);
                await _dbContext.SaveChangesAsync();

                return new Result<AppointmentDto>(true) { };

            }catch (Exception ex)
            {
                _logger.LogError(ex, "Delete");
                return new Result<AppointmentDto>(false, ex.Message);
            }
        }

        public async Task<Result<List<AppointmentDto>>> GetAll()
        {
            try
            {
                _logger.LogInformation("Get Appointment from db");
                var appointmens = await _dbContext.Appointments.ToArrayAsync();

                var list = appointmens.Select(appointmens => new AppointmentDto(appointmens));

                return new Result<List<AppointmentDto>>(true) { Model = list.ToList() };
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "GetAll");
                return new Result<List<AppointmentDto>>(false, "Error fetching from db");
            }
        }

        public async Task<Result<AppointmentDto>> GetById(Ulid id)
        {
            try
            {
                _logger.LogInformation("Get Appointment from db");
                var appointment = await _dbContext.Appointments.FindAsync(id);
                if (appointment == null)
                {
                    return new Result<AppointmentDto>(false, $"Appointment with {id} not found");
                }

                var response = new AppointmentDto(appointment);

                return new Result<AppointmentDto>(true) { Model = response };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Appointment");
                return new Result<AppointmentDto>(false, "Error fecthing db");
            }
        }  
    }
}