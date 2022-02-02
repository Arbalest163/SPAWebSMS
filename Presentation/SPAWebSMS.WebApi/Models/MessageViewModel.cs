using AutoMapper;
using SPAWebSMS.Application.Common.Mappings;
using SPAWebSMS.Application.Messages.Commands;
using System;
using System.ComponentModel.DataAnnotations;

namespace SPAWebSMS.WebApi.Models
{
    public class MessageViewModel : IMapWith<CreateMessageCommand>
    {
        public string SendersName { get; set; }
        [Required(ErrorMessage ="Введите номер получателя")]
        [RegularExpression(@"^\+[1-9]\d{3}-\d{3}-\d{4}$", ErrorMessage = "Номер телефона должен иметь формат +xxxx-xxx-xxxx")]
        public string RecipientsNumber { get; set; }
        [Required(ErrorMessage ="Введите текст сообщения")]
        public string TextMessage { get; set; }
        public DateTime SendingDate { get; set; }
        public StatusMessage StatusMessage { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<MessageViewModel, CreateMessageCommand>();
        }
    }
}
