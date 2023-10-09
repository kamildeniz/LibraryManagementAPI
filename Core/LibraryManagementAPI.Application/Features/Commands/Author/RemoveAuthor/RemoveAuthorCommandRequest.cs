using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Commands.Author.RemoveAuthor
{
    public class RemoveAuthorCommandRequest:IRequest<RemoveAuthorCommandResponse>
    {
        public string Id { get; set; }
    }
}
