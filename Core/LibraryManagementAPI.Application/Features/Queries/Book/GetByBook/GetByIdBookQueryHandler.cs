using LibraryManagementAPI.Application.Repositories;
using MediatR;

namespace LibraryManagementAPI.Application.Features.Queries.Book.GetByBook
{
    public class GetByIdBookQueryHandler : IRequestHandler<GetByIdBookQueryRequest, GetByIdBookQueryResponse>
    {

        readonly IBookReadRepository _bookReadRepository;
        public GetByIdBookQueryHandler(IBookReadRepository bookReadRepository)
        {
            _bookReadRepository = bookReadRepository;
        }

        public async Task<GetByIdBookQueryResponse> Handle(GetByIdBookQueryRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Book book = await _bookReadRepository.GetByIdAsync(request.Id, false);
            return new()
            {
                Name = book.Name,
                ISBN = book.ISBN,
                PublicationDate = book.PublicationDate,
                BorrowedStatus = book.BorrowedStatus
            };
        }
    }
}
