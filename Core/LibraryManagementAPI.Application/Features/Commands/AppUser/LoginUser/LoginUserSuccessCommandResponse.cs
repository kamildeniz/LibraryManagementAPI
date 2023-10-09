using LibraryManagementAPI.Application.DTOs;

namespace LibraryManagementAPI.Application.Features.Commands.AppUser.LoginUser
{
    public class LoginUserSuccessCommandResponse : LoginUserCommandResponse
    {
        public Token Token { get; set; }
    }
}
