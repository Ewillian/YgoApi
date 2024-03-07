using MongoDB.Bson.Serialization.Attributes;

namespace YgocApi.Infrastructure.Daos;

/// <summary>
/// Defines the card dto
/// </summary>
public class CardDao
{
    /// <summary>
    /// 
    /// </summary>
    [BsonElement("_id")]
    public string CardId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [BsonElement("Card Number")]
    public string CardNumber { get; set; }

    /// <summary>
    /// Gets or sets the card name
    /// </summary>*
    [BsonElement("Card Name")]
    public string CardName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [BsonElement("Quantity")]
    public int TestPlanXray { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [BsonElement("Set Code")]
    public string SetCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [BsonElement("Set Name")]
    public string SetName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [BsonElement("Rarity")]
    public string Rarity { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [BsonElement("Condition")]
    public string Condition { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [BsonElement("Printing")]
    public string Printing { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [BsonElement("Language")]
    public string Language { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [BsonElement("Date Bought")]
    public string DateBought { get; set; }
}