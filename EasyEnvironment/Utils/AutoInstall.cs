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

            string zPath = @"F:\7-Zip\7zG.exe";

            try
            {
                Console.WriteLine("in");
                ProcessStartInfo pro = new ProcessStartInfo();
                pro.WindowStyle = ProcessWindowStyle.Normal;
                pro.FileName = zPath;
                pro.Arguments = "x \"" + source + "\" -o" + destination;
                var str = "x \"" + source + "\" -o" + destination;
                Console.WriteLine(str);
                Process x = Process.Start(pro);
                x.WaitForExit();
            }
            catch (System.Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
        }
    }
}
