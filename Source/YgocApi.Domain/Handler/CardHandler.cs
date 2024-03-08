using YgocApi.Domain.Model.Read;
using YgocApi.Infrastructure.Abstractions;

public sealed partial class CardHandler : ICardHandler
{
    private readonly ICardRepository _cardRepository;

    public CardHandler(ICardRepository cardRepository)
    {
        _cardRepository = cardRepository ?? throw new ArgumentNullException(nameof(cardRepository));
    }
}

public partial class CardHandler
{
    /// <summary>
    /// TODO
    /// </summary>
    /// <param name="cardId"></param>
    /// <returns></returns>
    public async Task<CardModel> GetCardByIdAsync(string cardId)
    {
        return await _cardRepository.GetCardByIdAsync(cardId);
    }
}