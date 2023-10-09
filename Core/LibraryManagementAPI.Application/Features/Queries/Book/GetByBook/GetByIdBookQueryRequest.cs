using MediatR;

namespace LibraryManagementAPI.Application.Features.Queries.Book.GetByBook
{
    public class GetByIdBookQueryRequest : IRequest<GetByIdBookQueryResponse>
    {
        public string Id { get; set; }
    }
}
