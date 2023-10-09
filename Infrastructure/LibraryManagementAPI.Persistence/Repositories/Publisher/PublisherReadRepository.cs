using LibraryManagementAPI.Application.Repositories;

namespace LibraryManagementAPI.Persistence.Repositories
{
    public class PublisherReadRepository : ReadRepository<Domain.Entities.Publisher>, IPublisherReadRepository
    {
        public PublisherReadRepository(LibraryManagementAPIDbContext context) : base(context)
        {
        }
    }
}
