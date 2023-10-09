using LibraryManagementAPI.Application.Features.Commands.Publisher.CreatePublisher;
using LibraryManagementAPI.Application.Features.Queries.Publisher.GetAllPublisher;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementAPI.API.Controllers
{

    public class PublisherController : BaseController
    {
        public PublisherController(IMediator mediator, ILogger<BookController> logger) : base(mediator, logger)
        {
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllPublisherQueryRequest request)
        {
            GetAllPublisherQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreatePublisherCommandRequest request)
        {
            CreatePublisherCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
