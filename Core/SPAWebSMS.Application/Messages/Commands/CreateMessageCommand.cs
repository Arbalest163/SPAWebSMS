using MediatR;
using System;

namespace SPAWebSMS.Application.Messages.Commands
{
    public class CreateMessageCommand : IRequest<MessageVm>
    {
        public string SendersName { get; set; }
        public string RecipientsNumber { get; set; }
        public string TextMessage { get; set; }
        public DateTime SendingDate { get; set; }
    }
}
