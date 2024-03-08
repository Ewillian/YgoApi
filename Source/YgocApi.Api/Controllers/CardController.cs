using System.Net;

using Microsoft.AspNetCore.Mvc;

namespace YgocApi.Api.Controllers
{
    [Produces("application/json")]
    [Route("/card")]
    public class CardController(ICardHandler cardHandler) : Controller
    {
        #region Fields

        private readonly ICardHandler _cardHandler = cardHandler ?? throw new ArgumentNullException(nameof(cardHandler));

        #endregion Fields

        #region Public methods

        [ProducesResponseType(typeof(GetCardResponse), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.InternalServerError)]
        [HttpGet("/{cardId}", Name = nameof(GetCard))]
        public IActionResult GetCard(string cardId)
        {
            return Ok(cardId);
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
