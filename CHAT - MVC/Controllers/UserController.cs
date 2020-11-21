using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using CHAT___MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CHAT___MVC.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.User = HttpContext.Session.GetString("UserName");
            if (HttpContext.Session.GetString("UserName") == "") return RedirectToAction("Index", "Home");
            List<string> list = new List<string>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44389/api/");
                var responseTask = client.PostAsJsonAsync("user/users", new UserModel() { UserName = HttpContext.Session.GetString("UserName") });
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var read = result.Content.ReadAsStringAsync();
                    read.Wait();
                    JsonSerializerOptions name_rule = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase, IgnoreNullValues = true };
                    list = JsonSerializer.Deserialize<List<string>>(read.Result, name_rule);
                }
            }
            return View(list);
        }

        public ActionResult Login(IFormCollection collection)
        {
            if (collection.Count != 0)
            {
                string user = collection["User"];
                string password = collection["Password"];
                if(user == "" || password == "")
                {
                    ViewBag.Result = "DEBE LLENAR TODOS LOS CAMPOS";
                    return View();
                }
                UserModel user_logged = new UserModel() { UserName = user.ToUpper(), Password = password };
                int is_validated;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44389/api/");
                    var responseTask = client.PostAsJsonAsync("user/login", user_logged);
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var read = result.Content.ReadAsStringAsync();
                        read.Wait();
                        is_validated = JsonSerializer.Deserialize<int>(read.Result);
                        if (is_validated == 1)
                        {
                            HttpContext.Session.SetString("UserName", user_logged.UserName);
                            return RedirectToAction("Index", "User");
                        }
                        if (is_validated == 0)
                        {
                            ViewBag.Result = "CONTRASEÑA INCORRECTA";
                            return View();
                        }
                        if (is_validated == 2)
                        {
                            ViewBag.Result = "EL USUARIO "+user_logged.UserName.ToUpper()+" NO EXISTE";
                            return View();
                        }
                    }
                    else
                    {
                        ViewBag.Result = "NO SE PUDO PROCESAR LA SOLICITUD";
                        return View();
                    }
                }

            }
            return View();
        }


        public ActionResult Register(IFormCollection collection)
        {
            if (collection.Count != 0)
            {
                string user = collection["User"];
                string password = collection["Password"];
                string confirm_password = collection["ConfirmPassword"];
                if(user == "" || password == "" || confirm_password == "")
                {
                    ViewBag.Result = "DEBE LLENAR TODOS LOS CAMPOS";
                    return View();
                }
                if (password != confirm_password)
                {
                    ViewBag.Result = "LA CONTRASEÑA NO COINCIDE EN AMBOS CAMPOS";
                    return View();
                }
                else
                {
                    UserModel user_logged = new UserModel() { UserName = user.ToUpper(), Password = password };
                    int is_validated;
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("https://localhost:44389/api/");
                        var responseTask = client.PostAsJsonAsync("user/add", user_logged);
                        responseTask.Wait();

                        var result = responseTask.Result;
                        if (result.IsSuccessStatusCode)
                        {
                            var read = result.Content.ReadAsStringAsync();
                            read.Wait();
                            is_validated = JsonSerializer.Deserialize<int>(read.Result);
                            if (is_validated == 1)
                            {
                                HttpContext.Session.SetString("UserName", user_logged.UserName);
                                return RedirectToAction("Index");
                            }
                            if (is_validated == 0)
                            {
                                ViewBag.Result = "EL USUARIO YA EXISTE";
                                return View();
                            }
                        }
                    }
                }
            }
            return View();
        }

        public ActionResult QueryChat(string user)
        {
            List<string> users = new List<string> { HttpContext.Session.GetString("UserName"), user };
            List<MessageModel> conversation = new List<MessageModel>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44389/api/");
                var responseTask = client.PostAsJsonAsync("message/conversation", users);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var read = result.Content.ReadAsStringAsync();
                    read.Wait();
                    JsonSerializerOptions name_rule = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase, IgnoreNullValues = true };
                    conversation = JsonSerializer.Deserialize<List<MessageModel>>(read.Result, name_rule);
                    if (conversation.Count()!=0)
                    {
                        ViewBag.Logged = HttpContext.Session.GetString("UserName");
                        return View(conversation);
                    }
                    else
                    {
                        ViewBag.Result = "NO SE ENCONTRARON MESANJES";
                    }
                }
            }

            return View();
        }
        public ActionResult SendMessage()
        {
            return View();
        }
    }
}
