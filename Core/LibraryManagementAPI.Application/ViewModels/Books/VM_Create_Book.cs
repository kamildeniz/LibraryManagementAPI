using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.ViewModels.Books
{
    public class VM_Create_Book
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public string ISBN { get; set; }
        public bool BorrowedStatus { get; set; }
        public DateTime PublicationDate { get; set; }
        public Guid PublisherId { get; set; }
        public Guid AuthorId { get; set; }
    }
}
