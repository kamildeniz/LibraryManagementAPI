﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Interfaces.Hubs
{
    public interface IBorrowedBookHubService
    {
        Task AddedBorrowedBookMessageAsync(string message);
    }
}