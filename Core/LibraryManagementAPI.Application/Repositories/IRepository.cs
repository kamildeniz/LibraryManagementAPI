using LibraryManagementAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementAPI.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
