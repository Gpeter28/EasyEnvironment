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
    }
}
