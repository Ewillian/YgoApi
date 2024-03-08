using YgocApi.Domain.Model.Read;

public interface ICardHandler
{
    /// <summary>
    /// TODO
    /// </summary>
    /// <param name="cardId"></param>
    /// <returns></returns>
    Task<CardModel> GetCardByIdAsync(string cardId);
}