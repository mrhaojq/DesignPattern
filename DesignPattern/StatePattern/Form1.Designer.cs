namespace StatePattern
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_currentState = new System.Windows.Forms.Label();
            this.rtb_content = new System.Windows.Forms.RichTextBox();
            this.btn_use = new System.Windows.Forms.Button();
            this.btn_alarm = new System.Windows.Forms.Button();
            this.btn_phone = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_currentState
            // 
            this.lb_currentState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_currentState.Location = new System.Drawing.Point(12, 9);
            this.lb_currentState.Name = "lb_currentState";
            this.lb_currentState.Size = new System.Drawing.Size(776, 30);
            this.lb_currentState.TabIndex = 0;
            // 
            // rtb_content
            // 
            this.rtb_content.Location = new System.Drawing.Point(12, 43);
            this.rtb_content.Name = "rtb_content";
            this.rtb_content.Size = new System.Drawing.Size(776, 355);
            this.rtb_content.TabIndex = 1;
            this.rtb_content.Text = "";
            // 
            // btn_use
            // 
            this.btn_use.Location = new System.Drawing.Point(138, 415);
            this.btn_use.Name = "btn_use";
            this.btn_use.Size = new System.Drawing.Size(122, 23);
            this.btn_use.TabIndex = 2;
            this.btn_use.Text = "使用金库";
            this.btn_use.UseVisualStyleBackColor = true;
            this.btn_use.Click += new System.EventHandler(this.btn_use_Click);
            // 
            // btn_alarm
            // 
            this.btn_alarm.Location = new System.Drawing.Point(266, 415);
            this.btn_alarm.Name = "btn_alarm";
            this.btn_alarm.Size = new System.Drawing.Size(122, 23);
            this.btn_alarm.TabIndex = 3;
            this.btn_alarm.Text = "按下警铃";
            this.btn_alarm.UseVisualStyleBackColor = true;
            this.btn_alarm.Click += new System.EventHandler(this.btn_alarm_Click);
            // 
            // btn_phone
            // 
            this.btn_phone.Location = new System.Drawing.Point(394, 415);
            this.btn_phone.Name = "btn_phone";
            this.btn_phone.Size = new System.Drawing.Size(122, 23);
            this.btn_phone.TabIndex = 4;
            this.btn_phone.Text = "正常通话";
            this.btn_phone.UseVisualStyleBackColor = true;
            this.btn_phone.Click += new System.EventHandler(this.btn_phone_Click);
            // 
            // btn_end
            // 
            this.btn_end.Location = new System.Drawing.Point(522, 415);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(122, 23);
            this.btn_end.TabIndex = 5;
            this.btn_end.Text = "结束";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_phone);
            this.Controls.Add(this.btn_alarm);
            this.Controls.Add(this.btn_use);
            this.Controls.Add(this.rtb_content);
            this.Controls.Add(this.lb_currentState);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_currentState;
        private System.Windows.Forms.RichTextBox rtb_content;
        private System.Windows.Forms.Button btn_use;
        private System.Windows.Forms.Button btn_alarm;
        private System.Windows.Forms.Button btn_phone;
        private System.Windows.Forms.Button btn_end;
    }
}

