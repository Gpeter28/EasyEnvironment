﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyEnvironment.Utils;

namespace EasyEnvironment
{
    class Logger
    {
        public static void WriteLog(string msg, params object[] obj)
        {
            using var sr = new StreamWriter(Config.LogFileName, true);
            sr.WriteLine("[{0} {1}", System.DateTime.Now, string.Format(msg, obj));
        }
    }

    class Config
    {
        public static string ConfigFileName = Path.Combine(Global.DataPath, "Config", "config.txt");
        public static string ConfigFileSaveName = Path.Combine(Global.DataPath, "Config", "config_save.txt");
        public static string LogFileName = Path.Combine(Global.DataPath, "Log", "logs.log");
        public static string EnvironmentFileName = Path.Combine(Global.DataPath, "Environment", "environment.txt");
        public static string DownloadFileName = Path.Combine(Global.DataPath, "Download");
        public static string IconPath = Path.Combine(Global.DataPath, "Icon");

        public static Dictionary<string, string> ReadConfig()
        {
            if (!File.Exists(ConfigFileName))
            {
                File.Create(ConfigFileName);
            }

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

                if (i.StartsWith("--"))
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

            // https://stackoverflow.com/questions/4963667/filestream-vs-differences-streamwriter
            using var sr = new StreamWriter(ConfigFileSaveName, true);
            sr.WriteLine(config);


            //using (FileStream fsWrite = new FileStream(ConfigFileSaveName, FileMode.Create))
            //{
            //byte[] hByte = System.Text.Encoding.UTF8.GetBytes(config);
            // 
            // //fsWrite.Write(hByte, 0, hByte.Length);
            //}
        }

        public static List<string> GetInstallList()
        {
            var lists = new List<string>();



            var filePaths = Directory.EnumerateFiles(Path.Combine(Global.DataPath, "Download"), "*.*")
                .Where(s => s.EndsWith(".zip") || s.EndsWith(".msi")).ToList();

            if (filePaths.Count == 0) return null;

            foreach (var file in filePaths)
            {
                lists.Add(Path.GetFileName(file));
            }
            return lists;
        }



        public static void WriteConfig(Dictionary<string, string> list)
        {
 
            var str = DictionaryToString(list);

            using var sr = new StreamWriter(ConfigFileSaveName, false);
            sr.WriteLine(str);
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
