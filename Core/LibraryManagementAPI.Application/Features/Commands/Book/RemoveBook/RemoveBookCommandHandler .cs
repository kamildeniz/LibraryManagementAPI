using LibraryManagementAPI.Application.Repositories;
using MediatR;

namespace LibraryManagementAPI.Application.Features.Commands.Book.RemoveBook
{
    public class RemoveBookCommandHandler : IRequestHandler<RemoveBookCommandRequest, RemoveBookCommandResponse>
    {
        readonly IBookWriteRepository _bookWriteRepository;

        public RemoveBookCommandHandler(IBookWriteRepository bookWriteRepository)
        {
            _bookWriteRepository = bookWriteRepository;
        }

        public async Task<RemoveBookCommandResponse> Handle(RemoveBookCommandRequest request, CancellationToken cancellationToken)
        {
            await _bookWriteRepository.RemoveAsync(request.Id);
            await _bookWriteRepository.SaveAsync();
            return new();
        }
    }
}
