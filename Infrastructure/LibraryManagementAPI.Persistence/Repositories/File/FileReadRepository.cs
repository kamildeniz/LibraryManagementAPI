using LibraryManagementAPI.Application.Repositories;

namespace LibraryManagementAPI.Persistence.Repositories
{
    public class FileReadRepository : ReadRepository<Domain.Entities.File>, IFileReadRepository
    {
        public FileReadRepository(LibraryManagementAPIDbContext context) : base(context)
        {
        }
    }
}
