using LibraryManagementAPI.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Queries.Member.GetAllMember
{
    public class GetAllMemberQueryHandler : IRequestHandler<GetAllMemberQueryRequest, GetAllMemberQueryResponse>
    {
        readonly IMemberReadRepository _repository;
        public async Task<GetAllMemberQueryResponse> Handle(GetAllMemberQueryRequest request, CancellationToken cancellationToken)
        {
            var members = _repository.GetAll(false)
                .Select(m => new
                {
                 m.FirstName,
                 m.LastName,
                 m.PhoneNumber,
                 m.Email,
                 m.BookLimit,
                 m.BooksBorrowed
                });
            return new()
            {
                Members=members
            };
        }
    }
}
