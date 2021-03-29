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

using OneSetSetUpEnvironment.CustomerControls;

namespace OneSetSetUpEnvironment
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        RichTextBox ownUrl = new RichTextBox();
        Dictionary<string,string> list = new Dictionary<string, string>();

        //public void MainFormDownLoad(string url, string path, string name)
        //{
        //    try
        //    {
        //        HttpWebRequest web = (HttpWebRequest)WebRequest.Create(url);
        //        HttpWebResponse response = (HttpWebResponse)web.GetResponse();
        //        using (Stream stream = response.GetResponseStream())
        //        {
        //            using (FileStream fs = new FileStream(path, FileMode.Create))
        //            {
        //                long totalDownloadedByte = 0;

        //                byte[] bytes = new byte[2048];
        //                int osize = stream.Read(bytes, 0, bytes.Length);

        //                while (osize > 0)
        //                {
        //                    totalDownloadedByte = osize + totalDownloadedByte;
        //                    fs.Write(bytes, 0, osize);
        //                    osize = stream.Read(bytes, 0, bytes.Length);

        //                    if (totalDownloadedByte < response.ContentLength)
        //                    {
        //                        UpdateProcessBar(totalDownloadedByte * 100 / response.ContentLength);
        //                        // Tracking...
        //                        // Console.WriteLine("[{0}%]  downloading '{1}' ({2}/{3})...", totalDownloadedByte * 100 / response.ContentLength, name, totalDownloadedByte, response.ContentLength);
        //                    }


        //                }
        //                // Download Success
        //                UpdateProcessBar(0);


        //                // Global.Print("下载 '" + name + "' 完成   (大小: " + totalDownloadedByte.ToString() + " 字节) ...");
        //            }
        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("error");
        //    }
        //}

        //public void UpdateProcessBar(long num)
        //{

        //}


        private void newTool_New_Click(object sender, EventArgs e)
        {
            int num = MainPanel.Controls.Count + 1;

            
            MyList myList = new MyList();
            myList.Name = num.ToString();
            myList.Location = new Point(0, (num - 1)* 50);
            myList.NumOfList = num.ToString();

            Console.WriteLine(MainPanel.Location.X + " " + MainPanel.Location.Y);
            Console.WriteLine(myList.Location.X +  " " + myList.Location.Y);
            Console.WriteLine(myList.NumOfList);
            MainPanel.Controls.Add(myList);

        }

        private void Before()
        {
            MainPanel.Margin = new Padding(0, 200, 0, 0);
            var Position = MainPanel.Location;
            var Size = MainPanel.Size;

            var ReletiveX = Size.Width / 3 + Position.X;
            var ReletiveY = Position.Y;
            ownUrl.Location = new Point(ReletiveX, ReletiveY);


            RichTextBox officalUrl = new RichTextBox();
            officalUrl.Location = new Point(ReletiveX, ReletiveY + 200);

            Button btn = new Button();
            btn.Location = new Point(ReletiveX, ReletiveY + 300);
            btn.Click += (object s, EventArgs eventArgs) => {
                Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
                var url = "https://down.qq.com/qqweb/PCQQ/PCQQ_EXE/PCQQ2021.exe";
                var Msg = Config.ReadConfig();



                var Line = Msg.Split('\n');

                foreach (var config in Line)
                {
                    if (config != string.Empty)
                    {
                        var final = config.Split(' ');

                        // Remove /r       => Probably Have more Great Method;
                        list.Add(final[0], final[1].Substring(0, final[1].Length - 1));
                    }
                }

                foreach (var i in list)
                {
                    Console.WriteLine(i.Key + " " + i.Value);
                }

                // Task.Run(() => MainFormDownLoad(url, AppDomain.CurrentDomain.BaseDirectory + "\\PCQQ2021.exe", "PCQQ2021.exe"));             
            };
            // https://code.visualstudio.com/sha/download?build=stable&os=win32-x64-user

            MainPanel.Controls.Add(ownUrl);
            MainPanel.Controls.Add(officalUrl);
            MainPanel.Controls.Add(btn);
        }

        void UpdateMessage(string msg)
        {
            Action action = () => ownUrl.Text = msg;
            MainPanel.BeginInvoke(action);
        }



    }
}
