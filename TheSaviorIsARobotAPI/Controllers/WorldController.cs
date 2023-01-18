using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheSaviorIsARobotAPI.DTO;
using TheSaviorIsARobotAPI.Services;

namespace TheSaviorIsARobotAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorldController : ControllerBase
    {
        private readonly WorldService WorldService;

        public WorldController(WorldService WorldService)
        {
            this.WorldService = WorldService;
        }

        [HttpGet("{id}")]
        public IActionResult GetOne([FromRoute] int id)
        {
            WorldDTO? entry = WorldService.GetOne(id);
            if (entry is null) return BadRequest("Ce monde n'existe pas !");
            return Ok(entry);
        }

        [HttpPatch]
        public IActionResult UpdateWorld([FromQuery] PollutionDTO pollutionDTO)
        {
            try
            {
                WorldService.UpdateWorld(pollutionDTO);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
