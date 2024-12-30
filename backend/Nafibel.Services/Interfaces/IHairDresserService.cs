using Nafibel.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafibel.Services.Interfaces
{
    public interface IHairDresserService
    {
        Task<Result<HairDresserDto>?> CreateHairDresser(CreateHairDresserRequestDto request);
        Task<Result<List<HairDresserDto>>> GetAll();
        Task<Result<HairDresserDto>> GetById(Ulid id);
        Task<Result> DeleteById(Ulid id);
    }
}
