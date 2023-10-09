using LibraryManagementAPI.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Commands.Publisher.RemovePublisher
{
    public class RemovePublisherCommandHandler : IRequestHandler<RemovePublisherCommandRequest, RemovePublisherCommandResponse>
    {
        readonly IPublisherWriteRepository _publisherWriteRepository;

        public RemovePublisherCommandHandler(IPublisherWriteRepository publisherWriteRepository)
        {
            _publisherWriteRepository = publisherWriteRepository;
        }

        public async Task<RemovePublisherCommandResponse> Handle(RemovePublisherCommandRequest request, CancellationToken cancellationToken)
        {
            await _publisherWriteRepository.RemoveAsync(request.Id);
            await _publisherWriteRepository.SaveAsync();
            return new();
        }
    }
}
