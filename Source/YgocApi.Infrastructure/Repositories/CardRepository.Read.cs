using MongoDB.Driver;

using YgocApi.Infrastructure.Dtos;

namespace YgocApi.Infrastructure.Repositories;

public partial class CardRepository
{
    public async Task<CardDao?> GetCardByIdAsync(string id)
    {
        var filter = Builders<CardDao>.Filter.Eq(x => x.CardId, id);

        var productDao = await _cardCollection.Find(filter, _findOptions).FirstOrDefaultAsync();
        return productDao;
    }
}