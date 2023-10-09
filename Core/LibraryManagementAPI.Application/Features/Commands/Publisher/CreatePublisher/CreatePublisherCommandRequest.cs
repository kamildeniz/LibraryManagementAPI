using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Commands.Publisher.CreatePublisher
{
    public class CreatePublisherCommandRequest:IRequest<CreatePublisherCommandResponse>
    {
        public string? Name { get; set; }
        public string? Adress { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
