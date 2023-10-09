using MediatR;

namespace LibraryManagementAPI.Application.Features.Queries.BorrowedBook.GetByBorrow
{
    public class GetByBorrowQueryRequest:IRequest<GetByBorrowQueryResponse>
    {
        public string Id { get; set; }
    }
}