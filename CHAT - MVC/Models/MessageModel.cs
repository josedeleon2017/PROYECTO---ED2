using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHAT___MVC.Models
{
    public class MessageModel
    {
        public Guid Id { get; set; }
        public string Transmitter { get; set; }
        public string Receiver { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public int Type { get; set; }
    }
}
