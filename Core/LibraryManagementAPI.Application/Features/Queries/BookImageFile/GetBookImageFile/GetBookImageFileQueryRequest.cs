using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Queries.BookImageFile.GetBookImageFile
{
    public class GetBookImageFileQueryRequest: IRequest <List<GetBookImageFileQueryResponse>>
    {
        public string Id { get; set; }
    }
}
