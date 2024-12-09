using Nafibel.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Nafibel.Services.Interfaces
{
    public interface IHairStyleService
    {
        Task<HairStyleDto?> CreateHairStyle (CreateHairStyleRequestDto request);
        Task<HairStyleDto> GetById(string id);
        Task<List<HairStyleDto>> GetAll();
    }
}
