using ETicaretAPI.Persistence.Services;
using LibraryManagementAPI.Application.Interfaces.Services;
using LibraryManagementAPI.Application.Interfaces.Services.Authentications;
using LibraryManagementAPI.Application.Repositories;
using LibraryManagementAPI.Domain.Entities.Identity;
using LibraryManagementAPI.Persistence.Repositories;
using LibraryManagementAPI.Persistence.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManagementAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<LibraryManagementAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequiredLength = 3;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
            }).AddEntityFrameworkStores<LibraryManagementAPIDbContext>();

            services.AddScoped<IAuthorReadRepository, AuthorReadRepository>();
            services.AddScoped<IAuthorWriteRepository, AuthorWriteRepository>();
            services.AddScoped<IBookReadRepository, BookReadRepository>();
            services.AddScoped<IBookWriteRepository, BookWriteRepository>();
            services.AddScoped<IFileReadRepository, FileReadRepository>();
            services.AddScoped<IFileWriteRepository, FileWriteRepository>();
            services.AddScoped<IBookImageFileReadRepository, BookImageFileReadRepository>();
            services.AddScoped<IBookImageFileWriteRepository, BookImageFileWriteRepository>();
            services.AddScoped<IBookBorrowedReadRepository, BookBorrowedReadRepository>();
            services.AddScoped<IBookBorrowedWriteRepository, BookBorrowedWriteRepository>();
            services.AddScoped<IPublisherReadRepository, PublisherReadRepository>();
            services.AddScoped<IPublisherWriteRepository, PublisherWriteRepository>();
            services.AddScoped<IMemberReadRepository, MemberReadRepository>();
            services.AddScoped<IMemberWriteRepository, MemberWriteRepository>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IExternalAuthentication, AuthService>();
            services.AddScoped<IInternalAuthentication, AuthService>();
            services.AddScoped<IBorrowedService, BorrowedService>();

        }
    }
}
