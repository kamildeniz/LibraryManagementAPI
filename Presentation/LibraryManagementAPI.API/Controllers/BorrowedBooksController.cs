using LibraryManagementAPI.Application.Features.Commands.BorrowedBook.BorrowBook;
using LibraryManagementAPI.Application.Features.Commands.BorrowedBook.ReturnBook;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementAPI.API.Controllers
{

    public class BorrowedBooksController : BaseController
    {
        public BorrowedBooksController(IMediator mediator, ILogger<BookController> logger) : base(mediator, logger)
        {
        }
        [HttpPost]
        public async Task<IActionResult> BorrowBook(BorrowBookCommandRequest request)
        {
            BorrowBookCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }    [HttpPut]
        public async Task<IActionResult> ReturnBorrow(ReturnBookCommandRequest request)
        {
            ReturnBookCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
