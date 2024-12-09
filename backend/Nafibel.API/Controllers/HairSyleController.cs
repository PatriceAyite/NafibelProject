using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nafibel.Services.Dtos;
using Nafibel.Services.Interfaces;

namespace Nafibel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HairSyleController : ControllerBase
    {

        private readonly ILogger<HairSyleController> _logger;
        private readonly IHairStyleService _hairStyleService;
        public HairSyleController(ILogger<HairSyleController> logger, IHairStyleService hairStyleService )
        {
            this._logger = logger;   
            this._hairStyleService = hairStyleService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateHairStyle(CreateHairStyleRequestDto request)
        {

           var response = await this._hairStyleService.CreateHairStyle(request);

            return Ok(request);
        }


    }
}
