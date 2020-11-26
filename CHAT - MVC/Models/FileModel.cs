using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHAT___MVC.Models
{
    public class FileModel
    {
        public Guid Id { get; set; }
        public string Key { get; set; }
        public string Transmitter { get; set; }
        public string Receiver { get; set; }
        public string AbsolutePhat { get; set; }
        public string OriginalFileName { get; set; }
        public string RegisterFileName { get; set; }
        public DateTime Date { get; set; }
        public long Size { get; set; }
        public int Status { get; set; }
    }
}
