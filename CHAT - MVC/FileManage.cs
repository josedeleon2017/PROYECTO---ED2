using Microsoft.AspNetCore.Http;
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
