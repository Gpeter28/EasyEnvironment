using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Net;
using System.IO;

namespace OneSetSetUpEnvironment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        RichTextBox ownUrl = new RichTextBox();

        private void newTool_New_Click(object sender, EventArgs e)
        {
            MainPanel.Margin = new Padding(0, 200, 0, 0);
            var Position = MainPanel.Location;
            var Size = MainPanel.Size;
            
            var ReletiveX = Size.Width / 3 +  Position.X;
            var ReletiveY = Position.Y;
            ownUrl.Location = new Point(ReletiveX, ReletiveY);


            RichTextBox officalUrl = new RichTextBox();
            officalUrl.Location = new Point(ReletiveX, ReletiveY + 200);

            Button btn = new Button();
            btn.Location = new Point(ReletiveX, ReletiveY + 300);
            btn.Click += (object s, EventArgs eventArgs) => {
                var url = "https://code.visualstudio.com/sha/download?build=stable&os=win32-x64-user";
                Task.Run(() => DownLoadZip(url));
            };
            // https://code.visualstudio.com/sha/download?build=stable&os=win32-x64-user

            MainPanel.Controls.Add(ownUrl);
            MainPanel.Controls.Add(officalUrl);
            MainPanel.Controls.Add(btn);
        }

        public void DownLoadZip(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                long remoteFileLength = GetHttpLength(url);
                string path = @"F:\src\source code for 2019\CSharp\PersonalProgram\OneStepSetUpEnvironment\OneSetSetUpEnvironment\OneSetSetUpEnvironment\bin\Debug";

                Console.WriteLine("in");
                using (Stream readStream = request.GetResponse().GetResponseStream())
                {
                    byte[] byteArray = new byte[512];

                    int contentSize = readStream.Read(byteArray, 0, byteArray.Length);

                    long current = 0;
                    ownUrl.Text = "start";
                    Console.WriteLine("start");
                    using (FileStream writeStream = new FileStream(path, FileMode.Create))
                    {
                        while (contentSize > 0)
                        {
                            current += contentSize;
                            int percent = (int)(current * 100 / remoteFileLength);
                            Console.WriteLine(percent);
                            UpdateMessage(ownUrl.Text = percent.ToString());
                            
                            writeStream.Write(byteArray, 0, contentSize);
                            contentSize = readStream.Read(byteArray, 0, byteArray.Length);
                        }
                    }
                }
            }
            catch (Exception)
            {
                return;
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

        void UpdateMessage(string msg)
        {
            Action action = () => ownUrl.Text = msg;
            MainPanel.BeginInvoke(action);
        }



    }
}
