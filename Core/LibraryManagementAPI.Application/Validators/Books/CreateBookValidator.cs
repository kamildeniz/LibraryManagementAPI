using FluentValidation;
using LibraryManagementAPI.Application.ViewModels.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Validators.Books
{
    public class CreateBookValidator : AbstractValidator<VM_Create_Book>
    {
        public CreateBookValidator()
        {
            RuleFor(b => b.Name)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen Kitap adını boş geçmeyiniz.")
                .MaximumLength(150)
                .MinimumLength(2)
                    .WithMessage("Lütfen Kitap adını 2 ile 150 karakter arasında giriniz.");
            RuleFor(b => b.AuthorId)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen yazar adını boş geçmeyiniz.");
            RuleFor(b => b.ISBN)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen ISBN numarasını boş geçmeyiniz.").Length(13).WithMessage("ISBN numarası 13 karakter olmalıdır.");
        }
    }
}
