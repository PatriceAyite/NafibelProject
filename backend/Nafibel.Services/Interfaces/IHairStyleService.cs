﻿using Nafibel.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Nafibel.Services.Interfaces
{
    public interface IHairStyleService
    {
        Task<Result<HairStyleDto>?> CreateHairStyle(CreateHairStyleRequestDto request);
        Task<Result<HairStyleDtoWithPrices>> GetById(Ulid id);
        Task<Result> DeleteById(Ulid id);
        Task<Result<List<HairStyleDto>>> GetAll();
    }
}
