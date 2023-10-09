using LibraryManagementAPI.Application.Interfaces.Services;
using LibraryManagementAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Commands.BorrowedBook.ReturnBook
{
    public class ReturnBookCommandHandler : IRequestHandler<ReturnBookCommandRequest, ReturnBookCommandResponse>
    {
        readonly IBorrowedService _borrowedService;

        public ReturnBookCommandHandler(IBorrowedService borrowedService)
        {
            _borrowedService = borrowedService;
        }

        public async Task<ReturnBookCommandResponse> Handle(ReturnBookCommandRequest request, CancellationToken cancellationToken)
        {
            _borrowedService.ReturnBorrowAsync(request.Id);

            return new();

        }
    }
}
