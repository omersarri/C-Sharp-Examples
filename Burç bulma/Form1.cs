using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burç_bulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(dateTimePicker1.Value.Day.ToString());
            int month = Convert.ToInt32(dateTimePicker1.Value.Month.ToString());
            if((21<=day && month == 3) ||(day<=20 && month==4))
            {
                label2.Text="KOÇ";
            }
            else if ((21 <= day && month == 4) || (day <= 20 && month == 5))
            {
                label2.Text = "BOĞA";
            }
            else if ((21 <= day && month == 5) || (day <= 21 && month == 6))
            {
                label2.Text = "İKİZLER";
            }
            else if ((22 <= day && month == 6) || (day <= 22 && month == 7))
            {
                label2.Text = "YENGEÇ";
            }
            else if ((23 <= day && month == 7) || (day <= 22 && month == 8))
            {
                label2.Text = "ASLAN";
            }
            else if ((23 <= day && month == 8) || (day <= 22 && month == 9))
            {
                label2.Text = "BAŞAK";
            }
            else if ((23 <= day && month == 9) || (day <= 23 && month == 10))
            {
                label2.Text = "TERAZİ";
            }
            else if ((24 <= day && month == 10) || (day <= 22 && month == 11))
            {
                label2.Text = "AKREP";
            }
            else if ((23 <= day && month == 11) || (day <= 21 && month == 12))
            {
                label2.Text = "YAY";
            }
            else if ((22 <= day && month == 12) || (day <= 20 && month == 1))
            {
                label2.Text = "OĞLAK";
            }
            else if ((21 <= day && month == 1) || (day <= 18 && month == 2))
            {
                label2.Text = "KOVA";
            }
            else if ((19 <= day && month == 2) || (day <= 20 && month == 3))
            {
                label2.Text = "BALIK";
            }
        }
    }
}
