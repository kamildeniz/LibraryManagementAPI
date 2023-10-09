using MediatR;

namespace LibraryManagementAPI.Application.Features.Queries.BorrowedBook.GetAllBorrow
{
    public class GetAllBorrowQueryRequest:IRequest<GetAllBorrowQueryResponse>
    {
    }
}