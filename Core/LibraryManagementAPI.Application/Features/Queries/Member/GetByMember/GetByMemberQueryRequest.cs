using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Queries.Member.GetByMember
{
    public class GetByMemberQueryRequest:IRequest<GetByMemberQueryResponse>
    {
        public string Id { get; set; }
    }
}
