
namespace EasyEnvironment
{
    partial class ChangeEnvironmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserLabel = new System.Windows.Forms.Label();
            this.EnvironmentListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TxtValue = new System.Windows.Forms.TextBox();
            this.BtnView = new System.Windows.Forms.Button();
            this.BtnRollBack = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(38, 64);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(53, 12);
            this.UserLabel.TabIndex = 0;
            this.UserLabel.Text = "用户变量";
            // 
            // EnvironmentListView
            // 
            this.EnvironmentListView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.EnvironmentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.EnvironmentListView.HideSelection = false;
            this.EnvironmentListView.Location = new System.Drawing.Point(40, 97);
            this.EnvironmentListView.Name = "EnvironmentListView";
            this.EnvironmentListView.Size = new System.Drawing.Size(479, 300);
            this.EnvironmentListView.TabIndex = 1;
            this.EnvironmentListView.UseCompatibleStateImageBehavior = false;
            this.EnvironmentListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "值";
            this.columnHeader2.Width = 417;
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(295, 415);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 2;
            this.BtnNew.Text = "新建";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(376, 415);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 3;
            this.BtnEdit.Text = "编辑";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(457, 415);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "删除";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TxtValue
            // 
            this.TxtValue.Location = new System.Drawing.Point(97, 59);
            this.TxtValue.Name = "TxtValue";
            this.TxtValue.Size = new System.Drawing.Size(273, 21);
            this.TxtValue.TabIndex = 5;
            // 
            // BtnView
            // 
            this.BtnView.Location = new System.Drawing.Point(444, 59);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(75, 23);
            this.BtnView.TabIndex = 6;
            this.BtnView.Text = "浏览";
            this.BtnView.UseVisualStyleBackColor = true;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // BtnRollBack
            // 
            this.BtnRollBack.Location = new System.Drawing.Point(421, 59);
            this.BtnRollBack.Name = "BtnRollBack";
            this.BtnRollBack.Size = new System.Drawing.Size(17, 23);
            this.BtnRollBack.TabIndex = 7;
            this.BtnRollBack.Text = "R";
            this.BtnRollBack.UseVisualStyleBackColor = true;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(376, 59);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(39, 23);
            this.BtnConfirm.TabIndex = 8;
            this.BtnConfirm.Text = "确认";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            // 
            // ChangeEnvironmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.BtnRollBack);
            this.Controls.Add(this.BtnView);
            this.Controls.Add(this.TxtValue);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.EnvironmentListView);
            this.Controls.Add(this.UserLabel);
            this.Name = "ChangeEnvironmentForm";
            this.Text = "环境变量";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangeEnvironmentForm_FormClosed);
            this.Load += new System.EventHandler(this.ChangeEnvironmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.ListView EnvironmentListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox TxtValue;
        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.Button BtnRollBack;
        private System.Windows.Forms.Button BtnConfirm;
    }
}