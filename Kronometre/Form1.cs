using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sec = 0;
        int min = 0;
        int hour = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            lblSec.Text = sec.ToString("D2");
            if (sec == 60)
            {
                sec = 0;
                min++;
                lblMin.Text = min.ToString("D2");
                if (min == 60)
                {
                    min = 0;
                    hour++;
                    lblHour.Text = hour.ToString("D2") ;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            listBox1.Items.Add($"{lblHour.Text}:{lblMin.Text}:{lblSec.Text}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
             sec = 0;
             min = 0;
             hour = 0;
            lblSec.Text = sec.ToString("D2");
            lblMin.Text = min.ToString("D2");
            lblHour.Text = hour.ToString("D2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
