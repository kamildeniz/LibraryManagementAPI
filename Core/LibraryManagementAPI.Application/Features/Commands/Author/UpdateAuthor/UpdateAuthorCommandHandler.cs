using LibraryManagementAPI.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Commands.Author.UpdateAuthor
{
    public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommandRequest, UpdateAuthorCommandResponse>
    {
        readonly IAuthorWriteRepository _authorWriteRepository;
        readonly IAuthorReadRepository _authorReadRepository;

        public UpdateAuthorCommandHandler(IAuthorWriteRepository authorWriteRepository, IAuthorReadRepository authorReadRepository)
        {
            _authorWriteRepository = authorWriteRepository;
            _authorReadRepository = authorReadRepository;
        }

        public async Task<UpdateAuthorCommandResponse> Handle(UpdateAuthorCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Author author = await _authorReadRepository.GetByIdAsync(request.Id);
            author.BirthDate = request.BirthDate;
            author.Biography = request.Biography;
            author.FirstName = request.FirstName;
            author.LastName = request.LastName;
            author.Nationality = request.Nationality;
            await _authorWriteRepository.SaveAsync();
            return new();

        }
    }
}
