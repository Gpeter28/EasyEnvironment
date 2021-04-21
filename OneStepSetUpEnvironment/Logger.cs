using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneSetSetUpEnvironment
{
    class Logger
    {
        public static void WriteLog(string msg)
        {
            using (var fsWrite = new FileStream(Config.LogFileName, FileMode.Create))
            {
                byte[] hByte = System.Text.Encoding.UTF8.GetBytes(msg);

                fsWrite.Write(hByte, 0, hByte.Length);
            }
        }
    }
}
