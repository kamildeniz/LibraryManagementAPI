namespace LibraryManagementAPI.Application.Features.Queries.BorrowedBook.GetByBorrow
{
    public class GetByBorrowQueryResponse
    {
        public DateTime BorrowedDate { get; set; }
        public bool BorrowedStatus { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public Guid MemberId { get; set; }
        public Guid BookId { get; set; }
    }
}