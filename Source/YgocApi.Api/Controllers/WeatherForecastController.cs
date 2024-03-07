using Microsoft.AspNetCore.Mvc;

namespace YgocApi.Api.Controllers
{
    [ApiController]
    [Route("ygoc/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet("greet")]
        public IActionResult Greet()
        {
            return Ok("Hello, Playwright!");
        }

        [HttpGet("numbers")]
        public IActionResult GetNumbers()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            return Ok(numbers);
        }
    }
}
