using AutoMapper;
using MediatR;
using SPAWebSMS.Application.Interfaces;
using SPAWebSMS.Application.Messages.Commands;
using SPAWebSMS.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SPAWebSMS.WebApi.Services
{
    public class FakeMessageSenderService : ISenderService<MessageViewModel>
    {
        private static Timer _timer;

        static FakeMessageSenderService()
        {
            _timer = new(UpdateStatus, null, 0, 5000);
        }

        public void Send(MessageViewModel request)
        {
            var rnd = new Random();

            request.SendingDate = DateTime.Now;
            request.StatusMessage = rnd.Next(0, 2) switch
            {
                0 => StatusMessage.Sent,
                _ => StatusMessage.SendingError
            };

            ListMessages.messageViewModels.Add(request);
        }

        private static void UpdateStatus(object tmp)
        {
            foreach (var message in ListMessages.messageViewModels)
            {
                if (message.StatusMessage == StatusMessage.Sent)
                {
                    message.StatusMessage = StatusMessage.Delivered;
                }
            }
        }

    }
}
