using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Commands.Author.UpdateAuthor
{
    public class UpdateAuthorCommandRequest:IRequest<UpdateAuthorCommandResponse>
    {
        public string Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Nationality { get; set; }
        public string? Biography { get; set; }
    }
}
