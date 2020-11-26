using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using CHAT___MVC.Models;
using CHAT___MVC.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.Text;

namespace CHAT___MVC.Controllers
{
    public class UserController : Controller
    {
        private IWebHostEnvironment environment;
        public UserController(IWebHostEnvironment env)
        {
            environment = env;
        }
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
                            Storage.Instance.UserLoged = user_logged.UserName;
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
        public ActionResult QueryChat(string user, IFormCollection collection)
        {
            Storage.Instance.Receiver = user;
            if (collection.Count != 0)
            {
                MessageModel message = new MessageModel();
                string content = collection["Message"];
                if (content != "")
                {
                    message.Content = content;
                    message.Transmitter = HttpContext.Session.GetString("UserName");
                    message.Receiver = user;
                    message.Date = DateTime.Now;
                    message.Type = 1;
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("https://localhost:44389/api/");
                        var responseTask = client.PostAsJsonAsync("message/save", message);
                        responseTask.Wait();

                        var result = responseTask.Result;
                        if (result.IsSuccessStatusCode)
                        {
                            var read = result.Content.ReadAsStringAsync();
                            read.Wait();                          
                            int result_converted = JsonSerializer.Deserialize<int>(read.Result);
                            if (result_converted != 0)
                            {
                                ViewBag.Result = "MENSAJE GUARDADO EXITOSAMENTE";
                            }
                            else
                            {
                                ViewBag.Result = "NO SE PUDO GUARDAR EL MENSAJE";
                            }
                        }
                    }
                }
                //if(Se ADJUNTO UN ARCHIVO)
                else
                {
                    ViewBag.Result = "NO SE PERMITEN MENSAJES VACÍOS";
                    return View(new List<MessageModel>());
                }


            }

            List<string> users = new List<string> { HttpContext.Session.GetString("UserName"), user };
            List<MessageModel> conversation = new List<MessageModel>();
            List<FileModel> filesWait = new List<FileModel>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44389/api/");
                var responseTask = client.PostAsJsonAsync("message/conversation", users);
                responseTask.Wait();

                var responseTaskFile = client.PostAsJsonAsync("file/files", users);
                responseTaskFile.Wait();

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
                        ViewBag.Second = user;
                        var resultFiles = responseTaskFile.Result;
                        if (resultFiles.IsSuccessStatusCode)
                        {
                            var readfiles = resultFiles.Content.ReadAsStringAsync();
                            readfiles.Wait();
                            filesWait = JsonSerializer.Deserialize<List<FileModel>>(readfiles.Result, name_rule);
                            if (filesWait.Count() != 0)
                            {
                                ViewBag.Logged = HttpContext.Session.GetString("UserName");
                                ViewBag.Second = user;
                                ViewBag.Result = "TIENE NUEVOS ARCHIVOS PARA DESCARGAR";
                            }
                        }
                        return View(conversation);
                    }
                    else
                    {
                        ViewBag.Logged = HttpContext.Session.GetString("UserName");
                        ViewBag.Second = user;
                        ViewBag.Result = "NO SE ENCONTRARON MENSAJES";
                    }
                }
               
            }
            return View(new List<MessageModel>());
        }
        public ActionResult SearchMessage( IFormCollection collection)
        {
            if(collection.Count != 0)
            {
                List<MessageModel> result_list;
                List<string> values = new List<string>() { collection["Word"], HttpContext.Session.GetString("UserName") };
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44389/api/");
                    var responseTask = client.PostAsJsonAsync("message/search", values);
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var read = result.Content.ReadAsStringAsync();
                        read.Wait();
                        JsonSerializerOptions name_rule = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase, IgnoreNullValues = true };
                        result_list = JsonSerializer.Deserialize<List<MessageModel>>(read.Result, name_rule);
                        if (result_list.Count != 0)
                        {
                            return View(result_list);
                        }
                        else
                        {
                            //VIEWBAG NO SE ECONTRARON RESULTADOS
                        }
                    }
                }
            }
            return View(new List<MessageModel>());
        }
        public ActionResult DownloadFiles(string user, FileModel model)
        {
            List<string> users = new List<string> { HttpContext.Session.GetString("UserName"), user };
            List<FileModel> filesWait = new List<FileModel>();
            ViewBag.Logged = users[0];
            ViewBag.Second = users[1];
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44389/api/");
                var responseTaskFile = client.PostAsJsonAsync("file/filesDownload", users);
                responseTaskFile.Wait();
                var resultFiles = responseTaskFile.Result;
                if (resultFiles.IsSuccessStatusCode)
                {
                    var readfiles = resultFiles.Content.ReadAsStringAsync();
                    readfiles.Wait();
                    JsonSerializerOptions name_rule = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase, IgnoreNullValues = true };
                    filesWait = JsonSerializer.Deserialize<List<FileModel>>(readfiles.Result, name_rule);
                    if (filesWait.Count() != 0)
                    {
                        return View(filesWait);
                    }
                }

            }
            return View();
        }
        [HttpPost]
        public ActionResult Upload(IFormFile file, IFormCollection collection)
        {
            string user = collection["user"];
            var save = environment.ContentRootPath.Split("PROYECTO---ED2")[0] + "\\PROYECTO---ED2" + "\\CHAT - API" + "\\Data" + "\\temporal\\" + file.FileName;
            FileManage fileManage = new FileManage();
            FileModel sendFile = new FileModel()
            {
                Date = System.DateTime.Now,
                OriginalFileName = file.FileName,
                Receiver = Storage.Instance.Receiver,
                Transmitter = Storage.Instance.UserLoged,
                Status = 0
            };
            long size = file.Length;
            fileManage.save(file, save);
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("https://localhost:44389/api/");
                var responseTask = client.PostAsJsonAsync("file/save/", sendFile);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var read = result.Content.ReadAsStringAsync();
                    read.Wait();
                    JsonSerializerOptions name_rule = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase, IgnoreNullValues = true };
                    FileModel result_converted = JsonSerializer.Deserialize<FileModel>(read.Result, name_rule);
                    if (result_converted != null)
                    {
                        sendFile.Id = result_converted.Id;
                        sendFile.Size = size;
                        sendFile.RegisterFileName = sendFile.Id + sendFile.OriginalFileName.Split(".")[0] + ".lzw";
                        sendFile.AbsolutePhat = environment.ContentRootPath.Split("PROYECTO---ED2")[0] + "PROYECTO---ED2" + "\\CHAT - API" + "\\Data" + "\\compressions\\" + sendFile.RegisterFileName;
                        responseTask = client.PostAsJsonAsync("file/edit", sendFile);
                        responseTask.Wait();
                        responseTask = client.PostAsJsonAsync("file/compress/", sendFile);
                        responseTask.Wait();
                    }

                }
            }
            MessageModel message = new MessageModel();
            string content = sendFile.OriginalFileName;
            if (content != "")
            {
                message.Content = content;
                message.Transmitter = HttpContext.Session.GetString("UserName");
                message.Receiver = user;
                message.Date = DateTime.Now;
                message.Type = 2;
                message.Path = sendFile.AbsolutePhat;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44389/api/");
                    var responseTask = client.PostAsJsonAsync("message/save", message);
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var read = result.Content.ReadAsStringAsync();
                        read.Wait();
                        int result_converted = JsonSerializer.Deserialize<int>(read.Result);
                        if (result_converted != 0)
                        {
                            ViewBag.Result = "MENSAJE GUARDADO EXITOSAMENTE";
                        }
                        else
                        {
                            ViewBag.Result = "NO SE PUDO GUARDAR EL MENSAJE";
                        }
                    }
                }
            }
            return RedirectToAction("QueryChat", "user", new { user = user });
        }
        [HttpPost]
        public ActionResult Download(string user, IFormCollection llaves)
        {
            string[] ruta = llaves["Path"].ToString().Split("\\");
            FileManage fileManage = new FileManage();
            string paht = environment.ContentRootPath.Split("CHAT - MVC")[0] + "CHAT - API\\Data\\compressions" + ruta[10];


            return File(fileManage.RetunFile(paht), "text/plain", "test.txt");
            //File(result, "text/plain", file_name);
            //FileStream result = new FileStream(path, FileMode.Open);
            //return RedirectToAction("QueryChat", "user", new { user = user });
        }
    }
}
