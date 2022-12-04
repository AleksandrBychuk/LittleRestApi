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
        private readonly ILogger<HomeController> _logger;
        public HomeController(ISomeDataService service, ILogger<HomeController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// Gets a range of data from {from} to {to}
        /// </summary>
        /// <param name="from">Start</param>
        /// <param name="to">Finish</param>
        /// <returns>List<SomeData></returns>
        [HttpGet("somedatas-range")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetSomeDatasRange(int from = 0, int to = 0)
        {
            var result = await _service.GetSomeDatasRange(from, to);
            if (result.Count == 0)
                return NotFound();
            _logger.LogInformation($"Returned somedatas range from {from} to {to}!");
            return Ok(result);
        }
    }
}
