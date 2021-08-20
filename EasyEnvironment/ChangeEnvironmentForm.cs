﻿using System;
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
        }

        public void Init()
        {
            var lists = new List<EnvironmentVar>();
            
            // EnvironmentListView
        }

        private List<string> envirList = new List<string>();

        private void ChangeEnvironmentForm_Load(object sender, EventArgs e)
        {
            var flag = Environment.GetEnvironmentVariable("test");

            if (flag != null) 
            {
                var str = Environment.GetEnvironmentVariable("test", EnvironmentVariableTarget.User).Split(';');

                foreach (var i in str)
                {
                    envirList.Add(i);
                    EnvironmentListView.Items.Add(i);
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            EnvironmentListView.Items.Add(txtValue.Text);
            envirList.Add(txtValue.Text);
            txtValue.Clear();
            txtValue.Focus();
        }

        private void ChangeEnvironmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var str = string.Empty;


            foreach (var i in envirList)
            {
                str += i + ";";
            }
            Environment.SetEnvironmentVariable("test",str, EnvironmentVariableTarget.User);
        }
    }
}
