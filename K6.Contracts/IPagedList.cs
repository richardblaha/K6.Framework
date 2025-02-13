namespace K6.Contracts;

public interface IPagedList<TItem>
{
    int Skip { get; }
    int Take { get; }
    int Total { get; }
    IList<TItem> Items { get; }
}