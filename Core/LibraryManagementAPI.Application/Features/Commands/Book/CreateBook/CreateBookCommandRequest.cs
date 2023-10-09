using LibraryManagementAPI.Application.DTOs;
using MediatR;

namespace LibraryManagementAPI.Application.Features.Commands.Book.CreateBook
{
    public class CreateBookCommandRequest : IRequest<CreateBookCommandResponse>
    {
        public string? Name { get; set; }
        public string ISBN { get; set; }
        public bool BorrowedStatus { get; set; }
        public DateTime PublicationDate { get; set; }
        public Guid PublisherId { get; set; }
        public Guid AuthorId { get; set; }

    }
}
