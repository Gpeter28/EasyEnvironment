
namespace OneSetSetUpEnvironment.CustomerControls
{
    partial class ExtractList
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
            this.CheckBox_Select = new System.Windows.Forms.CheckBox();
            this.label_TaskName = new System.Windows.Forms.Label();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.label_num = new System.Windows.Forms.Label();
            this.label_postfix = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CheckBox_Select
            // 
            this.CheckBox_Select.AutoSize = true;
            this.CheckBox_Select.Font = new System.Drawing.Font("宋体", 12F);
            this.CheckBox_Select.Location = new System.Drawing.Point(34, 17);
            this.CheckBox_Select.Name = "CheckBox_Select";
            this.CheckBox_Select.Size = new System.Drawing.Size(15, 14);
            this.CheckBox_Select.TabIndex = 0;
            this.CheckBox_Select.UseVisualStyleBackColor = true;
            // 
            // label_TaskName
            // 
            this.label_TaskName.AutoSize = true;
            this.label_TaskName.Font = new System.Drawing.Font("宋体", 15F);
            this.label_TaskName.Location = new System.Drawing.Point(146, 17);
            this.label_TaskName.Name = "label_TaskName";
            this.label_TaskName.Size = new System.Drawing.Size(89, 20);
            this.label_TaskName.TabIndex = 1;
            this.label_TaskName.Text = "TaskName";
            // 
            // Btn_Start
            // 
            this.Btn_Start.Font = new System.Drawing.Font("宋体", 15F);
            this.Btn_Start.Location = new System.Drawing.Point(607, 11);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(134, 26);
            this.Btn_Start.TabIndex = 2;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.Font = new System.Drawing.Font("宋体", 12.5F);
            this.label_num.Location = new System.Drawing.Point(83, 17);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(35, 17);
            this.label_num.TabIndex = 3;
            this.label_num.Text = "num";
            // 
            // label_postfix
            // 
            this.label_postfix.AutoSize = true;
            this.label_postfix.Font = new System.Drawing.Font("宋体", 15F);
            this.label_postfix.Location = new System.Drawing.Point(507, 17);
            this.label_postfix.Name = "label_postfix";
            this.label_postfix.Size = new System.Drawing.Size(79, 20);
            this.label_postfix.TabIndex = 5;
            this.label_postfix.Text = ".endFix";
            // 
            // ExtractList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_postfix);
            this.Controls.Add(this.label_num);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.label_TaskName);
            this.Controls.Add(this.CheckBox_Select);
            this.Name = "ExtractList";
            this.Size = new System.Drawing.Size(800, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBox_Select;
        private System.Windows.Forms.Label label_TaskName;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Label label_num;
        private System.Windows.Forms.Label label_postfix;
    }
}
