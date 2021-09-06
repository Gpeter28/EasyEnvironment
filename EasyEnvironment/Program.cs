using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyEnvironment.Utils;

namespace EasyEnvironment
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        ///
        ///
        ///
        // static readonly string worker = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        [STAThread]
        static void Main()
        {
           // Now this Branch is used for newUI

            CreateFolders();
            



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        internal static void CreateFolders()
        {
            // base folder
            Directory.CreateDirectory(Global.DataPath);

            // child
            foreach (var dir in new string[] { "Config", "Download", "Environment", "Import", "Icon", "Log" })
            {
                Directory.CreateDirectory(Path.Combine(Global.DataPath, dir));
            }
        }

        //static string RelativePath(this string value)
        //{
        //    return value.Replace(worker, "").Replace('\\', '/').Substring(1);
        //}
    }
}
