using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Commands.Member.RemoveMember
{
    public class RemoveMemberCommandRequest:IRequest<RemoveMemberCommandResponse>
    {
        public string Id { get; set; }
    }
}
