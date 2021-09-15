namespace EasyEnvironment
{
    partial class SaveConfigForm
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
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.EnvPanel = new System.Windows.Forms.Panel();
            this.SoftwarePanel = new System.Windows.Forms.Panel();
            this.Label_Env = new System.Windows.Forms.Label();
            this.Label_Software = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(22, 416);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(80, 33);
            this.btn_Confirm.TabIndex = 1;
            this.btn_Confirm.Text = "确认";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.Btn_Confirm_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(197, 416);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(86, 33);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // EnvPanel
            // 
            this.EnvPanel.Location = new System.Drawing.Point(12, 32);
            this.EnvPanel.Name = "EnvPanel";
            this.EnvPanel.Size = new System.Drawing.Size(300, 203);
            this.EnvPanel.TabIndex = 3;
            // 
            // SoftwarePanel
            // 
            this.SoftwarePanel.Location = new System.Drawing.Point(12, 265);
            this.SoftwarePanel.Name = "SoftwarePanel";
            this.SoftwarePanel.Size = new System.Drawing.Size(300, 145);
            this.SoftwarePanel.TabIndex = 4;
            // 
            // Label_Env
            // 
            this.Label_Env.AutoSize = true;
            this.Label_Env.Font = new System.Drawing.Font("宋体", 15F);
            this.Label_Env.Location = new System.Drawing.Point(12, 9);
            this.Label_Env.Name = "Label_Env";
            this.Label_Env.Size = new System.Drawing.Size(119, 20);
            this.Label_Env.TabIndex = 5;
            this.Label_Env.Text = "Environment";
            // 
            // Label_Software
            // 
            this.Label_Software.AutoSize = true;
            this.Label_Software.Font = new System.Drawing.Font("宋体", 15F);
            this.Label_Software.Location = new System.Drawing.Point(13, 242);
            this.Label_Software.Name = "Label_Software";
            this.Label_Software.Size = new System.Drawing.Size(89, 20);
            this.Label_Software.TabIndex = 6;
            this.Label_Software.Text = "Software";
            // 
            // SaveConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 461);
            this.Controls.Add(this.Label_Software);
            this.Controls.Add(this.Label_Env);
            this.Controls.Add(this.SoftwarePanel);
            this.Controls.Add(this.EnvPanel);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Confirm);
            this.Name = "SaveConfigForm";
            this.Text = "SaveConfigForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaveConfigForm_FormClosing);
            this.Load += new System.EventHandler(this.SaveConfigForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Panel EnvPanel;
        private System.Windows.Forms.Panel SoftwarePanel;
        private System.Windows.Forms.Label Label_Env;
        private System.Windows.Forms.Label Label_Software;
    }
}