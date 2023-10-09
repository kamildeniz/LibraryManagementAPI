using LibraryManagementAPI.Domain.Entities;

namespace LibraryManagementAPI.Application.Repositories
{
    public interface IBookBorrowedWriteRepository : IWriteRepository<BookBorrowed>
    {
        Task<bool> BorrowBookAsync(BookBorrowed bookBorrowed);
        Task<bool> ReturnBookAsync(BookBorrowed bookBorrowed);
    }
}
