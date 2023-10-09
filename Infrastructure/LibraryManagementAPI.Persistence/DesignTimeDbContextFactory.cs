using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace LibraryManagementAPI.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<LibraryManagementAPIDbContext>
    {
        public LibraryManagementAPIDbContext CreateDbContext(string[] args)
        {

            DbContextOptionsBuilder<LibraryManagementAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new LibraryManagementAPIDbContext(dbContextOptionsBuilder.Options);
        }
    }
}
