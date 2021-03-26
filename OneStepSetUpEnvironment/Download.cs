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
        public static bool DownLoadZip(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                long remoteFileLength = GetHttpLength(url);
                string path = "./";

                using(Stream readStream = request.GetResponse().GetResponseStream())
                {
                    byte[] byteArray = new byte[512];

                    int contentSize = readStream.Read(byteArray, 0, byteArray.Length);

                    long current = 0;
                    using (FileStream writeStream = new FileStream(path, FileMode.Create))
                    {
                        while (contentSize > 0)
                        {
                            current += contentSize;
                            int percent = (int)(current * 100 / remoteFileLength);

                            System.Windows.Forms.MessageBox.Show(percent.ToString());
                            writeStream.Write(byteArray, 0, contentSize);
                            contentSize = readStream.Read(byteArray, 0, byteArray.Length);
                        }
                    }
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        private static long GetHttpLength(string url)
        {
            long length = 0;

            try
            {
                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(url);// 打开网络连接
                HttpWebResponse rsp = (HttpWebResponse)req.GetResponse();

                if (rsp.StatusCode == HttpStatusCode.OK)
                {
                    length = rsp.ContentLength;// 从文件头得到远程文件的长度
                }

                rsp.Close();
                return length;
            }
            catch (Exception e)
            {
                return length;
            }

        }
    }
}
