using LibraryManagementAPI.Application.Repositories;
using LibraryManagementAPI.Domain.Entities;

namespace LibraryManagementAPI.Persistence.Repositories
{
    public class BookBorrowedReadRepository : ReadRepository<BookBorrowed>, IBookBorrowedReadRepository
    {
        public BookBorrowedReadRepository(LibraryManagementAPIDbContext context) : base(context)
        {
        }
    }
}
