using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics; 
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

        private async Task timer1_TickAsync(object sender, EventArgs e)
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

        private void Set_button_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0, k = 0;
            try
            {
                if (!int.TryParse(Hour_textbox.Text, out i) ||
                    !int.TryParse(Minute_textbox.Text, out j) ||
                    !int.TryParse(Sec_textbox.Text, out k))
                {
                    MessageBox.Show("숫자만 입력해 주세요", "Warning !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    if (Convert.ToInt32(Hour_textbox.Text) < 0 ||
                    Convert.ToInt32(Minute_textbox.Text) < 0 ||
                    Convert.ToInt32(Sec_textbox.Text) < 0)
                    {
                        MessageBox.Show("음수는 입력하지 말아주세요", "Warning !", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        set_time = Convert.ToInt32(Hour_textbox.Text) * 3600 + Convert.ToInt32(Minute_textbox.Text) * 60 + Convert.ToInt32(Sec_textbox.Text);
                        if (set_time == 0)
                        {
                            MessageBox.Show("입력값이 없습니다 .입력해 주세요", "Warning !", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("\n예기치않은 오류입니다\n다시시도해주세요" + ex.ToString(), "Exception Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    } 
}

