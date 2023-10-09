namespace LibraryManagementAPI.Domain.Entities
{
    public class BookImageFile : File
    {
        public bool Showcase { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
