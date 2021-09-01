using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        //static string RelativePath(this string value)
        //{
        //    return value.Replace(worker, "").Replace('\\', '/').Substring(1);
        //}
    }
}
