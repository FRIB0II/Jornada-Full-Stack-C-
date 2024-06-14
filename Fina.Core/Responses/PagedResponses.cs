using System.Text.Json.Serialization;

namespace Fina.Core.Responses;

public abstract class PagedResponses<TData> : Response<TData>
{
    [JsonConstructor]
    public PagedResponses(
        TData? data,
        int totalCount,
        int currentPage = 1,
        int pageSize = Configuration.DefaultPageSize)
        : base(data)
    {
        Data = data;
        TotalCount = totalCount;
        CurrentPage = currentPage;
        PageSize = pageSize;
    }

    public PagedResponses(
        TData? data,
        int code = Configuration.DefaultStatusCode,
        string? message = null)
        : base(data, code, message)
    {
        
    }
    
    public int CurrentPage { get; set; }
    public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);

    public int PageSize { get; set; } = Configuration.DefaultPageNumber;
    public int TotalCount { get; set; }

}