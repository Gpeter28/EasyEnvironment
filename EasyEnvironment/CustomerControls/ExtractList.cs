using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyEnvironment;
using EasyEnvironment.Utils;

namespace OneSetSetUpEnvironment.CustomerControls
{
    public partial class ExtractList : UserControl
    {
        public ExtractList()
        {
            InitializeComponent();
        }


        public string TaskName
        {
            get => label_TaskName.Text;
            set => label_TaskName.Text = value;
        }

        public string Num
        {
            get => label_num.Text;
            set => label_num.Text = value;
        }

        public string Type
        {
            get => label_postfix.Text;
            set => label_postfix.Text = value;
        }

        public bool Selected { get; set; }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(Global.DataPath + @$"Download\{TaskName}{Type}");
            Console.WriteLine(path);
            switch(Type)
            {
                case ".msi":
                    AutoInstall.StartExe(path);
                    break;
                case ".zip":
                    var dir = path.Substring(0, path.IndexOf(Type));
                    Console.WriteLine(dir);


                    AutoInstall.ExtractFile(path, dir);
                    break;
            }
        }
    }
}
