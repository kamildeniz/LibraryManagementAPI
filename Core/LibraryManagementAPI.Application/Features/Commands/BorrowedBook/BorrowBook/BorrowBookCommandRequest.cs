using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Commands.BorrowedBook.BorrowBook
{
    public class BorrowBookCommandRequest:IRequest<BorrowBookCommandResponse>
    {
        //public DateTime BorrowedDate { get; set; }
        //public DateTime DueDate { get; set; }
        //public DateTime ReturnDate { get; set; }
        public Guid MemberId { get; set; }
        public Guid BookId { get; set; }
    }
}
