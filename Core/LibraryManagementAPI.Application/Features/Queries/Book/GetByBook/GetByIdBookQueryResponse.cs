namespace LibraryManagementAPI.Application.Features.Queries.Book.GetByBook
{
    public class GetByIdBookQueryResponse
    {
        public string? Name { get; set; }
        public string ISBN { get; set; }
        public bool BorrowedStatus { get; set; }
        public DateTime PublicationDate { get; set; }
    }
}
