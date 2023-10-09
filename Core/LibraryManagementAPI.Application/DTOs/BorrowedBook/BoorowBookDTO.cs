using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.DTOs.BorrowedBook
{
    public class BoorowBookDTO
    {
        public Guid MemberId { get; set; }
        public Guid BookId { get; set; }
    }
}
