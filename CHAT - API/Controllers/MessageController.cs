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
        [HttpPost("{save}")]
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
    }
}
