using LibraryManagementAPI.Domain.Entities.Common;

namespace LibraryManagementAPI.Domain.Entities
{
    public class Book : BaseEntity
    {
        public string? Name { get; set; }
        public string ISBN { get; set; }
        public bool BorrowedStatus { get; set; }
        public DateTime PublicationDate { get; set; }
        public Guid PublisherId { get; set; }
        public Guid AuthorId { get; set; }
        public ICollection<BookImageFile> BookImageFiles { get; set; }

    }
}
