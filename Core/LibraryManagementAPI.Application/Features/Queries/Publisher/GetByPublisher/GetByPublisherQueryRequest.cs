using MediatR;

namespace LibraryManagementAPI.Application.Features.Queries.Publisher.GetByPublisher
{
    public class GetByPublisherQueryRequest:IRequest<GetByPublisherQueryResponse>
    {
        public string Id { get; set; }
    }
}