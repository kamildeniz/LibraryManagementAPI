using LibraryManagementAPI.Application.Interfaces.Storage;
using LibraryManagementAPI.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Commands.BookImageFile.UploadBookImage
{
    public class UploadBookImageCommandHanler : IRequestHandler<UploadBookImageCommandRequest, UploadBookImageCommandResponse>
    {
        readonly IStorageService _storageService;
        readonly IBookReadRepository _bookReadRepository;
        readonly IBookImageFileWriteRepository _bookImageFileWriteRepository;

        public UploadBookImageCommandHanler(IStorageService storageService, IBookReadRepository bookReadRepository, IBookImageFileWriteRepository bookImageFileWriteRepository)
        {
            _storageService = storageService;
            _bookReadRepository = bookReadRepository;
            _bookImageFileWriteRepository = bookImageFileWriteRepository;
        }

        public async Task<UploadBookImageCommandResponse> Handle(UploadBookImageCommandRequest request, CancellationToken cancellationToken)
        {
            List<(string fileName, string pathOrContainerName)> result = await _storageService.UploadAsync("photo-images", request.Files);
            Domain.Entities.Book book = await _bookReadRepository.GetByIdAsync(request.Id);
            await _bookImageFileWriteRepository.AddRangeAsync(result.Select(r => new Domain.Entities.BookImageFile
            {
                FileName = r.fileName,
                Path = r.pathOrContainerName,
                 Storage=_storageService.StorageName,
                 Books=new List<Domain.Entities.Book>() { book}
            }).ToList());
            await _bookImageFileWriteRepository.SaveAsync();
            return new();
        }
    }
}
