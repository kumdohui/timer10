namespace timer10
{
    partial class Timer
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Hour_textbox = new System.Windows.Forms.TextBox();
            this.Sec_textbox = new System.Windows.Forms.TextBox();
            this.Minute_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Start_stop_button = new System.Windows.Forms.Button();
            this.Set_button = new System.Windows.Forms.Button();
            this.Reset_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Hour_textbox
            // 
            this.Hour_textbox.Location = new System.Drawing.Point(80, 186);
            this.Hour_textbox.Name = "Hour_textbox";
            this.Hour_textbox.Size = new System.Drawing.Size(100, 25);
            this.Hour_textbox.TabIndex = 0;
            this.Hour_textbox.Text = "0";
            this.Hour_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Sec_textbox
            // 
            this.Sec_textbox.Location = new System.Drawing.Point(599, 186);
            this.Sec_textbox.Name = "Sec_textbox";
            this.Sec_textbox.Size = new System.Drawing.Size(100, 25);
            this.Sec_textbox.TabIndex = 1;
            this.Sec_textbox.Text = "0";
            this.Sec_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Minute_textbox
            // 
            this.Minute_textbox.Location = new System.Drawing.Point(343, 186);
            this.Minute_textbox.Name = "Minute_textbox";
            this.Minute_textbox.Size = new System.Drawing.Size(100, 25);
            this.Minute_textbox.TabIndex = 2;
            this.Minute_textbox.Text = "0";
            this.Minute_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "시간";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "분";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(635, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "초";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = ":";
            // 
            // Start_stop_button
            // 
            this.Start_stop_button.Location = new System.Drawing.Point(80, 314);
            this.Start_stop_button.Name = "Start_stop_button";
            this.Start_stop_button.Size = new System.Drawing.Size(100, 39);
            this.Start_stop_button.TabIndex = 8;
            this.Start_stop_button.Text = "Start";
            this.Start_stop_button.UseVisualStyleBackColor = true;
            // 
            // Set_button
            // 
            this.Set_button.Location = new System.Drawing.Point(343, 314);
            this.Set_button.Name = "Set_button";
            this.Set_button.Size = new System.Drawing.Size(101, 39);
            this.Set_button.TabIndex = 9;
            this.Set_button.Text = "Set";
            this.Set_button.UseVisualStyleBackColor = true;
            // 
            // Reset_button
            // 
            this.Reset_button.Location = new System.Drawing.Point(599, 314);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(101, 39);
            this.Reset_button.TabIndex = 10;
            this.Reset_button.Text = "Reset";
            this.Reset_button.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reset_button);
            this.Controls.Add(this.Set_button);
            this.Controls.Add(this.Start_stop_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Minute_textbox);
            this.Controls.Add(this.Sec_textbox);
            this.Controls.Add(this.Hour_textbox);
            this.Name = "Timer";
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Hour_textbox;
        private System.Windows.Forms.TextBox Sec_textbox;
        private System.Windows.Forms.TextBox Minute_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Start_stop_button;
        private System.Windows.Forms.Button Set_button;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.Timer timer1;
    }
}

