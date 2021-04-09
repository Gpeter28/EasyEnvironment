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
        public static Dictionary<string, string> ReadConfig()
        {
            string msg = "";
            using (FileStream fsRead = new FileStream(@".\config.txt", FileMode.Open))
            {
                int fLen = (int)fsRead.Length;

                byte[] hByte = new byte[fLen];

                int read = fsRead.Read(hByte, 0, hByte.Length);

                msg = System.Text.Encoding.UTF8.GetString(hByte);
            }

            var pairs = new Dictionary<string, string>();
            var mm = msg.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var i in mm)
            {
                if (i.StartsWith(@"//"))
                {
                    continue;
                }

                var key = i.Split(' ');
                pairs.Add(key[0], key[1]);
            }
            return pairs;
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
