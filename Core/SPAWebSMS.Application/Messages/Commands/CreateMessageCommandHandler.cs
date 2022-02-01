using AutoMapper;
using MediatR;
using SPAWebSMS.Application.Interfaces;
using SPAWebSMS.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace SPAWebSMS.Application.Messages.Commands
{
    public class CreateMessageCommandHandler
        : IRequestHandler<CreateMessageCommand, MessageVm>
    {
        private readonly ISPAWebSMSDbContext _dbContext;
        private readonly IMapper _mapper;

        public CreateMessageCommandHandler(ISPAWebSMSDbContext dbContext, IMapper mapper) =>
            (_dbContext, _mapper) = (dbContext, mapper);

        public async Task<MessageVm> Handle(CreateMessageCommand request, CancellationToken cancellationToken)
        {
            var message = new Message
            {
                SendersName = request.SendersName,
                RecipientsNumber = request.RecipientsNumber,
                TextMessage = request.TextMessage,
                SendingDate = request.SendingDate
            };

            await _dbContext.Messages.AddAsync(message, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return _mapper.Map<MessageVm>(message);
        }
    }
}
