using LibraryManagementAPI.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Queries.Author.GetAllAuthor
{
    public class GetAllAuthorQueryHandler : IRequestHandler<GetAllAuthorQueryRequest, GetAllAuthorQueryResponse>
    {
        readonly IAuthorReadRepository _repository;

        public GetAllAuthorQueryHandler(IAuthorReadRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetAllAuthorQueryResponse> Handle(GetAllAuthorQueryRequest request, CancellationToken cancellationToken)
        {

            var authors = _repository.GetAll(false)
                .Select(a => new
                {
                    a.Id,
                    a.FirstName,
                    a.LastName,
                    a.BirthDate,
                    a.Biography,
                    a.Books,
                    a.Nationality
                }).ToList();
            return new() { Authors = authors };
        }
    }
}
