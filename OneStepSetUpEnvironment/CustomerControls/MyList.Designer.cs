﻿namespace OneSetSetUpEnvironment.CustomerControls
{
    partial class MyList
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.processBar_Download = new System.Windows.Forms.ProgressBar();
            this.label_FileName = new System.Windows.Forms.Label();
            this.pictureBox_Img = new System.Windows.Forms.PictureBox();
            this.label_Download = new System.Windows.Forms.Label();
            this.btn_StartStop = new System.Windows.Forms.Button();
            this.label_num = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Img)).BeginInit();
            this.SuspendLayout();
            // 
            // processBar_Download
            // 
            this.processBar_Download.Location = new System.Drawing.Point(437, 8);
            this.processBar_Download.Name = "processBar_Download";
            this.processBar_Download.Size = new System.Drawing.Size(182, 31);
            this.processBar_Download.TabIndex = 0;
            // 
            // label_FileName
            // 
            this.label_FileName.AutoSize = true;
            this.label_FileName.Font = new System.Drawing.Font("宋体", 15F);
            this.label_FileName.Location = new System.Drawing.Point(362, 14);
            this.label_FileName.Name = "label_FileName";
            this.label_FileName.Size = new System.Drawing.Size(69, 20);
            this.label_FileName.TabIndex = 1;
            this.label_FileName.Text = "label1";
            // 
            // pictureBox_Img
            // 
            this.pictureBox_Img.Location = new System.Drawing.Point(65, 3);
            this.pictureBox_Img.Name = "pictureBox_Img";
            this.pictureBox_Img.Size = new System.Drawing.Size(38, 44);
            this.pictureBox_Img.TabIndex = 2;
            this.pictureBox_Img.TabStop = false;
            // 
            // label_Download
            // 
            this.label_Download.AutoSize = true;
            this.label_Download.Font = new System.Drawing.Font("宋体", 15F);
            this.label_Download.Location = new System.Drawing.Point(625, 16);
            this.label_Download.Name = "label_Download";
            this.label_Download.Size = new System.Drawing.Size(69, 20);
            this.label_Download.TabIndex = 3;
            this.label_Download.Text = "label2";
            // 
            // btn_StartStop
            // 
            this.btn_StartStop.AutoSize = true;
            this.btn_StartStop.Location = new System.Drawing.Point(700, 16);
            this.btn_StartStop.Name = "btn_StartStop";
            this.btn_StartStop.Size = new System.Drawing.Size(88, 23);
            this.btn_StartStop.TabIndex = 4;
            this.btn_StartStop.Text = "Start";
            this.btn_StartStop.UseVisualStyleBackColor = true;
            this.btn_StartStop.Click += new System.EventHandler(this.btn_StartStop_Click);
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.Font = new System.Drawing.Font("宋体", 12F);
            this.label_num.Location = new System.Drawing.Point(3, 19);
            this.label_num.Name = "label_num";
            this.label_num.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_num.Size = new System.Drawing.Size(56, 16);
            this.label_num.TabIndex = 5;
            this.label_num.Text = "label1";
            // 
            // MyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_num);
            this.Controls.Add(this.btn_StartStop);
            this.Controls.Add(this.label_Download);
            this.Controls.Add(this.pictureBox_Img);
            this.Controls.Add(this.label_FileName);
            this.Controls.Add(this.processBar_Download);
            this.Name = "MyList";
            this.Size = new System.Drawing.Size(800, 50);
            this.Load += new System.EventHandler(this.MyList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar processBar_Download;
        private System.Windows.Forms.Label label_FileName;
        private System.Windows.Forms.PictureBox pictureBox_Img;
        private System.Windows.Forms.Label label_Download;
        private System.Windows.Forms.Button btn_StartStop;
        private System.Windows.Forms.Label label_num;
    }
}
