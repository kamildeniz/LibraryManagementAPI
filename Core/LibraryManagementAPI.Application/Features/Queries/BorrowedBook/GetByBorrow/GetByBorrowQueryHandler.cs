using LibraryManagementAPI.Application.Interfaces.Services;
using LibraryManagementAPI.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Queries.BorrowedBook.GetByBorrow
{
    public class GetByBorrowQueryHandler : IRequestHandler<GetByBorrowQueryRequest, GetByBorrowQueryResponse>
    {
        readonly IBookBorrowedReadRepository _repository;

        public GetByBorrowQueryHandler(IBookBorrowedReadRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetByBorrowQueryResponse> Handle(GetByBorrowQueryRequest request, CancellationToken cancellationToken)
        {
         Domain.Entities.BookBorrowed bookBorrowed=  await _repository.GetByIdAsync(request.Id,false);
            return new()
            {
               BorrowedDate=bookBorrowed.BorrowedDate,
               BorrowedStatus=bookBorrowed.BorrowedStatus,
               DueDate=bookBorrowed.DueDate,
               MemberId=bookBorrowed.MemberId,
               ReturnDate=bookBorrowed.ReturnDate,
               BookId=bookBorrowed.BookId               
            };
        }
    }
}
