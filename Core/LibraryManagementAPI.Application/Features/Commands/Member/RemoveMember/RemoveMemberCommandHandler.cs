using LibraryManagementAPI.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Commands.Member.RemoveMember
{
    public class RemoveMemberCommandHandler : IRequestHandler<RemoveMemberCommandRequest, RemoveMemberCommandResponse>
    {
        readonly IMemberWriteRepository _memberWriteRepository;

        public RemoveMemberCommandHandler(IMemberWriteRepository memberWriteRepository)
        {
            _memberWriteRepository = memberWriteRepository;
        }

        public async Task<RemoveMemberCommandResponse> Handle(RemoveMemberCommandRequest request, CancellationToken cancellationToken)
        {
            await _memberWriteRepository.RemoveAsync(request.Id);
            await _memberWriteRepository.SaveAsync();
            return new();
        }
    }
}
