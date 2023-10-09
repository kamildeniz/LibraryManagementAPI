using LibraryManagementAPI.Application.DTOs.User;
using LibraryManagementAPI.Domain.Entities.Identity;

namespace LibraryManagementAPI.Application.Interfaces.Services
{
    public interface IUserService
    {
        Task<CreateUserResponse> CreateAsync(CreateUser model);
        Task UpdateRefreshToken(string refreshToken, AppUser user, DateTime accessTokenDate, int addOnAccessTokenDate);
    }
}
