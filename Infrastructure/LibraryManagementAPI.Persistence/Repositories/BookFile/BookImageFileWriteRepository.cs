using LibraryManagementAPI.Application.Repositories;
using LibraryManagementAPI.Domain.Entities;

namespace LibraryManagementAPI.Persistence.Repositories
{
    public class BookImageFileWriteRepository : WriteRepository<BookImageFile>, IBookImageFileWriteRepository
    {
        public BookImageFileWriteRepository(LibraryManagementAPIDbContext context) : base(context)
        {
        }
    }
}
