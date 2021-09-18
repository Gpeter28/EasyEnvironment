using Avalonia.Controls.Shapes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EasyEnvironment.Utils
{
    class DownloadHelper
    {
        private Thread downloadThread;

        #region Varibles

        public string LastMD5Checksum { get; set; }
        public string Url { get; set; }

        public string FullFileName { get; set; }

        public string FileName
        {
            get => Path.GetFileName(FullFileName);
        }

        public Status State
        {
            get { return state; }
        }



        private Stopwatch stopwatch;
        private Status state;
    #endregion

        public DownloadHelper(string url, string fullPath)
        {
            this.Url = url;
            this.FullFileName = fullPath;
        }

        private void Process()
        {
            try
            {
                HttpWebRequest web = (HttpWebRequest) WebRequest.Create(Url);
                HttpWebResponse response = (HttpWebResponse) web.GetResponse();
                using Stream stream = response.GetResponseStream();
                using FileStream fs = new FileStream(path, File.Create());

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                LastMD5Checksum = FileHelper.CalculateMd5(FullFileName);
            }
        }


        public void Start()
        {

        }

        public void Pause()
        {

        }

        public void Resume()
        {

        }

        public void Resume(string fileToResume, string validationChecksum)
        {

        }


        public void DownLoadFile(string url, string path, string name)
        {
            try
            {
                HttpWebRequest web = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)web.GetResponse();
                using Stream stream = response.GetResponseStream();
                using FileStream fs = new FileStream(path, FileMode.Create);
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
                        //Action action = new Action(() =>
                        //{
                        //    this.ProcessValue = (int)(totalDownloadedByte * 100 / response.ContentLength);
                        //    this.ProcessValuePercentage = (totalDownloadedByte * 100 / response.ContentLength);
                        //});
                        //this.Invoke(action);

                        // Tracking...
                        // Console.WriteLine("[{0}%]  downloading '{1}' ({2}/{3})...", totalDownloadedByte * 100 / response.ContentLength, name, totalDownloadedByte, response.ContentLength);
                    }
                }

                //this.Invoke(new Action(() =>
                //{
                //    this.ProcessValue = 100;
                //    this.ProcessValuePercentage = 100;
                //    this.btn_StartStop.Text = "Start";
                //}));

                // Global.Print("下载 '" + name + "' 完成   (大小: " + totalDownloadedByte.ToString() + " 字节) ...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
