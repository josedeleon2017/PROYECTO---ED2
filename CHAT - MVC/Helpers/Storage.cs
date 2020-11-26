using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CHAT___MVC.Models;

namespace CHAT___MVC.Helpers
{
    public class Storage
    {
        private static Storage _instance = null;

        public static Storage Instance
        {
            get
            {
                if (_instance == null) _instance = new Storage();
                return _instance;
            }
        }
        public string Receiver { get; set; }
        public string UserLoged { get; set; }
    }
}
