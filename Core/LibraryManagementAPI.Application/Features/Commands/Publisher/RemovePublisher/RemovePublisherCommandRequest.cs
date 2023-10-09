using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Commands.Publisher.RemovePublisher
{
    public class RemovePublisherCommandRequest:IRequest<RemovePublisherCommandResponse>
    {
        public string Id { get; set; }
    }
}
