using LibraryManagementAPI.Application.Repositories;
using LibraryManagementAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Commands.BookImageFile.UpdateBookImage
{
    public class UpdateBookImageCommandHandler : IRequestHandler<UpdateBookImageCommandRequest, UpdateBookImageCommandResponse>
    {

        readonly IBookImageFileWriteRepository _bookImageFileWriteRepository;

        public UpdateBookImageCommandHandler(IBookImageFileWriteRepository bookImageFileWriteRepository)
        {

            _bookImageFileWriteRepository = bookImageFileWriteRepository;
        }

        public async Task<UpdateBookImageCommandResponse> Handle(UpdateBookImageCommandRequest request, CancellationToken cancellationToken)
        {
            var query = _bookImageFileWriteRepository.Table
                     .Include(b => b.Books)
                     .SelectMany(b => b.Books, (bif, b) => new
                     {
                         bif,
                         b
                     });
            return new();

        }
    }
}
