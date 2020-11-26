using CHAT___Algorithms;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CHAT___API
{
    public class FileManage
    {
        LZW lzw = new LZW();
        public string OriginalFileName { get; set; }
        public string CompressedFileName { get; set; }
        public string CompressedFilePath { get; set; }
        public double CompressionRatio { get; set; }
        public double CompressionFactor { get; set; }
        public double ReductionPercentage { get; set; }
        public DateTime DateOfCompression { get; set; }

        public List<FileManage> GetAllCompressions(string path)
        {
            List<FileManage> list = new List<FileManage>();
            using (StreamReader sr = new StreamReader(path))
            {
                string result = sr.ReadToEnd();

                JsonSerializerOptions name_rule = new JsonSerializerOptions { IgnoreNullValues = true };
                list = JsonSerializer.Deserialize<List<FileManage>>(result, name_rule);
            }
            return list;
        }

        public void CreateDirectoriesForData(string path)
        {
            var file_path = path + "\\Data";
            if (!Directory.Exists(file_path))
            {
                DirectoryInfo Data = Directory.CreateDirectory(file_path);
            }
            if (!Directory.Exists(file_path + "\\decompressions"))
            {
                DirectoryInfo Entrada = Directory.CreateDirectory(file_path + "\\decompressions");
            }
            if (!Directory.Exists(file_path + "\\compressions"))
            {
                DirectoryInfo Salida = Directory.CreateDirectory(file_path + "\\compressions");
            }
            if (!Directory.Exists(file_path + "\\temporal"))
            {
                DirectoryInfo Salida = Directory.CreateDirectory(file_path + "\\temporal");
            }
        }

        public void SaveFile(IFormFile file, string output_path)
        {
            if (File.Exists(output_path))
            {
                File.Delete(output_path);
            }
            using (var fs = new FileStream(output_path, FileMode.OpenOrCreate))
            {
                file.CopyTo(fs);
            }
            return;
        }


        public void DeleteFile(string path)
        {
            File.Delete(path);
        }

        public void CompressFile(string path, string originalName)
        {
            LZW lZW = new LZW();
            byte[] buffer;
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                buffer = new byte[fs.Length];
                using (var br = new BinaryReader(fs))
                {
                    br.Read(buffer, 0, (int)fs.Length);
                }
            }

            byte[] result = lzw.EncodeData(buffer);

            for (int i = 1; File.Exists(CompressedFilePath); i++)
            {
                var split = CompressedFileName.Split(".lzw");
                if (split[0].Contains("("))
                {
                    var split2 = split[0].Split("(");
                    CompressedFileName = split2[0] + "(" + i + ")" + ".lzw";
                }
                else
                    CompressedFileName = split[0] + "(" + i + ")" + ".lzw";

                split = CompressedFilePath.Split("compressions");
                CompressedFilePath = split[0] + "compressions\\" + CompressedFileName;
            }
            byte[] nombre = Encoding.ASCII.GetBytes(originalName.PadRight(200, '\0').ToArray());
            using (var fs = new FileStream(CompressedFilePath, FileMode.OpenOrCreate))
            {
                fs.Write(nombre, 0, 200);
                fs.Seek(200, SeekOrigin.Begin);
                fs.Write(result, 0, result.Length);
            }
            CompressionRatio = lzw.CompressionRatio();
            CompressionFactor = lzw.CompressionFactor();
            ReductionPercentage = lzw.ReductionPercentage();
        }

        public string DecompressFile(string path)
        {
            LZW lzw = new LZW();
            List<byte> temp = new List<byte>();
            byte[] buffer;
            byte[] getoriginalName = new byte[200];
            string file_name;

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {

                buffer = new byte[fs.Length];
                using (var br = new BinaryReader(fs))
                {
                    br.Read(buffer, 0, buffer.Length);
                }
            }
            temp = buffer.ToList();
            for (int i = 0; i < getoriginalName.Length; i++)
            {
                getoriginalName[i] = temp[0];
                temp.RemoveAt(0);
            }
            buffer = temp.ToArray();
            var split = Encoding.ASCII.GetString(getoriginalName).Split(".");
            file_name = split[0] + ".txt";
            byte[] result = lzw.DecodeData(buffer);
            string[] path_result = path.Split("Data");
            string file_path = path_result[0] + $"\\Data\\decompressions\\{file_name}";
            using (var fs = new FileStream(file_path, FileMode.OpenOrCreate))
            {
                fs.Write(result, 0, result.Length);
            }

            return file_name;
        }

        public void WriteCompression(FileManage file)
        {
            string[] path = CompressedFilePath.Split("Data");
            string file_path = path[0] + "\\Data\\compressions_history.json";

            List<FileManage> list;
            string json_text = "";
            using (FileStream fs = new FileStream(file_path, FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    json_text = sr.ReadToEnd();
                }
            }
            if (json_text == "")
            {
                using (StreamWriter sw = new StreamWriter(file_path, false, Encoding.UTF8))
                {
                    string file_stats = JsonSerializer.Serialize(file);
                    sw.Write("[" + file_stats + "]");
                    return;
                }
            }
            else
            {
                JsonSerializerOptions name_rule = new JsonSerializerOptions { IgnoreNullValues = true };
                list = JsonSerializer.Deserialize<List<FileManage>>(json_text, name_rule);
                list.Add(file);
            }
            using (StreamWriter sw = new StreamWriter(file_path, false, Encoding.UTF8))
            {
                string file_stats = JsonSerializer.Serialize(list);
                sw.Write(file_stats);
            }
        }
    }
}
