using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OneSetSetUpEnvironment.Utils
{
   
    class Update
    {
        private static string UpdateUrl = "static.gpeter28.com/update.ini";
        private static string VersionUrl = "static.gpeter28.com/update.ini";

        public static void StartUpdate()
        {


            using(var http = new WebClient())
            {
                http.Encoding = Encoding.UTF8;
                http.DownloadFile(VersionUrl, "update.ini");


                var flag = true;
                // Different Version
                if (flag)
                {
                    System.Diagnostics.Process.Start(UpdateUrl);
                }
            }
        }

        public static void CheckVersion()
        {
            using(var http = new WebClient())
            {
                http.Encoding = Encoding.UTF8;
                var respondString = http.DownloadString(UpdateUrl);

                Console.WriteLine(respondString);
            }
        }

    }
}
