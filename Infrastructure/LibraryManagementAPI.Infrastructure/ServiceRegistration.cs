
using LibraryManagementAPI.Application.Interfaces.Services;
using LibraryManagementAPI.Application.Interfaces.Storage;
using LibraryManagementAPI.Application.Interfaces.Token;
using LibraryManagementAPI.Infrastructure.Enums;
using LibraryManagementAPI.Infrastructure.Services;
using LibraryManagementAPI.Infrastructure.Services.Storage;
using LibraryManagementAPI.Infrastructure.Services.Storage.Azure;
using LibraryManagementAPI.Infrastructure.Services.Storage.Local;
using LibraryManagementAPI.Infrastructure.Services.Token;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManagementAPI.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IStorageService, StorageService>();
            serviceCollection.AddScoped<ITokenHandler, TokenHandler>();
            serviceCollection.AddScoped<IMailService, MailService>();
        }
        public static void AddStorage<T>(this IServiceCollection serviceCollection) where T : Storage, IStorage
        {
            serviceCollection.AddScoped<IStorage, T>();
        }
        //public static void AddStorage(this IServiceCollection serviceCollection, StorageType storageType)
        //{
        //    switch (storageType)
        //    {
        //        case StorageType.Local:
        //            serviceCollection.AddScoped<IStorage, LocalStorage>();
        //            break;
        //        case StorageType.Azure:
        //            serviceCollection.AddScoped<IStorage, AzureStorage>();
        //            break;
        //        case StorageType.AWS:

        //            break;
        //        default:
        //            serviceCollection.AddScoped<IStorage, LocalStorage>();
        //            break;
        //    }
        //}
    }
}