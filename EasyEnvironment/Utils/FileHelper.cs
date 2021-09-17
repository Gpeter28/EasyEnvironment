using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EasyEnvironment.Utils
{

    // Idea from    AltoHttp

    public static class FileHelper
    {
        public static FileStream CheckFile(string filePath, bool append, string lastChecksum)
        {
            var exists = File.Exists(filePath);
            if (append)
            {
                if (!exists) throw new Exception("No File To Resume");

                var currentChecksum = CalculateMD5(filePath);
                if (currentChecksum != lastChecksum) throw new Exception("File Validation Failed");
                else return new FileStream(filePath, FileMode.Append, FileAccess.Write);
            }
            else
            {
                if (!exists) return new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);
                else return new FileStream(filePath, FileMode.Truncate, FileAccess.ReadWrite);
            }
        }

        public static string CalculateMD5(string fileName)
        {
            using var md5 = MD5.Create();
            using var stream = File.OpenRead(fileName);
            var hash = md5.ComputeHash(stream);
            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }
    }
}
