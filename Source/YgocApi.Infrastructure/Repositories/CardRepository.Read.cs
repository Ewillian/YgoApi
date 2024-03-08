using MongoDB.Driver;

using YgocApi.Domain.Model.Read;
using YgocApi.Infrastructure.Daos;
using YgocApi.Infrastructure.Mappers;

namespace YgocApi.Infrastructure.Repositories;

public partial class CardRepository
{
    public async Task<CardModel> GetCardByIdAsync(string cardId)
    {
        var filter = Builders<CardDao>.Filter.Eq(x => x.CardId, cardId);

        var productDao = await _cardCollection.Find(filter, _findOptions).FirstOrDefaultAsync();

        return productDao.MapCardInfo();
    }
}