namespace YgocApi.Domain.Model.Read;

/// <summary>
/// Defines the card model
/// </summary>
public class CardModel
{
    /// <summary>
    /// 
    /// </summary>
    public string CardId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string CardNumber { get; set; }

    /// <summary>
    /// Gets or sets the card name
    /// </summary>*
    public string CardName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string SetCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string SetName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Rarity { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Condition { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Printing { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Language { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string DateBought { get; set; }
}