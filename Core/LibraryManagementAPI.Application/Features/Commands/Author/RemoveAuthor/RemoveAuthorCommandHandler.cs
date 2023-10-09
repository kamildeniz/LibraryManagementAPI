using LibraryManagementAPI.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Commands.Author.RemoveAuthor
{
    public class RemoveAuthorCommandHandler : IRequestHandler<RemoveAuthorCommandRequest, RemoveAuthorCommandResponse>
    {
        readonly IAuthorWriteRepository _authorWriteRepository;
        public RemoveAuthorCommandHandler(IAuthorWriteRepository authorWriteRepository)
        {
            _authorWriteRepository = authorWriteRepository;
        }

        public async Task<RemoveAuthorCommandResponse> Handle(RemoveAuthorCommandRequest request, CancellationToken cancellationToken)
        {
            await _authorWriteRepository.RemoveAsync(request.Id);
            await _authorWriteRepository.SaveAsync();
            return new();
        }
    }
}
