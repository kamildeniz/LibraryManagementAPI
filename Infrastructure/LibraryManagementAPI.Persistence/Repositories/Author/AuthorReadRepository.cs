using LibraryManagementAPI.Application.Repositories;
using LibraryManagementAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementAPI.Persistence.Repositories
{
    public class AuthorReadRepository : ReadRepository<Author>, IAuthorReadRepository
    {
        public AuthorReadRepository(LibraryManagementAPIDbContext context) : base(context)
        {
        }

        public async Task<List<Author>> GetByNationAsync(string Nationality, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = Table.AsNoTracking();
            List<Author> matchingAuthors = await query
        .Where(a => a.Nationality == Nationality)
        .ToListAsync();

            return  matchingAuthors;
        }


    }
}
