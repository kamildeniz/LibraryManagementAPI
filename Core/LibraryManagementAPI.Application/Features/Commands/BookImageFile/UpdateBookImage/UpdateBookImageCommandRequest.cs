using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Commands.BookImageFile.UpdateBookImage
{
    public class UpdateBookImageCommandRequest:IRequest<UpdateBookImageCommandResponse>
    {
        public string ImageId { get; set; }
        public string? BookId { get; set; }
    }
}
