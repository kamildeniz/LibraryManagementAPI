using LibraryManagementAPI.Domain.Entities;

namespace LibraryManagementAPI.Application.Repositories
{
    public interface IAuthorReadRepository : IReadRepository<Author>
    {
        Task<List<Author>> GetByNationAsync(string Nationality, bool tracking = true);
    }
}
