using LibraryManagementAPI.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Queries.Publisher.GetByPublisher
{
    public class GetByPublisherQueryHandler : IRequestHandler<GetByPublisherQueryRequest, GetByPublisherQueryResponse>
    {
        readonly IPublisherReadRepository _repository;

        public GetByPublisherQueryHandler(IPublisherReadRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetByPublisherQueryResponse> Handle(GetByPublisherQueryRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Publisher publisher = await _repository.GetByIdAsync(request.Id);
            return new()
            {
                Adress = publisher.Adress,
                Name = publisher.Name,
                PhoneNumber = publisher.PhoneNumber,
            };
        }
    }
}
