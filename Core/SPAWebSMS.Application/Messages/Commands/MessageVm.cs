using AutoMapper;
using SPAWebSMS.Application.Common.Mappings;
using SPAWebSMS.Domain;
using System;

namespace SPAWebSMS.Application.Messages.Commands
{
    public class MessageVm : IMapWith<Message>
    {
        public string SendersName { get; set; }
        public string RecipientsNumber { get; set; }
        public string TextMessage { get; set; }
        public DateTime SendingDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Message, MessageVm>();
        }
    }
}
