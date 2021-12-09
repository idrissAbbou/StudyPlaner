using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StudyPlan
{
    public partial class Timer : UserControl
    {
        int sec;
        int min;
        int h;
        int halt;
        int haltSecond;
        int totalPomadora;
        DateTime endPomadoro;
        Subject subject;
        StudyContext context = new StudyContext();
        public Timer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            subject = context.subjects.Where(s => s.Id == (int)comboBox1.SelectedValue).First();
            endPomadoro = DateTime.Now.AddSeconds(haltSecond);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            calculateTime();
            haltSecond--;
            subject.TotalHours += 1;
            context.SaveChanges();
        }
        private void startAlarm()
        {
            if (DateTime.Compare(endPomadoro, DateTime.Now) <= 0 )
            {
                restAll();
                
                System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();
                soundPlayer.SoundLocation = "./alarm.wav";
                soundPlayer.Play();
                totalPomadora++;
                pomadoaCounterLabel.Text = totalPomadora.ToString();
            }
        }
        private void calculateTime()
        {
            sec++;
            if (sec == 59)
            {
                sec = 0;
                min++;
            }
            if (min == 59)
            {
                min = 0;
                h++;
            }
            startAlarm();
            label1.Text = $"{h.ToString("D2")}:{min.ToString("D2")}:{sec.ToString("D2")}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            restAll();

        }

        private void restAll()
        {
            timer1.Stop();
            sec = 0;
            min = 0;
            h = 0;
            label1.Text = $"{h.ToString("D2")}:{min.ToString("D2")}:{sec.ToString("D2")}";
        }

        private void btnPomadoro_Click(object sender, EventArgs e)
        {
            halt = int.Parse(txtPomadoro.Text);
            haltSecond = halt * 60;
        }

        private void Timer_Load(object sender, EventArgs e)
        {
            StudyContext context = new StudyContext();
            var subjects =  context.subjects.Select(s => s).ToList();
            comboBox1.DataSource = subjects;
            comboBox1.DisplayMember = "Item";
            comboBox1.ValueMember = "Id";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
