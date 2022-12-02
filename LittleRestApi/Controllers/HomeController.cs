using LittleRestApi.Models;
using LittleRestApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace LittleRestApi.Controllers
{
    [ApiController]
    [Route("api")]
    public class HomeController : Controller
    {
        private readonly ISomeDataService _service;
        public HomeController(ISomeDataService service)
        {
            _service = service;
        }

        [HttpGet("somedatas-range")]
        /// <summary>
        /// Gets a range of data from {from} to {to}
        /// </summary>
        /// <param name="from">Start</param>
        /// <param name="to">Finish</param>
        /// <returns>List<SomeData></returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<SomeData>>> GetSomeDatasRange(int from = 0, int to = 0)
        {
            var result = await _service.GetSomeDatasRange(from, to);
            if (result.Count == 0)
                return NotFound();
            return Ok(result);
        }
    }
}
