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
using System.Globalization;
using System.Net;
using System.IO;
using System.Reflection;
using System.Resources;
using EasyEnvironment.CustomerControls;
using EasyEnvironment.Utils;
using OneSetSetUpEnvironment;
using OneSetSetUpEnvironment.CustomerControls;
using System.Collections;
using OneSetSetUpEnvironment.Utils;

namespace EasyEnvironment
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        RichTextBox ownUrl = new RichTextBox();
        private Dictionary<string,string> _envDictionary = new Dictionary<string, string>();
        private Dictionary<string, string> _softwareDictionary = new Dictionary<string, string>();
        private Dictionary<string, string> _selecteDictionary = new Dictionary<string, string>();

        // In Future Use More Nomal Way to do it ?
        private List<MyList> myLists = new List<MyList>(5);
        private List<ExtractList> extractLists = new List<ExtractList>(5);

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
        //                _list.Add(final[0], final[1].Substring(0, final[1].Length - 1));
        //            }
        //        }

        //        foreach (var i in _list)
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

            switch (s)
            {
                case Situation.Success:
                    _envDictionary = Config.GetEnvDictionary();
                    _softwareDictionary = Config.GetSoftwareDictionary();
                    break;
                case Situation.NoFile:
                    MessageBox.Show("Doesn't have Config.Now has Create");
                    break;
                case Situation.Empty:
                    MessageBox.Show("Config is Empty");
                    break;
            }

            ComboBox_Type.SelectedIndex = 0;
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

                myList.SetUpControls(Tools.GetImage(s));
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

        public void UpdateList(Dictionary<string, string> _list)
        {
            this._selecteDictionary = _list;
            ClearMainPanel();
            CreateNewTask(_list);
        }

        public void UpdateList(int index)
        {
            ClearMainPanel();
            Dictionary<string, string> _list = new Dictionary<string, string>();
            switch (ComboBox_Type.SelectedIndex)
            {
                case 0:
                    _list = _envDictionary;
                    break;
                case 1:
                    _list = _softwareDictionary;
                    break;
            }

            UpdateList(_list);
        }

        private void ClearMainPanel()
        {
            MainPanel.Controls.Clear();
        }

       

        private void Save_MenuItem_Click(object sender, EventArgs e)
        {
            //if(_list == null)
            //{
            //    return;
            //}
            _selecteDictionary.Clear();
            foreach (var i in MainPanel.Controls)
            {
                var myList = (MyList) i;
                var j = myList.URL.LastIndexOf('/');

                if (j == -1) continue;
                var newStr = myList.URL.Substring(j + 1);
                _selecteDictionary.Add(newStr, myList.URL);
            }
            SaveConfigForm saveConfigForm = new SaveConfigForm();
            Options.IsEnv = ComboBox_Type.SelectedIndex == 0;
            saveConfigForm.SetDictionary(_selecteDictionary);
            saveConfigForm.Show(this);

            // Config.WriteConfig(_list);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // info = CultureInfo.CreateSpecificCulture("en");

#if DEBUG
            // TestEnvironmentVariables();
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
            OptionsForm optionsForm = new OptionsForm();

            optionsForm.ShowDialog();
        }

        private void ComboBox_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateList(ComboBox_Type.SelectedIndex);
        }
    }
}
