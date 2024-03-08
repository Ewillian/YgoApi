using YgocApi.Domain.Model.Read;

namespace YgocApi.Infrastructure.Abstractions;

public interface ICardRepository
{
    /// <summary>
    /// TODO
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<CardModel> GetCardByIdAsync(string id);
}