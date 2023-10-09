using LibraryManagementAPI.API.Controllers;
using LibraryManagementAPI.Application.Features.Commands.AppUser.CreateUser;
using LibraryManagementAPI.Application.Interfaces.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using RestSharp;

namespace ETicaretAPI.API.Controllers
{
    
    public class UsersController : BaseController
    {
        readonly IMailService _mailService;
        public UsersController(IMediator mediator, ILogger<BookController> logger, IMailService mailService) : base(mediator, logger)
        {
            _mailService = mailService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommandRequest createUserCommandRequest)
        {
            CreateUserCommandResponse response = await _mediator.Send(createUserCommandRequest);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> ExampleMailTest()
        {
            await _mailService.SendMessageAsync("kamil07deniz@gmail.com", "Örnek Mail", "<strong>Bu bir örnek maildir.</strong>");
            return Ok();
        }
        
     
    }
}