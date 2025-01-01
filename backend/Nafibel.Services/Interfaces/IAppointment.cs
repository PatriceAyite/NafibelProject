using Nafibel.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafibel.Services.Interfaces
{
    public interface IAppointment
    {
        Task<Result<AppointmentDto>> CreateAppointment(CreateAppointmentRequestDto request);
        Task<Result<List<AppointmentDto>>> GetAll();
        Task<Result<AppointmentDto>> GetById(Ulid id);
        Task<Result> DeleteById(Ulid id);
    }
}
