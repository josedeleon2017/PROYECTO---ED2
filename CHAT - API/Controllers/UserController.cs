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
    public class UserController : ControllerBase
    {
        [HttpPost("add")]
        public int CreateUser(UserModel user)
        {
            try
            {
                var db_conection = new DBManagement();
                if (!db_conection.ExistUser(user.UserName))
                {
                    if (db_conection.InsertUser(user))
                    {
                        return 1;
                    }
                }
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        [HttpPost("login")]
        public int ValidateCredentials(UserModel user)
        {
            try
            {
                var db_conection = new DBManagement();
                bool access_granted = false;
                if (db_conection.ExistUser(user.UserName))
                {
                    access_granted = db_conection.ValidateCredentials(user.UserName, user.Password);
                    if (access_granted)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                return 2;
            }
            catch (Exception)
            {
                return 0;
            }
        }



        [HttpGet]
        public string Get()
        {
            return "CHAT";
        }


        [HttpPost("users")]
        public IEnumerable<string> GetUsers(UserModel user_logged)
        {
            try
            {
                var db_conection = new DBManagement();
                return db_conection.GetUsersID(user_logged.UserName);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
