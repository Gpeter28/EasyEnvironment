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
        private static string UpdateUrl = "";
        private static string VersionUrl = "";

        public static void StartUpdate()
        {


            using(var http = new WebClient())
            {
                http.Encoding = Encoding.UTF8;
                http.DownloadFile("")
                var flag = true;
                // Different Version
                if (flag)
                {
                    System.Diagnostics.Process.Start(UpdateUrl);
                }
            }

            



        }

    }
}
