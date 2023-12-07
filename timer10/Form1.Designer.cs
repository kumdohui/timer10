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
            this.Hour_textBox = new System.Windows.Forms.TextBox();
            this.Sec_textBox = new System.Windows.Forms.TextBox();
            this.Minite_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Hour_textBox
            // 
            this.Hour_textBox.Location = new System.Drawing.Point(80, 186);
            this.Hour_textBox.Name = "Hour_textBox";
            this.Hour_textBox.Size = new System.Drawing.Size(100, 25);
            this.Hour_textBox.TabIndex = 0;
            this.Hour_textBox.Text = "0";
            this.Hour_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Sec_textBox
            // 
            this.Sec_textBox.Location = new System.Drawing.Point(599, 186);
            this.Sec_textBox.Name = "Sec_textBox";
            this.Sec_textBox.Size = new System.Drawing.Size(100, 25);
            this.Sec_textBox.TabIndex = 1;
            this.Sec_textBox.Text = "0";
            this.Sec_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Minite_textbox
            // 
            this.Minite_textbox.Location = new System.Drawing.Point(343, 186);
            this.Minite_textbox.Name = "Minite_textbox";
            this.Minite_textbox.Size = new System.Drawing.Size(100, 25);
            this.Minite_textbox.TabIndex = 2;
            this.Minite_textbox.Text = "0";
            this.Minite_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Minite_textbox);
            this.Controls.Add(this.Sec_textBox);
            this.Controls.Add(this.Hour_textBox);
            this.Name = "Timer";
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Hour_textBox;
        private System.Windows.Forms.TextBox Sec_textBox;
        private System.Windows.Forms.TextBox Minite_textbox;
    }
}

