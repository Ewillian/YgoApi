using Microsoft.Extensions.Options;

namespace YgocApi.Domain.Options;

public class CardRepositoryOptions : IOptions<CardRepositoryOptions>
{
    /// <summary>
    /// TODO
    /// </summary>
    public string ConnectionString { get; set; } = null!;

    /// <summary>
    /// TODO
    /// </summary>
    public string Database { get; set; } = null!;


    /// <summary>
    /// The collection.
    /// </summary>
    public string Collection { get; set; } = null!;

    /// <summary>
    /// TODO
    /// </summary>
    public int MaxTimeMS { get; set; } = 10000;

    /// <summary>
    /// TODO
    /// </summary>
    public bool AllowDiskUse { get; set; } = false;

    /// <summary>
    /// TODO
    /// </summary>
    public int MinConnectionPoolSize { get; set; } = 100;

    /// <summary>
    /// TODO
    /// </summary>
    public int MaxConnectionPoolSize { get; set; } = 1000;

    CardRepositoryOptions IOptions<CardRepositoryOptions>.Value => this;
}