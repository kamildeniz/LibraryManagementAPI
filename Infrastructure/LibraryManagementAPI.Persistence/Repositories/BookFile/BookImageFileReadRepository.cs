using LibraryManagementAPI.Application.Repositories;
using LibraryManagementAPI.Domain.Entities;

namespace LibraryManagementAPI.Persistence.Repositories
{
    public class BookImageFileReadRepository : ReadRepository<BookImageFile>, IBookImageFileReadRepository
    {
        public BookImageFileReadRepository(LibraryManagementAPIDbContext context) : base(context)
        {
        }
    }
}
