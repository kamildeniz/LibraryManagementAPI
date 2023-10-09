using LibraryManagementAPI.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Queries.BorrowedBook.GetAllBorrow
{
    public class GetAllBorrowQueryHandler : IRequestHandler<GetAllBorrowQueryRequest, GetAllBorrowQueryResponse>
    {
        readonly IBookBorrowedReadRepository _bookBorrowedReadRepository;
        public GetAllBorrowQueryHandler(IBookBorrowedReadRepository bookBorrowedReadRepository)
        {
            _bookBorrowedReadRepository = bookBorrowedReadRepository;
        }

        public async Task<GetAllBorrowQueryResponse> Handle(GetAllBorrowQueryRequest request, CancellationToken cancellationToken)
        {
            var borrowedBooks = _bookBorrowedReadRepository.GetAll(false)
                .Select(a => new
            {
               a.BorrowedStatus,
               a.BorrowedDate,
               a.DueDate,
               a.ReturnDate,
               a.BookId,
               a.MemberId
            }).ToList();
            return new() {BorrowedBooks=borrowedBooks };
        }
    }
}
