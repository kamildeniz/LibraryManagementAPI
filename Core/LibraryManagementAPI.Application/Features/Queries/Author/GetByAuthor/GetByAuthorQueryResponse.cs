using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Queries.Author.GetByAuthor
{
    public class GetByAuthorQueryResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Nationality { get; set; }
        public string? Biography { get; set; }
        public object Books { get; set; }
    }
}
