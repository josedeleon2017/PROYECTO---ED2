using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CHAT___API.Models;
using CHAT___API.Storage;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CHAT___API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        [HttpPost("save")]
        public int SaveMessage(MessageModel message)
        {
            try
            {
                var db_conection = new DBManagement();
                if (db_conection.SaveMessage(message))
                {
                    return 1;
                }
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        [HttpPost("conversation")]
        public IEnumerable<MessageModel> GetMessages(List<string> users)
        {
            try
            {
                var db_conection = new DBManagement();
                return db_conection.GetMessages(users[0], users[1]);
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpPost("search")]
        public IEnumerable<MessageModel> SearchWord(List<string> values)
        {
            try
            {
                var db_conection = new DBManagement();
                return db_conection.SearchMessages(values);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
