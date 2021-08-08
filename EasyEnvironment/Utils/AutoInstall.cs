using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneSetSetUpEnvironment.Utils
{
    static class AutoInstall
    {
        public static string CheckSuffix(string filePath)
        {
            return Path.GetExtension(filePath);
        }

        public static void CheckDirCreate(string path)
        {
            if (!Directory.Exists(path))
            {
                try
                {
                    Directory.CreateDirectory(path);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
        }

        public static void Check7Zip()
        {
            CheckDirCreate(Global.AppPath + @"\Data\Import\7zip");

            if (!File.Exists(Global.AppPath + @"\7zip\7za.exe"))
            {
                // Install
            }
        }

        public static void StartInstall(string suffix, string filePath)
        {
            if (suffix.Equals(".exe"))
            {
                StartExe(filePath);
            }

            // Handle .zip .7z .tar
        }


        public static void StartExe(string filePath)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = Path.GetFullPath(filePath);
                p.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }

    static class UnZip
    {
        //string zipfile = @"E:\Folderx\NPPES.zip";
        //string folder = @"E:\TargetFolderx";

        // ExtractFile(zipfile, folder);
        public static void ExtractFile(string source, string destination)
        {
            // If the directory doesn't exist, create it.
            if (!Directory.Exists(destination))
                Directory.CreateDirectory(destination);

            //string zPath = ConfigurationManager.AppSettings["FileExtactorEXE"];
            //  string zPath = Properties.Settings.Default.FileExtactorEXE; ;
            // F:\src\github repository\OneStepSetEnvironment\EasyEnvironment\bin\Debug\Data\Import\7zip
            string zPath = Global.AppPath + @"\Data\Import\7zip\7za.exe";

            try
            {
                ProcessStartInfo pro = new ProcessStartInfo();
                pro.WindowStyle = ProcessWindowStyle.Normal;
                pro.FileName = zPath;
                pro.Arguments = "x \"" + source + "\" -o\"" + destination + "\"";
                var str = "x \"" + source + "\" -o\"" + destination + "\"";
                Process x = Process.Start(pro);
                x.WaitForExit();
                Console.WriteLine("成功解压");
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message + " 解压失败");
            }
        }
    }
}
