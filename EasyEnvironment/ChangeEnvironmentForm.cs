using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyEnvironment.Utils;

namespace EasyEnvironment
{
    public partial class ChangeEnvironmentForm : Form
    {
        public ChangeEnvironmentForm()
        {
            InitializeComponent();



            UnsetEditBtn();
        }

        public void Init()
        {
            var lists = new List<EnvironmentVar>();
            
            // EnvironmentListView
        }

        private List<string> envirList = new List<string>();
        private string preStr;

        private void ChangeEnvironmentForm_Load(object sender, EventArgs e)
        {
            var flag = Environment.GetEnvironmentVariable("test", EnvironmentVariableTarget.User);
            Console.WriteLine(flag);

            if (flag != null)
            {
                preStr = flag;
                var str = Environment.GetEnvironmentVariable("test", EnvironmentVariableTarget.User).Split(';');

                foreach (var i in str)
                {
                    if (!string.IsNullOrWhiteSpace(i))
                    {
                        envirList.Add(i);
                        Console.WriteLine(i);
                        EnvironmentListView.Items.Add(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Don't have this Environment variables");
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            var str = TxtValue.Text.Trim();

            // Console.WriteLine(pathName);

            EnvironmentListView.Items.Add(str);
            envirList.Add(str);
            TxtValue.Clear();
            TxtValue.Focus();
        }


        private void UnsetEditBtn()
        {
            BtnConfirm.Enabled = false;
            BtnRollBack.Enabled = false;
            TxtValue.Text = string.Empty;
            TxtValue.Focus();
        }

        private void SetEditBtn()
        {
            BtnConfirm.Enabled = true;
            BtnRollBack.Enabled = true;
        }

        private void ChangeEnvironmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var str = string.Empty;

            foreach (var i in envirList)
            {
                str += i + ";";
            }

            if (str.Equals(preStr))
            {
                return;
            }
            Environment.SetEnvironmentVariable("test",str, EnvironmentVariableTarget.User);
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TxtValue.Text = dialog.SelectedPath;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            // How to Achieve Win10  DoubleClickToShowTextBox?  So HARD MAN

            if (EnvironmentListView.SelectedItems.Count != 0)
            {
                var str = EnvironmentListView.SelectedItems[0].Text;
                TxtValue.Text = str;
                
                SetEditBtn();

                BtnRollBack.Click += (o, args) =>
                {
                    TxtValue.Text = str;
                };

                BtnConfirm.Click += (o, args) =>
                {
                    if (!TxtValue.Text.Equals(str))
                    {
                        UpdateEnvirList(str, TxtValue.Text);
                    }
                    EnvironmentListView.SelectedItems[0].Text = TxtValue.Text;
                    UnsetEditBtn();
                };
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (EnvironmentListView.SelectedItems.Count != 0)
            {
                var str = EnvironmentListView.SelectedItems[0].Text;
                envirList.Remove(str);
                UpdateListView();
                // EnvironmentListView.Items.
            }
        }

        private void UpdateEnvirList(string oldStr, string newStr)
        {
            var index = envirList.FindIndex(t => t.Equals(oldStr));
            envirList[index] = newStr;
        }

        private void UpdateListView()
        {
            EnvironmentListView.Items.Clear();
            foreach (var i in envirList)
            {
                EnvironmentListView.Items.Add(i);
            }
        }
    }
}
