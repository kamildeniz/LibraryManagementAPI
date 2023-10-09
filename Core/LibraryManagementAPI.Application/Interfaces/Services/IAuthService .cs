using LibraryManagementAPI.Application.Interfaces.Services.Authentications;

namespace LibraryManagementAPI.Application.Interfaces.Services
{
    public interface IAuthService : IExternalAuthentication, IInternalAuthentication
    {

    }
}
