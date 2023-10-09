using MediatR;

namespace LibraryManagementAPI.Application.Features.Commands.Member.UpdateMember
{
    public class UpdateMemberCommandRequest:IRequest<UpdateMemberCommandResponse>
    {
        public string Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? BooksBorrowed { get; set; }
    }
}