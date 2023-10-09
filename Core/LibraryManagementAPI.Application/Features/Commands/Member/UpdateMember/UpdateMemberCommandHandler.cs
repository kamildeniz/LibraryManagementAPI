using LibraryManagementAPI.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Commands.Member.UpdateMember
{
    public class UpdateMemberCommandHandler : IRequestHandler<UpdateMemberCommandRequest, UpdateMemberCommandResponse>
    {
        readonly IMemberWriteRepository _memberWriteRepository;
        readonly IMemberReadRepository _memberReadRepository;
        public UpdateMemberCommandHandler(IMemberWriteRepository memberWriteRepository, IMemberReadRepository memberReadRepository)
        {
            _memberWriteRepository = memberWriteRepository;
            _memberReadRepository = memberReadRepository;
        }
        public async Task<UpdateMemberCommandResponse> Handle(UpdateMemberCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Member member = await _memberReadRepository.GetByIdAsync(request.Id);
            member.FirstName = request.FirstName;
            member.LastName = request.LastName;
            member.PhoneNumber = request.PhoneNumber;
            member.Email = request.Email;
            member.BooksBorrowed = request.BooksBorrowed;
            await _memberWriteRepository.SaveAsync();
            return new();
        }
    }
}
