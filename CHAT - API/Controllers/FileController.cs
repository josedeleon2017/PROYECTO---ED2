using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CHAT___API.Models;
using CHAT___API.Storage;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CHAT___API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private IWebHostEnvironment environment;
        public FileController(IWebHostEnvironment env)
        {
            environment = env;
        }

        [HttpPost("test")]
        public int EsteEsUnTest()
        {
            return 1;
        }

        [HttpPost("compress")]
        public int CompressFile(FileModel sendFile)
        {
            try
            {
                string fileName = sendFile.OriginalFileName;
                string file_path = environment.ContentRootPath + $"\\Data\\temporal\\" + fileName;
                string file_compressedpath = sendFile.AbsolutePhat;
                FileManage _file = new FileManage() { OriginalFileName = fileName, CompressedFileName = sendFile.RegisterFileName, CompressedFilePath = file_compressedpath, DateOfCompression = Convert.ToDateTime(DateTime.Now.ToShortTimeString()) };

                //Compress the file previously saved
                _file.CompressFile(file_path, fileName);

                //Write on log file the compression result
                _file.WriteCompression(_file);

                //Delete the original file 
                _file.DeleteFile(file_path);

                return 1;

            }
            catch (Exception)
            {

                return -1;
            }
        }


        [HttpPost("decompress")]
        public ActionResult DecompressFile([FromForm] IFormFile file)
        {
            try
            {
                string file_path = environment.ContentRootPath + $"\\Data\\temporal\\{file.FileName}";
                string output_file_path = environment.ContentRootPath + $"\\Data\\compressions\\{file.FileName}";

                FileManage _file = new FileManage();

                //Save the file in the server
                _file.SaveFile(file, file_path);

                //Get the original file name
                //string file_name = _file.GetOriginalName(environment.ContentRootPath, file.FileName);

                //Decompress the file previosly saved
                string file_name = _file.DecompressFile(file_path);


                //Delete the original file 
                _file.DeleteFile(file_path);

                string path = environment.ContentRootPath + $"\\Data\\decompressions\\{file_name}";
                FileStream result = new FileStream(path, FileMode.Open);
                return File(result, "text/plain", file_name);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("compressions")]
        public IEnumerable<FileManage> GetCompressions(string file)
        {
            try
            {
                string path = environment.ContentRootPath + "\\Data\\compressions_history.json";
                FileManage fm = new FileManage();
                return fm.GetAllCompressions(path);
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpPost("save")]
        public FileModel SaveFile(FileModel file)
        {
            try
            {
                var db_conection = new DBManagement();
                if (db_conection.SaveFile(file))
                {
                    var test = file.Id;
                    return file;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpPost("edit")]
        public int EditFile(FileModel file)
        {
            try
            {
                var db_conection = new DBManagement();
                if (db_conection.EditFile(file))
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

        [HttpPost("files")]
        public IEnumerable<FileModel> GetFiles(List<string> users)
        {
            try
            {
                var db_conection = new DBManagement();
                return db_conection.GetFiles(users[0], users[1]);
            }
            catch (Exception)
            {
                return null;
            }
        }
        [HttpPost("filesDownload")]
        public IEnumerable<FileModel> GetFilesForDownload(List<string> users)
        {
            try
            {
                var db_conection = new DBManagement();
                return db_conection.GetFilesForDownload(users[0], users[1]);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}

