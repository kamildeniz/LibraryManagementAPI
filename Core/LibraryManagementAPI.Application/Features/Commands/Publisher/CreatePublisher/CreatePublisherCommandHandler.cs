using LibraryManagementAPI.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Commands.Publisher.CreatePublisher
{
    public class CreatePublisherCommandHandler : IRequestHandler<CreatePublisherCommandRequest, CreatePublisherCommandResponse>
    {
        readonly IPublisherWriteRepository _publisherWriteRepository;

        public CreatePublisherCommandHandler(IPublisherWriteRepository publisherWriteRepository)
        {
            _publisherWriteRepository = publisherWriteRepository;
        }

        public async Task<CreatePublisherCommandResponse> Handle(CreatePublisherCommandRequest request, CancellationToken cancellationToken)
        {
            await _publisherWriteRepository.AddAsync(new()
            {
                Name=request.Name,
                Adress=request.Adress,
                PhoneNumber=request.PhoneNumber
            });
            await _publisherWriteRepository.SaveAsync();
            return new();
        }
    }
}
