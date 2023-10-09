using LibraryManagementAPI.Application.DTOs;
using LibraryManagementAPI.Application.Repositories;
using MediatR;

namespace LibraryManagementAPI.Application.Features.Commands.Book.CreateBook
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommandRequest, CreateBookCommandResponse>
    {
        readonly IBookWriteRepository _bookWriteRepository;


        public CreateBookCommandHandler(IBookWriteRepository bookWriteRepository)
        {
            _bookWriteRepository = bookWriteRepository;

        }

        public async Task<CreateBookCommandResponse> Handle(CreateBookCommandRequest request, CancellationToken cancellationToken)
        {
            await _bookWriteRepository.AddAsync(new()
            {
                Name = request.Name,
                ISBN = request.ISBN,
                PublicationDate = request.PublicationDate,
                AuthorId = request.AuthorId,
                BorrowedStatus = false,
                PublisherId = request.PublisherId
            });
            await _bookWriteRepository.SaveAsync();
            return new();
        }

    }
}
