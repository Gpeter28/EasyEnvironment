using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;
using System.IO;

namespace OneSetSetUpEnvironment
{
    class Download
    {
        public static void DownLoadFile(string url, string path, string name)
        {
            Console.WriteLine("StartIn");
            try
            {
                HttpWebRequest web = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)web.GetResponse();
                Console.WriteLine("start");
                using (Stream stream = response.GetResponseStream())
                {
                    Console.WriteLine("inStream");
                    using (FileStream fs = new FileStream(path, FileMode.Create))
                    {
                        Console.WriteLine("Downloading");
                        long totalDownloadedByte = 0;
                        byte[] bytes = new byte[2048];
                        int osize = stream.Read(bytes, 0, bytes.Length);

                        while (osize > 0)
                        {
                            totalDownloadedByte = osize + totalDownloadedByte;
                            fs.Write(bytes, 0, osize);
                            osize = stream.Read(bytes, 0, bytes.Length);

                            if (totalDownloadedByte < response.ContentLength)
                            {
                                // Tracking...
                                Console.WriteLine("[{0}%]  downloading '{1}' ({2}/{3})...", totalDownloadedByte * 100 / response.ContentLength, name, totalDownloadedByte, response.ContentLength);
                            }
                        }
                        // Global.Print("下载 '" + name + "' 完成   (大小: " + totalDownloadedByte.ToString() + " 字节) ...");
                    }
                }

            }catch(Exception e)
            {
                Console.WriteLine("error");
            }
        }


    }
}
