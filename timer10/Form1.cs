using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace timer10
{
    public partial class Timer : Form
    {
        bool flag = false;
        int time = 0;      // 기본설정값
        int set_time = 0; // 사용자설정값 (설정안했을시, 기본설정값과 동일하게 설정)
        SoundPlayer player = new SoundPlayer(System.Environment.CurrentDirectory + @"\sunflower-street-drumloop-85bpm-163900.wav");


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
                
                timer1.Stop();
                Start_stop_button.Text = "Start";
                flag = false;

                time = set_time;

                    // 비동기적으로 사운드 재생
                await PlaySoundAsync();
                MessageBox.Show("타임오버!");


            }
            time--;

        }
        private async Task PlaySoundAsync()
        {
            await Task.Run(() => player.Play());
        }

        private void Start_stop_button_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                timer1.Start();     // 타이머 시작
                flag = true;
                Start_stop_button.Text = "Stop";
            }
            else
            {
                timer1.Stop();      // 타이머 멈춤
                flag = false;
                Start_stop_button.Text = "Start";
            }
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            player.Stop();
            Hour_textbox.Text = (set_time / 3600).ToString();
            Minute_textbox.Text = ((set_time % 3600) / 60).ToString();
            Sec_textbox.Text = (set_time % 60).ToString();
            time = set_time;

        }
    }
}

