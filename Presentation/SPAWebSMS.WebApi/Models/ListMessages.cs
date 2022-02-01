using System.Collections.Generic;

namespace SPAWebSMS.WebApi.Models
{
    public class ListMessages
    {
        public static List<MessageViewModel> messageViewModels { get; set; } = new List<MessageViewModel>();
    }
}
