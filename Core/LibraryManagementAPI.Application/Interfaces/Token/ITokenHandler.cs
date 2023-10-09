using LibraryManagementAPI.Domain.Entities.Identity;

namespace LibraryManagementAPI.Application.Interfaces.Token
{
    public interface ITokenHandler
    {
        DTOs.Token CreateAccessToken(int second, AppUser appUser);
        string CreateRefreshToken();
    }
}
