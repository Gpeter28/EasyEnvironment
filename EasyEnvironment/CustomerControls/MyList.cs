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
using EasyEnvironment;
using EasyEnvironment.Utils;

namespace EasyEnvironment.CustomerControls
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
            get => label_num.Text; 
            set => label_num.Text = value;
        }

        public int ProcessValue
        {
            get => processBar_Download.Value;
            set => processBar_Download.Value = value;
        }

        public string URL
        {
            get => txtBox_DownURL.Text;
            set => txtBox_DownURL.Text = value;
        }

        //public bool IsSelected
        //{
        //    get => CheckBox_Select.Checked; 
        //    set => CheckBox_Select.Checked = !CheckBox_Select.Checked;
        //}

        public NewTask MyTask { get; set; }


        public double ConvertStringToDouble(string s)
        {
            double.TryParse(s, out var s1);
            return s1;
        }

        public double ProcessValuePercentage
        {
            get => ConvertStringToDouble(label_Download.Text);
            set => label_Download.Text = value.ToString();
        }



        public void SetUpControls(Image img)
        {
            pictureBox_Img.Image = img;
        }


        private void MyList_Load(object sender, EventArgs e)
        {
            
        }


        // https://www.youtube.com/watch?v=CbKSh4OnCN8
        // C# Tutorial - How to Download a File from internet using C# (With pause and resume)
        private void Btn_StartStop_Click(object sender, EventArgs e)
        {
            Console.WriteLine(MainForm.DirPath);
            var s = $"{MyTask.Name}.exe";
            var filePath = Global.DataPath + s;
            if(txtBox_DownURL.Text != string.Empty)
            {
                if(!File.Exists(filePath))
                {
                    Task.Run(() => this.DownLoadFile(txtBox_DownURL.Text, filePath, s));

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

                        this.Invoke(new Action(() =>
                        {
                            this.ProcessValue = 100;
                            this.ProcessValuePercentage = 100;
                            this.btn_StartStop.Text = "Start";
                        }));

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
            Console.WriteLine(Config.IconPath);
            using var dialog = new OpenFileDialog();
            dialog.InitialDirectory = Config.IconPath;
            dialog.Title = "选择图像";
            dialog.Filter = "图片文件 |*.png;*.jpg;*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var name = dialog.FileName;
                var s = name.Replace(Config.IconPath, "");
                this.pictureBox_Img.Image = Image.FromFile($"{Config.IconPath}\\{s}");
                // Image.FromFile($"{Config.IconPath}\\{s}.png")
            }
        }

    }
}
