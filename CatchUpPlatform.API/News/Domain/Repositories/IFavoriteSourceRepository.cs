using CatchUpPlatform.API.News.Domain.Model.Aggregates;
using CatchUpPlatform.API.News.Domain.Model.ValueObjects;
using CatchUpPlatform.API.Shared.Domain.Repositories;

namespace CatchUpPlatform.API.News.Domain.Repositories;

public interface IFavoriteSourceRepository : IBaseRepository<FavoriteSource>
{
    Task<IEnumerable<FavoriteSource>> FindByNewsApiAsync(NewsApiKey newsApiKey, CancellationToken cancellationToken = default);
    Task<FavoriteSource?> FindByNewsApiAndSourceIdAsync(NewsApiKey newsApiKey, SourceId sourceId, CancellationToken cancellationToken = default);
}