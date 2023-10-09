using LibraryManagementAPI.Application.Features.Commands.Book.CreateBook;
using LibraryManagementAPI.Application.Features.Commands.Book.RemoveBook;
using LibraryManagementAPI.Application.Features.Commands.Book.UpdateBook;
using LibraryManagementAPI.Application.Features.Commands.BookImageFile.RemoveBookImage;
using LibraryManagementAPI.Application.Features.Commands.BookImageFile.UploadBookImage;
using LibraryManagementAPI.Application.Features.Queries.Book.GetAllBook;
using LibraryManagementAPI.Application.Features.Queries.Book.GetByBook;
using LibraryManagementAPI.Application.Features.Queries.BookImageFile.GetBookImageFile;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace LibraryManagementAPI.API.Controllers
{
    public class BookController : BaseController
    {
        public BookController(IMediator mediator, ILogger<BookController> logger) : base(mediator, logger)
        {
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllBookQueryRequest getAllBookQueryRequest)
        {
            _logger.LogInformation("asmdlasmdlamsd");
            GetAllBookQueryResponse response = await _mediator.Send(getAllBookQueryRequest);
            return Ok(response);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdBookQueryRequest getByIdBookQueryRequest)
        {
            GetByIdBookQueryResponse response = await _mediator.Send(getByIdBookQueryRequest);
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateBookCommandRequest createBookCommandRequest)
        {
            CreateBookCommandResponse response = await _mediator.Send(createBookCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);

        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateBookCommandRequest updateBookCommandRequest)
        {
            UpdateBookCommandResponse response = await _mediator.Send(updateBookCommandRequest);
            return Ok(response);
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveBookCommandRequest removeBookCommandRequest)
        {
            RemoveBookCommandResponse response = await _mediator.Send(removeBookCommandRequest);
            return Ok();
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Upload([FromQuery] UploadBookImageCommandRequest uploadBookImageCommandRequest)
        {
            uploadBookImageCommandRequest.Files = Request.Form.Files;
            UploadBookImageCommandResponse response = await _mediator.Send(uploadBookImageCommandRequest);
            return Ok();
        }

        [HttpGet("[action]/{Id}")]
        public async Task<IActionResult> GetBookImage([FromRoute] GetBookImageFileQueryRequest getBookImageFileQueryRequest)
        {
            _logger.LogInformation("asmdlasmdlamsd");
            List<GetBookImageFileQueryResponse> response = await _mediator.Send(getBookImageFileQueryRequest);
            return Ok(response);
        }


        [HttpDelete("[action]/{Id}")]
        public async Task<IActionResult> DeleteBookImage([FromRoute] RemoveBookImageCommandRequest removeBookImageCommandRequest, [FromQuery] string imageId)
        {
            var id = removeBookImageCommandRequest.Id;
            removeBookImageCommandRequest.ImageId = imageId;
            RemoveBookImageCommandResponse response = await _mediator.Send(removeBookImageCommandRequest);
            return Ok();
        }
    }
}
