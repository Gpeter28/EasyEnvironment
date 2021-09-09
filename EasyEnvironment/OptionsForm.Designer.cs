
namespace OneSetSetUpEnvironment
{
    partial class OptionsForm
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
            this.CheckBox_AutoStart = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CheckBox_AutoStart
            // 
            this.CheckBox_AutoStart.AutoSize = true;
            this.CheckBox_AutoStart.Font = new System.Drawing.Font("宋体", 15F);
            this.CheckBox_AutoStart.Location = new System.Drawing.Point(36, 41);
            this.CheckBox_AutoStart.Name = "CheckBox_AutoStart";
            this.CheckBox_AutoStart.Size = new System.Drawing.Size(118, 24);
            this.CheckBox_AutoStart.TabIndex = 0;
            this.CheckBox_AutoStart.Text = "AutoStart";
            this.CheckBox_AutoStart.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 308);
            this.Controls.Add(this.CheckBox_AutoStart);
            this.Name = "OptionsForm";
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Options_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBox_AutoStart;
    }
}