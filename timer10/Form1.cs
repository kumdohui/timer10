using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace timer10
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hour_textbox.Text = (time / 3600).ToString();
            Minute_textbox.Text = ((time % 3600) / 60).ToString();
            Sec_textbox.Text = (time % 60).ToString();
            if (time == 0)
            {
                {
                    timer1.Stop();
                    Start_stop_button.Text = "Start";
                    flag = false;

                    time = set_time;

                    // 비동기적으로 사운드 재생
                    await PlaySoundAsync();
                    MessageBox.Show("타임오버!");


                }
        }   }
    }
}
