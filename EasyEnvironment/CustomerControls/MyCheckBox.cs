using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyEnvironment.CustomerControls
{
    public partial class MyCheckBox : UserControl
    {
        public MyCheckBox()
        {
            InitializeComponent();


            this.checkBox_Select.Checked = true;
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
            set { picBox_Task.Image = value; }
        }

        public bool IsChecked
        {
            get { return checkBox_Select.Checked; }
            set
            {
                if (checkBox_Select.Checked == true)
                {
                    checkBox_Select.Checked = false;
                }
                else
                {
                    checkBox_Select.Checked = true;
                }
            }
        }
    }
}
