using MediatR;

namespace LibraryManagementAPI.Application.Features.Commands.BorrowedBook.ReturnBook
{
    public class ReturnBookCommandRequest:IRequest<ReturnBookCommandResponse>
    {
        public string Id { get; set; }
    }
}