using LibraryManagementAPI.Application.Repositories;

namespace LibraryManagementAPI.Persistence.Repositories
{
    public class FileWriteRepository : WriteRepository<Domain.Entities.File>, IFileWriteRepository
    {
        public FileWriteRepository(LibraryManagementAPIDbContext context) : base(context)
        {
        }
    }
}
