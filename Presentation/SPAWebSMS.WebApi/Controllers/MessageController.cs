using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SPAWebSMS.Application.Messages.Commands;
using SPAWebSMS.WebApi.Models;
using System.Threading.Tasks;

namespace SPAWebSMS.WebApi.Controllers
{
    public class MessageController : BaseController
    {
        private readonly ISenderService<MessageViewModel> _senderService;
        private readonly IMapper _mapper;

        public MessageController(ISenderService<MessageViewModel> senderService, IMapper mapper) =>
            (_senderService, _mapper) = (senderService, mapper);

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(MessageViewModel messageViewModel)
        {
            if (ModelState.IsValid)
            {
                _senderService.Send(messageViewModel);
                var command = _mapper.Map<CreateMessageCommand>(messageViewModel);
                await Mediator.Send(command);
                return View();
            }
            return View();
        }
    }
}
