using Microsoft.Extensions.Options;

namespace YgocApi.Domain.Options;

public class CardRepositoryOptions : IOptions<CardRepositoryOptions>
{
    public string FileLocation { get; set; }

    CardRepositoryOptions IOptions<CardRepositoryOptions>.Value => this;
}