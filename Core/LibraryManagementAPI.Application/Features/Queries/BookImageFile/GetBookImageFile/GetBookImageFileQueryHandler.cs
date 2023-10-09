using LibraryManagementAPI.Application.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Queries.BookImageFile.GetBookImageFile
{
    public class GetBookImageFileQueryHandler : IRequestHandler<GetBookImageFileQueryRequest, List<GetBookImageFileQueryResponse>>
    {
        readonly IBookReadRepository _bookReadRepository;
        readonly IConfiguration configuration;
        public GetBookImageFileQueryHandler(IBookReadRepository bookReadRepository, IConfiguration configuration)
        {
            _bookReadRepository = bookReadRepository;
            this.configuration = configuration;
        }

        public async Task<List<GetBookImageFileQueryResponse>> Handle(GetBookImageFileQueryRequest request, CancellationToken cancellationToken)
        {
            Guid g = Guid.Parse(request.Id);

            Domain.Entities.Book? book = await _bookReadRepository.Table.Include(b => b.BookImageFiles)
                   .FirstOrDefaultAsync(b => b.Id == g);
            return book?.BookImageFiles.Select(b => new GetBookImageFileQueryResponse
            {
                Path = $"{configuration["BaseStorageUrl"]}/{b.Path}",
                FileName = b.FileName,
                Id = b.Id
            }).ToList();
        }
    }
}
