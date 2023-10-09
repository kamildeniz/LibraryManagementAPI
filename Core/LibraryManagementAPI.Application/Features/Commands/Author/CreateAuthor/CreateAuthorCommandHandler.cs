using LibraryManagementAPI.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Commands.Author.CreateAuthor
{
    public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommandRequest, CreateAuthorCommandResponse>
    {
        readonly IAuthorWriteRepository _authorWriteRepository;

        public CreateAuthorCommandHandler(IAuthorWriteRepository authorWriteRepository)
        {
            _authorWriteRepository = authorWriteRepository;
        }

        public async Task<CreateAuthorCommandResponse> Handle(CreateAuthorCommandRequest request, CancellationToken cancellationToken)
        {
            await _authorWriteRepository.AddAsync(new()
            {
                Biography = request.Biography,
                BirthDate=request.BirthDate,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Nationality=request.Nationality
            });
            await _authorWriteRepository.SaveAsync();
            return new();

        }
    }
}
