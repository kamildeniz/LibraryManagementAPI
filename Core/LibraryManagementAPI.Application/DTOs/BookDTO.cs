namespace LibraryManagementAPI.Application.DTOs
{
    public class BookDTO : BaseDTO
    {
        public string? Name { get; set; }
        public int ISBN { get; set; }
        public bool BorrowedStatus { get; set; }
        public DateTime PublicationDate { get; set; }
        public Guid PublisherId { get; set; }
        public Guid AuthorId { get; set; }
    }
}
