using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OneSetSetUpEnvironment.CustomerControls;

namespace OneSetSetUpEnvironment
{
    public partial class SaveConfigForm : Form
    {
        public SaveConfigForm()
        {
            InitializeComponent();
        }

        public void SetDictionary(Dictionary<string, string> lists)
        {
            this.list = lists;
        }


        private Dictionary<string, string> list = new Dictionary<string, string>();

        private void SaveConfigForm_Load(object sender, EventArgs e)
        {
            int index = 1;
            foreach(var i in list)
            {
                MyCheckBox myCheckBox = new MyCheckBox();

                myCheckBox.Name = index.ToString();
                myCheckBox.Location = new Point(0, (index - 1) * 50);

                myCheckBox.Num = index++;
                myCheckBox.TaskName = i.Key;
                myCheckBox.TaskImage = Image.FromFile($"./Iron/{i.Key.ToLower()}.png");
                MainPanel.Controls.Add(myCheckBox);
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            Config.WriteConfig(list);
            MessageBox.Show("Success Show");
            this.Close();
        }
    }
}
