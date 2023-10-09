using LibraryManagementAPI.Domain.Entities.Common;

namespace LibraryManagementAPI.Domain.Entities
{
    public class Publisher : BaseEntity
    {
        public string? Name { get; set; }
        public string? Adress { get; set; }
        public string? PhoneNumber { get; set; }
        public ICollection<Author> Authors { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
