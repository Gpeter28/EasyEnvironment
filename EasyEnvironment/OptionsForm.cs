using EasyEnvironment.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OneSetSetUpEnvironment.Utils;

namespace OneSetSetUpEnvironment
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void Options_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void CheckBox_SaveSettings_CheckedChanged(object sender, EventArgs e)
        {
            Options.IsRefreshOnSave = CheckBox_SaveSettings.Checked;
        }

        private void CheckBox_AutoStart_CheckedChanged(object sender, EventArgs e)
        {
            var autoStartFlag = AutoStart.Check();

            if (autoStartFlag)
            {
                AutoStart.Remove();
                MessageBox.Show("Success Remove AutoStart");
            }
            else
            {
                AutoStart.Set();
                MessageBox.Show("Success Set AutoStart");
            }
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            CheckBox_SaveSettings.Checked = Options.IsRefreshOnSave;
            CheckBox_AutoStart.Checked = AutoStart.Check();
        }
    }
}
