using Newtonsoft.Json;

namespace YgocApi.Infrastructure.Dtos;

/// <summary>
/// Defines the card dto
/// </summary>
public class CardDto
{
    /// <summary>
    /// 
    /// </summary>
    [JsonProperty("Card Number")]
    public string CardNumber { get; set; }

    /// <summary>
    /// Gets or sets the card name
    /// </summary>*
    [JsonProperty("Card Name")]
    public string CardName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty("Quantity")]
    public int TestPlanXray { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty("Set Code")]
    public string SetCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty("Set Name")]
    public string SetName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty("Rarity")]
    public string Rarity { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty("Condition")]
    public string Condition { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty("Printing")]
    public string Printing { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty("Language")]
    public string Language { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty("Date Bought")]
    public string DateBought { get; set; }
}