using LibraryManagementAPI.Application.Repositories;
using LibraryManagementAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementAPI.Persistence.Repositories
{
    public class BookBorrowedWriteRepository : WriteRepository<BookBorrowed>, IBookBorrowedWriteRepository
    {
        public BookBorrowedWriteRepository(LibraryManagementAPIDbContext context) : base(context)
        {
        }

        public async Task<bool> BorrowBookAsync(BookBorrowed bookBorrowed)
        {
            EntityEntry<BookBorrowed> entityEntry = await Table.AddAsync(bookBorrowed);
            bookBorrowed.DueDate = DateTime.UtcNow.AddDays(15);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> ReturnBookAsync( BookBorrowed bookBorrowed)
        {
           
            if (bookBorrowed == null)
            {
                return false; 
            }

            bookBorrowed.ReturnDate = DateTime.UtcNow; 
            return Update(bookBorrowed); 
        }
    }
}
