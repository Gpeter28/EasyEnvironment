using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyEnvironment.CustomerControls;
using OneSetSetUpEnvironment.Utils;

namespace EasyEnvironment
{
    public partial class SaveConfigForm : Form
    {
        public SaveConfigForm()
        {
            InitializeComponent();
        }

        public void SetDictionary(Dictionary<string, string> envList, Dictionary<string, string> sList)
        {
            this.envList = envList;
            this.softwareList = sList;
        }


        private Dictionary<string, string> envList = new Dictionary<string, string>();
        private Dictionary<string, string> softwareList = new Dictionary<string, string>();

        private void SaveConfigForm_Load(object sender, EventArgs e)
        {
            int index = 1;
            foreach(var i in envList)
            {
                MyCheckBox myCheckBox = new MyCheckBox();

                myCheckBox.Name = index.ToString();
                myCheckBox.Location = new Point(0, (index - 1) * 50);

                myCheckBox.Num = index++;
                myCheckBox.TaskName = i.Key;
                myCheckBox.TaskImage = Tools.GetImage(i.Key.ToLower());
                // myCheckBox.TaskImage = Image.FromFile($"{Config.IconPath}/{i.Key.ToLower()}.png");
                EnvPanel.Controls.Add(myCheckBox);
            }

            index = 1;
            foreach (var i in softwareList)
            {
                MyCheckBox myCheckBox = new MyCheckBox();

                myCheckBox.Name = index.ToString();
                myCheckBox.Location = new Point(0, (index - 1) * 50);

                myCheckBox.Num = index++;
                myCheckBox.TaskName = i.Key;
                myCheckBox.TaskImage = Tools.GetImage(i.Key.ToLower());
                // myCheckBox.TaskImage = Image.FromFile($"{Config.IconPath}/{i.Key.ToLower()}.png");
                SoftwarePanel.Controls.Add(myCheckBox);
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            foreach(var control in EnvPanel.Controls)
            {
                var checkbox = (MyCheckBox)control;
                if (!checkbox.IsChecked)
                {
                    envList.Remove(checkbox.TaskName);
                }
            }

            foreach (var control in SoftwarePanel.Controls)
            {
                var checkbox = (MyCheckBox)control;
                if (!checkbox.IsChecked)
                {
                    softwareList.Remove(checkbox.TaskName);
                }
            }
            Config.WriteConfig(envList, softwareList);
            MessageBox.Show("Success Show");

            this.Close();

            //MainForm mf = (MainForm)this.Owner;
            //mf.UpdateList(list);
            //this.Close();
        }

        private void SaveConfigForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Options.IsRefreshOnSave)
            {
                MainForm mf = (MainForm)this.Owner;
                mf.UpdateList(envList);
            }


        }
    }
}
