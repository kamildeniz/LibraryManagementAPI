using LibraryManagementAPI.Domain.Entities;
using LibraryManagementAPI.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementAPI.Persistence
{
    public class LibraryManagementAPIDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public LibraryManagementAPIDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookBorrowed> BookBorroweds { get; set; }
        public DbSet<BookImageFile> BookFiles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Domain.Entities.File> Files { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}
