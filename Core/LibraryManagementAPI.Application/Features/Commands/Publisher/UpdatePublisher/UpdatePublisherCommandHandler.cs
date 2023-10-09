using LibraryManagementAPI.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Application.Features.Commands.Publisher.UpdatePublisher
{
    public class UpdatePublisherCommandHandler : IRequestHandler<UpdatePublisherCommandRequest, UpdatePublisherCommandResponse>
    {
        readonly IPublisherReadRepository _publisherReadRepository;
        readonly IPublisherWriteRepository _publisherWriteRepository;

        public UpdatePublisherCommandHandler(IPublisherReadRepository publisherReadRepository, IPublisherWriteRepository publisherWriteRepository)
        {
            _publisherReadRepository = publisherReadRepository;
            _publisherWriteRepository = publisherWriteRepository;
        }

        public async Task<UpdatePublisherCommandResponse> Handle(UpdatePublisherCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Publisher publisher = await _publisherReadRepository.GetByIdAsync(request.Id);
            publisher.PhoneNumber = request.PhoneNumber;
            publisher.Name = request.Name;
            publisher.Adress = request.Adress;
            await _publisherWriteRepository.SaveAsync();
            return new();
        }
    }
}
