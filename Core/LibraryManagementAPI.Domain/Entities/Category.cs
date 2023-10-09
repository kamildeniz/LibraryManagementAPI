using LibraryManagementAPI.Domain.Entities.Common;

namespace LibraryManagementAPI.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string? Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
