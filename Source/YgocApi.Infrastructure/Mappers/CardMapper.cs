using YgocApi.Domain.Model.Read;
using YgocApi.Infrastructure.Daos;

namespace YgocApi.Infrastructure.Mappers;

public static class CardMapper
{
    public static CardModel MapCardInfo(this CardDao cardDao)
    {
        return new()
        {
            CardId = cardDao.CardId,
            CardName = cardDao.CardName,
            CardNumber = cardDao.CardNumber,
            Condition = cardDao.Condition,
            DateBought = cardDao.DateBought,
            Language = cardDao.Language,
            Printing = cardDao.Printing,
            Rarity = cardDao.Printing,
            SetCode = cardDao.SetCode,
            SetName = cardDao.SetName
        };
    }
}