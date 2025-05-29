using System.Collections;

namespace ProjectPet.Core.ResponseModels;

public class PagedList<T> : IEnumerable<T>
{
    public IReadOnlyList<T>? Data { get; init; } = [];
    public int TotalCount { get; init; }
    public int PageSize { get; init; }
    public int PageIndex { get; init; }
    public bool HasNextPage => PageSize * PageIndex <= TotalCount;
    public bool HasPreviousPage => PageIndex > 1;

    public IEnumerator<T> GetEnumerator()
    {
        return Data!.GetEnumerator();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return Data!.GetEnumerator();
    }
}