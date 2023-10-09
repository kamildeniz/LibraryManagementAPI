using LibraryManagementAPI.Application.Repositories;
using LibraryManagementAPI.Domain.Entities;

namespace LibraryManagementAPI.Persistence.Repositories
{
    public class MemberReadRepository : ReadRepository<Member>, IMemberReadRepository
    {
        public MemberReadRepository(LibraryManagementAPIDbContext context) : base(context)
        {
        }
    }
}
