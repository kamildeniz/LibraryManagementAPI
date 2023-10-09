using AutoMapper;
using LibraryManagementAPI.Application.DTOs;
using LibraryManagementAPI.Application.ViewModels.Books;
using LibraryManagementAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Commands.Book.Books
{
    public class BookMapper:Profile
    {
        public BookMapper()
        {
            CreateMap<Domain.Entities.Book, VM_Create_Book>();
        }
    }
}
