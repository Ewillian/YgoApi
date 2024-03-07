using Microsoft.Extensions.Options;
using YgocApi.Domain.Options;
using YgocApi.Infrastructure.Dtos;

namespace YgocApi.Infrastructure.Repositories;

public class CardRepository
{
    #region Fields

    /// <summary>
    /// The product referential api options
    /// </summary>
    private readonly IOptions<CardRepositoryOptions> _options;

    #endregion Fields

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="CardRepository"/> class
    /// </summary>
    /// <param name="options">The options</param>
    public CardRepository(IOptions<CardRepositoryOptions> options)
    {
        _options = options ?? throw new ArgumentNullException(nameof(options));
    }

    #endregion Constructors

    #region Public methods

    public async Task<CardDto> GetCardUnitary(string cardNumber)
    {

    }

    #endregion Public methods
}