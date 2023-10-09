using MediatR;

namespace LibraryManagementAPI.Application.Features.Commands.Book.UpdateBook
{
    public class UpdateBookCommandRequest : IRequest<UpdateBookCommandResponse>
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        public string ISBN { get; set; }
        public DateTime PublicationDate { get; set; }

    }
}
