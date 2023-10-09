namespace LibraryManagementAPI.Domain.Exceptions
{
    public class BookNotFoundException : LibraryException
    {
        public int BookId { get; }

        public BookNotFoundException(int bookId)
            : base($"Kitap bulunamadı. Kitap Kimlik Numarası: {bookId}")
        {
            BookId = bookId;
        }
    }
}
