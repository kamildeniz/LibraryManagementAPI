using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Queries.Author.GetByAuthor
{
    public class GetByAuthorQueryRequest:IRequest<GetByAuthorQueryResponse>
    {
       public string Id { get; set; }
    }
}
