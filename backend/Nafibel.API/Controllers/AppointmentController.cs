using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nafibel.Services.Dtos;
using Nafibel.Services.Interfaces;

namespace Nafibel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly ILogger<AppointmentController> _logger;
        private readonly IAppointment _AppointmentService;

        public AppointmentController(ILogger<AppointmentController> logger, IAppointment appointmentService)
        {
            _logger = logger;
            _AppointmentService = appointmentService;
        }


        [HttpPost]
        public async Task<IActionResult> CreateAppointment(CreateAppointmentRequestDto request)
        {
            var result = await this._AppointmentService.CreateAppointment(request);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result.Model);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] string? token)
        {
            var result = await this._AppointmentService.GetAll();
            if (!result.Success)
            {
                return NotFound(result.Errror);
            }
            return Ok(result.Model);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Ulid id)
        {
            var result = await this._AppointmentService.GetById(id);
            if (!result.Success)
            {
                return NotFound(result.Errror);
            }
            return Ok(result.Model);
        }
    }
}
