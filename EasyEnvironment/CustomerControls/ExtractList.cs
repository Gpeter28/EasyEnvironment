using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
        }
    }
}
