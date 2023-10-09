using MediatR;

namespace LibraryManagementAPI.Application.Features.Commands.Publisher.UpdatePublisher
{
    public class UpdatePublisherCommandRequest:IRequest<UpdatePublisherCommandResponse>
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        public string? Adress { get; set; }
        public string? PhoneNumber { get; set; }
    }
}