using MediatR;

namespace LibraryManagementAPI.Application.Features.Commands.Book.RemoveBook
{
    public class RemoveBookCommandRequest : IRequest<RemoveBookCommandResponse>
    {
        public string Id { get; set; }
    }
}
