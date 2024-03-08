using Microsoft.Extensions.Options;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

using YgocApi.Domain.Options;
using YgocApi.Infrastructure.Abstractions;
using YgocApi.Infrastructure.Daos;

namespace YgocApi.Infrastructure.Repositories;

public partial class CardRepository : ICardRepository
{
    #region Fields

    /// <summary>
    /// 
    /// </summary>
    private IMongoDatabase Database { get; set; }

    /// <summary>
    /// TODO
    /// </summary>
    private readonly IMongoCollection<CardDao> _cardCollection;

    /// <summary>
    /// The product referential api options
    /// </summary>
    private readonly IOptions<CardRepositoryOptions> _options;

    /// <summary>
    /// 
    /// </summary>
    private readonly FindOptions _findOptions;

    #endregion Fields

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="CardRepository"/> class
    /// </summary>
    /// <param name="options">The options</param>
    public CardRepository(IOptions<CardRepositoryOptions> options)
    {
        _options = options ?? throw new ArgumentNullException(nameof(options));

        _findOptions = new FindOptions
        {
            MaxTime = TimeSpan.FromMilliseconds(_options.Value.MaxTimeMS),
            AllowDiskUse = _options.Value.AllowDiskUse
        };

        var pack = new ConventionPack
        {
            new CamelCaseElementNameConvention(),
            new EnumRepresentationConvention(BsonType.String),
            new IgnoreExtraElementsConvention(true),
            new IgnoreIfNullConvention(true)
        };
        ConventionRegistry.Register("camel case", pack, t => true);
        ConventionRegistry.Register("EnumStringConvention", pack, t => true);

        var clientSettings = MongoClientSettings.FromConnectionString(options.Value.ConnectionString);
        clientSettings.MinConnectionPoolSize = options.Value.MinConnectionPoolSize;
        clientSettings.MaxConnectionPoolSize = options.Value.MaxConnectionPoolSize;
        Database = new MongoClient(clientSettings).GetDatabase(options.Value.Database);

        _cardCollection = Database.GetCollection<CardDao>(options.Value.Collection);
    }

    #endregion Constructors
}