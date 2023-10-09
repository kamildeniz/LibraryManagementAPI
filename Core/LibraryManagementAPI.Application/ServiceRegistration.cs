using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManagementAPI.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection collection)
        {
            collection.AddMediatR(typeof(ServiceRegistration));
            collection.AddAutoMapper(typeof(ServiceRegistration));
            collection.AddHttpClient();
        }
    }
}
