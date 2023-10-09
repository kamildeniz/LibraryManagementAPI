using LibraryManagementAPI.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Queries.Publisher.GetAllPublisher
{
    public class GetAllPublisherQueryHandler : IRequestHandler<GetAllPublisherQueryRequest, GetAllPublisherQueryResponse>
    {
        readonly IPublisherReadRepository _repository;

        public GetAllPublisherQueryHandler(IPublisherReadRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetAllPublisherQueryResponse> Handle(GetAllPublisherQueryRequest request, CancellationToken cancellationToken)
        {
            var publishers = _repository.GetAll(false).Select(p => new
            {
                p.Id,
                p.Adress,
                p.Name,
                p.PhoneNumber,
                p.Books,
                p.Authors
            }).ToList();
            return new()
            {
                Publishers = publishers
            };
        }
    }
}
