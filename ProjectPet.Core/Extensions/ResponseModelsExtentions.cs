using Microsoft.EntityFrameworkCore;
using ProjectPet.Core.ResponseModels;

namespace ProjectPet.Core.Extensions;
public static class ResponseModelsExtentions
{
    public static async Task<PagedList<T>> ToPagedListAsync<T>(
    this IQueryable<T> queryable,
    PaginatedQueryBase query,
    CancellationToken cancellationToken = default)
    {
        return await queryable.ToPagedListAsync(query.Skip, query.RecordAmount, query.Page, cancellationToken);
    }

    public static async Task<PagedList<T>> ToPagedListAsync<T>(
        this IQueryable<T> queryable,
        int skip,
        int take,
        int page,
        CancellationToken cancellationToken = default)
    {
        var count = await queryable.CountAsync(cancellationToken);

        var data = await queryable
            .Skip(skip)
            .Take(take)
            .ToListAsync(cancellationToken);

        return new PagedList<T>()
        {
            Data = data,
            PageIndex = page,
            PageSize = take,
            TotalCount = count
        };
    }
}
