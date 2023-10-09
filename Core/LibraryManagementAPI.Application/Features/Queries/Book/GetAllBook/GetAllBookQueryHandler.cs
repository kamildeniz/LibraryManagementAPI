using LibraryManagementAPI.Application.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;

namespace LibraryManagementAPI.Application.Features.Queries.Book.GetAllBook
{
    public class GetAllBookQueryHandler : IRequestHandler<GetAllBookQueryRequest, GetAllBookQueryResponse>
    {
        readonly IBookReadRepository _bookReadRepository;
        readonly ILogger<GetAllBookQueryHandler> _logger;
        public GetAllBookQueryHandler(IBookReadRepository bookReadRepository, ILogger<GetAllBookQueryHandler> logger)
        {
            _bookReadRepository = bookReadRepository;
            _logger = logger;
        }
        public async Task<GetAllBookQueryResponse> Handle(GetAllBookQueryRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Get all books");

            var totalBookCount = _bookReadRepository.GetAll(false).Count();

            var books = _bookReadRepository.GetAll(false)
                .Select(b => new
                {
                    b.Id,
                    b.Name,
                    b.AuthorId,
                    b.BorrowedStatus,
                    b.CreatedDate,
                    b.ISBN,
                    b.PublicationDate,
                    b.PublisherId
                }).ToList();

            return new()
            {
                Books = books,
                TotalBookCount = totalBookCount
            };
        }
    }
}