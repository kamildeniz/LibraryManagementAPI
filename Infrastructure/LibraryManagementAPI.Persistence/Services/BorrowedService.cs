using LibraryManagementAPI.Application.DTOs.BorrowedBook;
using LibraryManagementAPI.Application.Interfaces.Services;
using LibraryManagementAPI.Application.Repositories;
using LibraryManagementAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Persistence.Services
{
    public class BorrowedService : IBorrowedService
    {
        readonly IBookBorrowedWriteRepository _bookBorrowedWriteRepository;
        readonly IBookBorrowedReadRepository _bookBorrowedReadRepository;

        public BorrowedService(IBookBorrowedWriteRepository bookBorrowedWriteRepository, IBookBorrowedReadRepository bookBorrowedReadRepository)
        {
            _bookBorrowedWriteRepository = bookBorrowedWriteRepository;
            _bookBorrowedReadRepository = bookBorrowedReadRepository;
        }

        public async Task BorrowBookAsync(BoorowBookDTO borrowBook)
        {
            await _bookBorrowedWriteRepository.AddAsync(new()
            {
                BookId = borrowBook.BookId,
                BorrowedDate = DateTime.UtcNow,
                BorrowedStatus=true,
                CreatedDate= DateTime.UtcNow,
                DueDate=DateTime.UtcNow.AddDays(15),
                Id=borrowBook.BookId,
                MemberId=borrowBook.MemberId

            });
        }

        public Task<ListBorrowDTO> GetAllBorrowsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<SingleBorrowDTO> GetBorrowByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

            public async Task<(bool, ReturnBorrowDTO)> ReturnBorrowAsync(string id)
            {

            BookBorrowed bookBorrowed = _bookBorrowedReadRepository.Table.FirstOrDefault(data => data.Id == Guid.Parse(id));

            if (bookBorrowed != null)
            {
                // Kitap iade işlemi için bir şeyler yapılabilir, örneğin tutulan bilgileri güncelleme veya kaydı işaretleme.
                await _bookBorrowedWriteRepository.ReturnBookAsync(bookBorrowed);

                // İşlem başarılı ise bir sonuç dönebilirsiniz.
                ReturnBorrowDTO result = new ReturnBorrowDTO
                {
                    // Sonuç bilgileri burada ayarlanabilir.
                    // Örneğin, iade tarihini, tutulan kitap bilgilerini vb. dönebilirsiniz.
                };

                return (true, result);
            }
            else
            {
                // Belirtilen ödünç alınmış kitap bulunamazsa, bir hata durumu dönebilirsiniz.
                // Örneğin, kitap mevcut değilse veya geçersiz bir kimlikle istendiğinde.
                return (false, null);
            }
        }
    }
}
