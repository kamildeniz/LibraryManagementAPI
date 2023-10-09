using LibraryManagementAPI.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Queries.Author.GetByAuthor
{
    public class GetByAuthorQueryHandler : IRequestHandler<GetByAuthorQueryRequest, GetByAuthorQueryResponse>
    {
        readonly IAuthorReadRepository _authorReadRepository;

        public GetByAuthorQueryHandler(IAuthorReadRepository authorReadRepository)
        {
            _authorReadRepository = authorReadRepository;
        }

        public async Task<GetByAuthorQueryResponse> Handle(GetByAuthorQueryRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Author author = await _authorReadRepository.GetByIdAsync(request.Id);
            return new()
            {
                Biography = author.Biography,
                BirthDate = author.BirthDate,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Nationality = author.Nationality,
                Books = author.Books
            };
        }
    }
}
