using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneSetSetUpEnvironment
{
    class Config
    {
        public static string ReadConfig()
        {
            string msg = "";
            using (FileStream fsRead = new FileStream(@".\config.txt", FileMode.Open))
            {
                int fLen = (int)fsRead.Length;

                byte[] hByte = new byte[fLen];

                int read = fsRead.Read(hByte, 0, hByte.Length);

                msg = System.Text.Encoding.UTF8.GetString(hByte);
            }
            return msg;
        }

        public static void WriteConfig(string config)
        {
            using(FileStream fsWrite = new FileStream(@".\config.txt", FileMode.Create))
            {
                byte[] hByte = System.Text.Encoding.UTF8.GetBytes(config);

                fsWrite.Write(hByte, 0, hByte.Length);
            }
        }
    }
}
