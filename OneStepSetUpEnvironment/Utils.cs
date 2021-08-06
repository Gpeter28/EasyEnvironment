using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyEnvironment
{
    class Logger
    {
        public static void WriteLog(string msg, params object[] obj)
        {
            using (var sr = new System.IO.StreamWriter(System.IO.Path.Combine(Config.LogPath, "logs.log"), true))
            {
                sr.WriteLine(string.Format("[{0} {1}", System.DateTime.Now.ToString(), string.Format(msg, obj)));
            }
        }
            //using (var fsWrite = new FileStream(Config.LogFileName, FileMode.Create))
            //{
            //    byte[] hByte = System.Text.Encoding.UTF8.GetBytes(msg);

            //    fsWrite.Write(hByte, 0, hByte.Length);
            //}
    }
}
