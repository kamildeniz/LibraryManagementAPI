using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.DTOs.BorrowedBook
{
    public class ReturnBorrowDTO
    {
        public DateTime BorrowedDate { get; set; }
        public bool BorrowedStatus { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
