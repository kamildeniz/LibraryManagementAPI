using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Queries.BookImageFile.GetBookImageFile
{
    public class GetBookImageFileQueryResponse
    {
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }
    }
}
