using LibraryManagementAPI.Application.DTOs.BorrowedBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Interfaces.Services
{
    public interface IBorrowedService
    {
        Task BorrowBookAsync(BoorowBookDTO boorowBook);
        Task<ListBorrowDTO> GetAllBorrowsAsync();
        Task<SingleBorrowDTO> GetBorrowByIdAsync(string id);
        Task<(bool, ReturnBorrowDTO)> ReturnBorrowAsync(string id);
    }
}
