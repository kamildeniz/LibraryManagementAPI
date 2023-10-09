using LibraryManagementAPI.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Queries.Member.GetByMember
{
    public class GetByMemberQueryHandler : IRequestHandler<GetByMemberQueryRequest, GetByMemberQueryResponse>
    {
        readonly IMemberReadRepository _repository;

        public GetByMemberQueryHandler(IMemberReadRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetByMemberQueryResponse> Handle(GetByMemberQueryRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Member member = await _repository.GetByIdAsync(request.Id);
            return new()
            {
                FirstName = member.FirstName,
                LastName = member.LastName,
                Email = member.Email,
                PhoneNumber = member.PhoneNumber,
                BookLimit = member.BookLimit,
                BooksBorrowed = member.BooksBorrowed
            };
        }
    }
}
