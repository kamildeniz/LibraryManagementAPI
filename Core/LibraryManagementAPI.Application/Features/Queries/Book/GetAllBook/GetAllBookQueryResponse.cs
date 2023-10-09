namespace LibraryManagementAPI.Application.Features.Queries.Book.GetAllBook
{
    public class GetAllBookQueryResponse
    {
        public int TotalBookCount { get; set; }
        public object Books { get; set; }
    }
}
