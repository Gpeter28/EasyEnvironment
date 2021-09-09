﻿using System;
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
using System.Globalization;
using System.Net;
using System.IO;
using System.Reflection;
using System.Resources;
using EasyEnvironment.CustomerControls;
using EasyEnvironment.Utils;
using OneSetSetUpEnvironment.CustomerControls;

namespace EasyEnvironment
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        RichTextBox ownUrl = new RichTextBox();
        Dictionary<string,string> list = new Dictionary<string, string>();

        // In Future Use More Nomal Way to do it ?
        private List<MyList> myLists = new List<MyList>(5);
        private List<ExtractList> extractLists = new List<ExtractList>(5);

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
        public static string DirPath = AppDomain.CurrentDomain.BaseDirectory;

        public static ResourceManager rm =
            new ResourceManager("EasyEnvironment", Assembly.GetExecutingAssembly());
        public static CultureInfo info;



        void UpdateMessage(string msg)
        {
            Action action = () => ownUrl.Text = msg;
            MainPanel.BeginInvoke(action);
        }
        //private void Before()
        //{
        //    MainPanel.Margin = new Padding(0, 200, 0, 0);
        //    var Position = MainPanel.Location;
        //    var Size = MainPanel.Size;

        //    var ReletiveX = Size.Width / 3 + Position.X;
        //    var ReletiveY = Position.Y;
        //    ownUrl.Location = new Point(ReletiveX, ReletiveY);


        //    RichTextBox officalUrl = new RichTextBox();
        //    officalUrl.Location = new Point(ReletiveX, ReletiveY + 200);

        //    Button btn = new Button();
        //    btn.Location = new Point(ReletiveX, ReletiveY + 300);
        //    btn.Click += (object s, EventArgs eventArgs) => {
        //        Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
        //        var url = "https://down.qq.com/qqweb/PCQQ/PCQQ_EXE/PCQQ2021.exe";
        //        var Msg = Config.ReadConfig();



        //        var Line = Msg.Split('\n');

        //        foreach (var config in Line)
        //        {
        //            if (config != string.Empty)
        //            {
        //                var final = config.Split(' ');

        //                // Remove /r       => Probably Have more Great Method;
        //                list.Add(final[0], final[1].Substring(0, final[1].Length - 1));
        //            }
        //        }

        //        foreach (var i in list)
        //        {
        //            Console.WriteLine(i.Key + " " + i.Value);
        //        }

        //        // Task.Run(() => MainFormDownLoad(url, AppDomain.CurrentDomain.BaseDirectory + "\\PCQQ2021.exe", "PCQQ2021.exe"));             
        //    };
        //    // https://code.visualstudio.com/sha/download?build=stable&os=win32-x64-user
        //    // https://dldir1.qq.com/music/clntupate/QQMusicSetup.exe
        //    MainPanel.Controls.Add(ownUrl);
        //    MainPanel.Controls.Add(officalUrl);
        //    MainPanel.Controls.Add(btn);
        //}

        private void Load_MenuItem_Click(object sender, EventArgs e)
        {
            ClearMainPanel();


            var s = Config.ReadConfig();
            list = s;
            CreateNewTask(s);
        }

        private void New_MenuItem_Click(object sender, EventArgs e)
        {
            if (extractLists.Count > 0)
            {
                ClearMainPanel();
                extractLists.Clear();
            }
            CreateNewTask();
        }

        private void CreateNewTask()
        {
            int num = MainPanel.Controls.Count + 1;

            MyList myList = new MyList
            {
                Name = num.ToString(),
                Location = new Point(0, (num - 1) * 50),
                NumOfList = num.ToString()
            };
            MainPanel.Controls.Add(myList);
            myLists.Add(myList);
        }

        private void CreateNewTask(Dictionary<string, string> keys)
        {
            foreach (var i in keys)
            {
                int num = MainPanel.Controls.Count + 1;

                MyList myList = new MyList
                {
                    Name = num.ToString(),
                    Location = new Point(0, (num - 1) * 50),
                    NumOfList = num.ToString(),

                    MyTask = new NewTask()
                    {
                        Name = i.Key,
                        Url = i.Value
                    }
                };
                var s = i.Key.ToLower();


                if (!File.Exists($"{Config.IconPath}\\{s}.png"))
                {
                    myList.SetUpControls(Image.FromFile($"{Config.IconPath}\\empty.png"));
                }
                else
                {
                    myList.SetUpControls(Image.FromFile($"{Config.IconPath}\\{s}.png"));

                }
                myList.URL = i.Value;
                MainPanel.Controls.Add(myList);
            }
        }

        private void CreateNewExtractTask(List<string> lists)
        {
            foreach (var i in lists)
            {
                int num = MainPanel.Controls.Count + 1;
                var postFix = i.Substring(i.LastIndexOf('.'));

                ExtractList myList = new ExtractList()
                {
                    TaskName = i.Substring(0, i.Length - postFix.Length),
                    Location = new Point(0, (num - 1) * 50),
                    Num = num.ToString(),
                    Type = postFix
                };
                MainPanel.Controls.Add(myList);
                extractLists.Add(myList);
            }
        }

        public void UpdateList(Dictionary<string, string> list)
        {
            this.list = list;
            ClearMainPanel();
            CreateNewTask(list);
        }

        private void ClearMainPanel()
        {
            MainPanel.Controls.Clear();
        }

       

        private void Save_MenuItem_Click(object sender, EventArgs e)
        {
            if(list == null)
            {
                return;
            }
            SaveConfigForm saveConfigForm = new SaveConfigForm();
            saveConfigForm.SetDictionary(list);
            saveConfigForm.Show(this);

            // Config.WriteConfig(list);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // info = CultureInfo.CreateSpecificCulture("en");

#if DEBUG
            TestEnvironmentVariables();
            // TestRunExe();
            // TestRunUnZip();
#endif


            // newTask_ToolStripMenuItem.Text = lan_cn.NewTask;
            // newTask_ToolStripMenuItem.Text = rm.GetString("NewTask");
            // newTask_ToolStripMenuItem.Text = rm.GetString("NewTask", info);
        }

        private void TestEnvironmentVariables()
        {
            // EnvironmentVariables.GetEnvironmentVariables();

            var str = @"D:\git\bin\test";
            EnvironmentVariables.AddEnvironmentVariables(str);
        }

        private void TestRunExe()
        {
            string path = @"F:\src\github repository\OneStepSetEnvironment\EasyEnvironment\bin\Debug\QQ.exe";
            var flag = AutoInstall.CheckSuffix(path);
            Console.WriteLine(flag);

            AutoInstall.StartInstall(flag, path);
        }

        private void TestRunUnZip()
        {
            AutoInstall.ExtractFile(@"F:\src\github repository\OneStepSetEnvironment\EasyEnvironment\bin\Debug\VSCode.7z", @"F:\src\github repository\OneStepSetEnvironment\EasyEnvironment\bin\Debug\Test");
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Global.DataPath);
        }



        private void EnvironmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeEnvironmentForm changeEnvironmentForm = new ChangeEnvironmentForm();

            changeEnvironmentForm.ShowDialog();
        }

        private void CheckBox_SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (myLists.Count == 0)
            {
                return;
            }
            var flag = CheckBox_SelectAll.Checked;

            foreach (var m in myLists)
            {
                m.CheckBox_Select.Checked = flag;
            }
        }

        private void MenuItem_AutoInstall_Click(object sender, EventArgs e)
        {
            ClearMainPanel();
            extractLists.Clear();

            var list = Config.GetInstallList();

            CreateNewExtractTask(list);
        }

        private void MenuItem_Options_Click(object sender, EventArgs e)
        {

        }
    }
}
