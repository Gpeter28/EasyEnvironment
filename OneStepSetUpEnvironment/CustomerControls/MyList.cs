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
    public partial class MyList : UserControl
    {
        public MyList()
        {
            InitializeComponent();
        }

        public string NumOfList
        {
            get { return label_num.Text; }
            set { label_num.Text = value; }
        }

        public MyList(Image img, string Text_FileName, int Percentage, int num)
        {
            pictureBox_Img.Image = img;
            label_FileName.Text = Text_FileName;
            label_Download.Text = Percentage.ToString();
            label_num.Text = num.ToString();
        }

        public void SetUpControls(Image img, string Text_FileName, int Percentage, int num)
        {
            pictureBox_Img.Image = img;
            label_FileName.Text = Text_FileName;
            label_Download.Text = Percentage.ToString();
            label_num.Text = num.ToString();
        }

        public void UpdateControls(int Percentage)
        {
            Action action = new Action(() => processBar_Download.Value = Percentage);
            processBar_Download.Invoke(action);
        }

        private void MyList_Load(object sender, EventArgs e)
        {

        }

        private void btn_StartStop_Click(object sender, EventArgs e)
        {
            _ = (btn_StartStop.Text == "Start") ? btn_StartStop.Text = "Stop" : btn_StartStop.Text = "Start";
        }
    }
}
