using LibraryManagementAPI.Application.Features.Commands.Author.CreateAuthor;
using LibraryManagementAPI.Application.Features.Commands.Author.RemoveAuthor;
using LibraryManagementAPI.Application.Features.Commands.Author.UpdateAuthor;
using LibraryManagementAPI.Application.Features.Commands.Book.CreateBook;
using LibraryManagementAPI.Application.Features.Queries.Author.GetAllAuthor;
using LibraryManagementAPI.Application.Features.Queries.Author.GetByAuthor;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace LibraryManagementAPI.API.Controllers
{

    public class AuthorController : BaseController
    {
        public AuthorController(IMediator mediator, ILogger<BookController> logger) : base(mediator, logger)
        {
        }


        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllAuthorQueryRequest request)
        {
            GetAllAuthorQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute]GetByAuthorQueryRequest request)
        {
            GetByAuthorQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateAuthorCommandRequest createAuthorCommandRequest)
        {
            CreateAuthorCommandResponse response = await _mediator.Send(createAuthorCommandRequest);
            return Ok(response);

        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody]UpdateAuthorCommandRequest request)
        {
            UpdateAuthorCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveAuthorCommandRequest request)
        {
            RemoveAuthorCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
