using LibraryManagementAPI.Application.Repositories;
using LibraryManagementAPI.Domain.Entities;

namespace LibraryManagementAPI.Persistence.Repositories
{
    public class PublisherWriteRepository : WriteRepository<Publisher>, IPublisherWriteRepository
    {
        public PublisherWriteRepository(LibraryManagementAPIDbContext context) : base(context)
        {
        }
    }
}
