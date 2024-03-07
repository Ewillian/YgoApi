using Microsoft.AspNetCore.Mvc;

namespace YgocApi.Api.Controllers
{
    [Produces("application/json")]
    [Route("/Cards")]
    public class CardController : Controller
    {
        #region Contructors
        
        #endregion Contructors

        #region Public methods

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

        #endregion Public methods
    }
}
