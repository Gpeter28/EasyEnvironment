using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using OneSetSetUpEnvironment;

namespace OneSetSetUpEnvironment.CustomerControls
{
    public partial class MyList : UserControl
    {
        public MyList()
        {
            InitializeComponent();
        }

        //zzzzz

        public string NumOfList
        {
            get { return label_num.Text; }
            set { label_num.Text = value; }
        }

        public int ProcessValue
        {
            get { return processBar_Download.Value; }
            set { processBar_Download.Value = value; }
        }

        public string URL
        {
            get { return txtBox_DownURL.Text; }
            set { txtBox_DownURL.Text = value; }
        }

        public NewTask MyTask { get; set; }


        public double ConvertStringToDouble(string s)
        {
            double.TryParse(s, out var s1);
            return s1;
        }

        public double ProcessValuePercentage
        {
            get { return ConvertStringToDouble(label_Download.Text); }
            set { label_Download.Text = value.ToString(); }
        }



        public void SetUpControls(Image img)
        {
            pictureBox_Img.Image = img;
        }


        private void MyList_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn_StartStop_Click(object sender, EventArgs e)
        {
            Console.WriteLine(MainForm.DirPath);
            var s = $"{MyTask.Name}.exe";
            if(txtBox_DownURL.Text != string.Empty)
            {
                if(!File.Exists(MainForm.DirPath + s))
                {
                    Task.Run(() => this.DownLoadFile(txtBox_DownURL.Text, MainForm.DirPath + s, s));

                    _ = (btn_StartStop.Text == "Start") ? btn_StartStop.Text = "Stop" : btn_StartStop.Text = "Start";
                }
                else
                {
                    MessageBox.Show("Already Install");
                }               
            }
            else
            {

            }         
        }

        public void DownLoadFile(string url, string path, string name)
        {
            try
            {
                HttpWebRequest web = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)web.GetResponse();
                using (Stream stream = response.GetResponseStream())
                {
                    using (FileStream fs = new FileStream(path, FileMode.Create))
                    {
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
                                Action action = new Action(() =>
                                {
                                    this.ProcessValue = (int)(totalDownloadedByte * 100 / response.ContentLength);
                                    this.ProcessValuePercentage = (totalDownloadedByte * 100/ response.ContentLength);
                                } );
                                this.Invoke(action);

                                // Tracking...
                                // Console.WriteLine("[{0}%]  downloading '{1}' ({2}/{3})...", totalDownloadedByte * 100 / response.ContentLength, name, totalDownloadedByte, response.ContentLength);
                            }
                        }


                        Action action2 = new Action(() =>
                        {
                            this.ProcessValue = 100;
                            this.ProcessValuePercentage = 100;
                            this.btn_StartStop.Text = "Start";
                        });

                        this.Invoke(action2);
                        // Global.Print("下载 '" + name + "' 完成   (大小: " + totalDownloadedByte.ToString() + " 字节) ...");
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void PictureBox_Img_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Config.FilePath);
            using (var dialog = new OpenFileDialog())
            {
                dialog.InitialDirectory = Config.IronPath;
                dialog.Title = "选择图像";
                dialog.Filter = "图片文件 |*.png;*.jpg;*.bmp";

                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    var name = dialog.FileName;
                    var s = name.Replace(Config.FilePath, "");
                    this.pictureBox_Img.Image = Image.FromFile($"{Config.FilePath}\\{s}");
                    // Image.FromFile($"{Config.IronPath}\\{s}.png")
                }
            }
        }
    }
}
