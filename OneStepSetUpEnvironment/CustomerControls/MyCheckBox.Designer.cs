namespace OneSetSetUpEnvironment.CustomerControls
{
    partial class MyCheckBox
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
            this.lbl_Num = new System.Windows.Forms.Label();
            this.picBox_Task = new System.Windows.Forms.PictureBox();
            this.lbl_TaskName = new System.Windows.Forms.Label();
            this.checkBox_Select = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Task)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Num
            // 
            this.lbl_Num.AutoSize = true;
            this.lbl_Num.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Num.Location = new System.Drawing.Point(3, 22);
            this.lbl_Num.Name = "lbl_Num";
            this.lbl_Num.Size = new System.Drawing.Size(62, 16);
            this.lbl_Num.TabIndex = 0;
            this.lbl_Num.Text = "label1";
            // 
            // picBox_task
            // 
            this.picBox_Task.Location = new System.Drawing.Point(78, 3);
            this.picBox_Task.Name = "picBox_task";
            this.picBox_Task.Size = new System.Drawing.Size(45, 40);
            this.picBox_Task.TabIndex = 1;
            this.picBox_Task.TabStop = false;
            // 
            // lbl_TaskName
            // 
            this.lbl_TaskName.AutoSize = true;
            this.lbl_TaskName.Font = new System.Drawing.Font("宋体", 15F);
            this.lbl_TaskName.Location = new System.Drawing.Point(155, 18);
            this.lbl_TaskName.Name = "lbl_TaskName";
            this.lbl_TaskName.Size = new System.Drawing.Size(69, 20);
            this.lbl_TaskName.TabIndex = 2;
            this.lbl_TaskName.Text = "label2";
            // 
            // cb_check
            // 
            this.checkBox_Select.Font = new System.Drawing.Font("宋体", 15F);
            this.checkBox_Select.Location = new System.Drawing.Point(267, 14);
            this.checkBox_Select.Name = "cb_check";
            this.checkBox_Select.Size = new System.Drawing.Size(30, 30);
            this.checkBox_Select.TabIndex = 3;
            this.checkBox_Select.UseVisualStyleBackColor = true;
            // 
            // MyCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox_Select);
            this.Controls.Add(this.lbl_TaskName);
            this.Controls.Add(this.picBox_Task);
            this.Controls.Add(this.lbl_Num);
            this.Name = "MyCheckBox";
            this.Size = new System.Drawing.Size(300, 50);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Task)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Num;
        private System.Windows.Forms.PictureBox picBox_Task;
        private System.Windows.Forms.Label lbl_TaskName;
        private System.Windows.Forms.CheckBox checkBox_Select;
    }
}
