﻿using Microsoft.AspNetCore.Http;
using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace CHAT___MVC
{
    public class FileManage
    {
        public string GetFileType(string extension) 
        {
            Dictionary<string, string> Filetypes = new Dictionary<string, string>()
            {
                {".txt" ,"text/plain"},
                {".pdf" ,"aplication/pdf"},
                {".doc" ,"aplication/vnd.ms-word"},
                {".docx" ,"aplication/vns.ms-word"},
                {".xls" ,"aplication/vnd.openxmlformats-officedocument.spreadsheetml.sheet"},
                {".xlsx" ,"aplication/vnd.openxmlformats-officedocument.spreadsheetml.sheet"},
                {".png" ,"image/png"},
                {".jpg" ,"image/jpeg"},
                {".jpeg" ,"image/jpeg"},
                {".gif" ,"image/gif"},
                {".csv" ,"text/csv"},
                {".rar" , "application/x-rar-compressed"},
                {".ppt", "application/vnd.ms-powerpoint"},
                {".zip", "application/zip" },
                {".exe","application/vnd.microsoft.portable-executable" },
                {".bin","application/octet-stream" }
            };
            return Filetypes[extension];
        }
        public void save(IFormFile file, String pathSave)
        {
            if (File.Exists(pathSave))
            {
                File.Delete(pathSave);
            }
            using (var nf = new FileStream(pathSave, FileMode.OpenOrCreate)) 
            {
                file.CopyTo(nf);
            }
        }
        public byte[] RetunFile(string Path)
        {
            byte[] buffer;
            using (FileStream fs = new FileStream(Path, FileMode.OpenOrCreate))
            {
                buffer = new byte[fs.Length];
                using (var br = new BinaryReader(fs))
                {
                    br.Read(buffer, 0, (int)fs.Length);
                }
            }
            return buffer;
        }

        
    }
}
