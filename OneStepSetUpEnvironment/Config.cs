using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyEnvironment
{
    class Config
    {
        public static string FilePath = AppDomain.CurrentDomain.BaseDirectory;
        public static string IronPath = Path.Combine(FilePath, "Data", "Iron");// $"{FilePath}\\Data\\Iron";
        public static string ConfigPath = Path.Combine(FilePath, "Data", "Config");// $"{FilePath}\\Data\\Config";
        public static string LogPath = Path.Combine(FilePath, "Data", "Log");

        // ConfigFileName
        public static string ConfigFileName = Path.Combine(ConfigPath, "config.cfg");  // @"\config.txt";
        public static string ConfigFileSaveName = Path.Combine(ConfigPath, "config_save.cfg");// @".\config_save.txt";
        public static string LogFileName = Path.Combine(LogPath, "logs.log");
        // public static string ErrlogFileName = Path.Combine(LogPath, "errlogs.log");
        public static Dictionary<string, string> ReadConfig()
        {
            string msg = "";
            using (FileStream fsRead = new FileStream(ConfigFileName, FileMode.Open))
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
            if (!File.Exists(ConfigFileName))
            {
                File.Create(ConfigFileName);
            }


            using (FileStream fsWrite = new FileStream(ConfigFileSaveName, FileMode.Create))
            {
                byte[] hByte = System.Text.Encoding.UTF8.GetBytes(config);

                fsWrite.Write(hByte, 0, hByte.Length);
            }
        }

        public static void WriteConfig(Dictionary<string, string> list)
        {
            if (!File.Exists(ConfigFileName))
            {
                File.Create(ConfigFileName);
            }
            var str = DictionaryToString(list);

            using (FileStream fsWrite = new FileStream(ConfigFileSaveName, FileMode.Create))
            {
                byte[] hByte = System.Text.Encoding.UTF8.GetBytes(str);

                fsWrite.Write(hByte, 0, hByte.Length);
            }
        }

        private static string DictionaryToString(Dictionary<string, string> list)
        {
            string str = string.Empty;

            foreach(var i in list)
            {
                str += i.Key + " " + i.Value + $"\r\n";
            }

            return str;
        }
    }
}
