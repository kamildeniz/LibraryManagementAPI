using LibraryManagementAPI.Application.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;

namespace LibraryManagementAPI.Application.Features.Commands.Book.UpdateBook
{
    public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommandRequest, UpdateBookCommandResponse>
    {
        readonly IBookReadRepository _bookReadRepository;
        readonly IBookWriteRepository _bookWriteRepository;
        readonly ILogger<UpdateBookCommandHandler> _logger;

        public UpdateBookCommandHandler(IBookReadRepository bookReadRepository, IBookWriteRepository bookWriteRepository, ILogger<UpdateBookCommandHandler> logger)
        {
            _bookReadRepository = bookReadRepository;
            _bookWriteRepository = bookWriteRepository;
            _logger = logger;
        }

        public async Task<UpdateBookCommandResponse> Handle(UpdateBookCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Book book = await _bookReadRepository.GetByIdAsync(request.Id);
            book.ISBN = request.ISBN;
            book.Name = request.Name;
            book.PublicationDate = request.PublicationDate;
            await _bookWriteRepository.SaveAsync();
            _logger.LogInformation("book güncellendi...");
            return new();
        }
    }
}
