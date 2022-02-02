using SPAWebSMS.Domain.EntityBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPAWebSMS.Domain
{
    public class Message : Entity
    {
        public string SendersName { get; set; }
        public string RecipientsNumber { get; set; }
        public string TextMessage { get; set; }
        public DateTime SendingDate { get; set; }
    }
}
