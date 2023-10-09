using LibraryManagementAPI.Application.Interfaces.Hubs;
using LibraryManagementAPI.Application.Interfaces.Services;
using LibraryManagementAPI.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Commands.BorrowedBook.BorrowBook
{
    public class BoorrowBookCommandHandler:IRequestHandler<BorrowBookCommandRequest,BorrowBookCommandResponse>
    {
     readonly IBorrowedService _borrowedService;
        //readonly IBorrowedBookHubService _borrowedBookHubService;
        public BoorrowBookCommandHandler(IBorrowedService borrowedService)
        {
            _borrowedService = borrowedService;
       //     _borrowedBookHubService = borrowedBookHubService;
        }

        public async Task<BorrowBookCommandResponse> Handle(BorrowBookCommandRequest request, CancellationToken cancellationToken)
        {
            await _borrowedService.BorrowBookAsync(new()
            {
                MemberId=request.MemberId,
                BookId=request.BookId
            });
        //    await _borrowedBookHubService.AddedBorrowedBookMessageAsync("Kitabı Ödünç Almış Bulunmaktasınız.");
            return new();
        }
    }
}
