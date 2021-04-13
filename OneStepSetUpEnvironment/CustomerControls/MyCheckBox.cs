using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneSetSetUpEnvironment.CustomerControls
{
    public partial class MyCheckBox : UserControl
    {
        public MyCheckBox()
        {
            InitializeComponent();


            this.cb_check.Checked = true;
        }

        public int Num
        { 
            get { return int.Parse(lbl_Num.Text); }
            set { lbl_Num.Text = value.ToString(); }
        }

        public string TaskName
        {
            get { return lbl_TaskName.Text; }
            set { lbl_TaskName.Text = value; }
        }

        public Image TaskImage
        {
            set { picBox_task.Image = value; }
        }

        public bool IsChecked
        {
            get { return cb_check.Checked; }
            set
            {
                if (cb_check.Checked == true)
                {
                    cb_check.Checked = false;
                }
                else
                {
                    cb_check.Checked = true;
                }
            }
        }
    }
}
