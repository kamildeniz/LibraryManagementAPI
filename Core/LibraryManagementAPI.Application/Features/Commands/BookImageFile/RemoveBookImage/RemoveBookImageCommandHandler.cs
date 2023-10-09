using LibraryManagementAPI.Application.Repositories;
using LibraryManagementAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Commands.BookImageFile.RemoveBookImage
{
    public class RemoveBookImageCommandHandler : IRequestHandler<RemoveBookImageCommandRequest, RemoveBookImageCommandResponse>
    {
        readonly IBookReadRepository _bookReadRepository;
        readonly IBookWriteRepository _bookWriteRepository;

        public RemoveBookImageCommandHandler(IBookReadRepository bookReadRepository, IBookWriteRepository bookWriteRepository)
        {
            _bookReadRepository = bookReadRepository;
            _bookWriteRepository = bookWriteRepository;
        }

        public async Task<RemoveBookImageCommandResponse> Handle(RemoveBookImageCommandRequest request, CancellationToken cancellationToken)
        {
            var id = request.Id;
            Domain.Entities.Book? book = await _bookReadRepository.Table.Include(b => b.BookImageFiles)
                .FirstOrDefaultAsync(b => b.Id == Guid.Parse(request.Id));

            Domain.Entities.BookImageFile? bookImageFile = book?.BookImageFiles.FirstOrDefault(b => b.Id == Guid.Parse(request.ImageId));

            if (bookImageFile != null)
                book?.BookImageFiles.Remove(bookImageFile);

            await _bookWriteRepository.SaveAsync();
            return new();

        }
    }
}
