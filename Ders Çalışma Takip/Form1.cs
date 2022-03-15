using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_Çalışma_Takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hideboxes(bool x)
        {
            if (richTextBox1.Text == "") { richTextBox1.Visible = x; checkBox1.Visible = x; }
            if (richTextBox2.Text == "") { richTextBox2.Visible = x; checkBox2.Visible = x; }
            if (richTextBox3.Text == "") { richTextBox3.Visible = x; checkBox3.Visible = x; }
            if (richTextBox4.Text == "") { richTextBox4.Visible = x; checkBox4.Visible = x; }
            if (richTextBox5.Text == "") { richTextBox5.Visible = x; checkBox5.Visible = x; }
            if (richTextBox6.Text == "") { richTextBox6.Visible = x; checkBox6.Visible = x; }
            if (richTextBox7.Text == "") { richTextBox7.Visible = x; checkBox7.Visible = x; }
            if (richTextBox8.Text == "") { richTextBox8.Visible = x; checkBox8.Visible = x; }
            if (richTextBox9.Text == "") { richTextBox9.Visible = x; checkBox9.Visible = x; }
            if (richTextBox10.Text == "") { richTextBox10.Visible = x; checkBox10.Visible = x; }
            if (richTextBox11.Text == "") { richTextBox11.Visible = x; checkBox11.Visible = x; }
            if (richTextBox12.Text == "") { richTextBox12.Visible = x; checkBox12.Visible = x; }
            if (richTextBox13.Text == "") { richTextBox13.Visible = x; checkBox13.Visible = x; }
            if (richTextBox14.Text == "") { richTextBox14.Visible = x; checkBox14.Visible = x; }
            if (richTextBox15.Text == "") { richTextBox15.Visible = x; checkBox15.Visible = x; }
            if (richTextBox16.Text == "") { richTextBox16.Visible = x; checkBox16.Visible = x; }
            if (richTextBox17.Text == "") { richTextBox17.Visible = x; checkBox17.Visible = x; }
            if (richTextBox18.Text == "") { richTextBox18.Visible = x; checkBox18.Visible = x; }
            if (richTextBox19.Text == "") { richTextBox19.Visible = x; checkBox19.Visible = x; }
            if (richTextBox20.Text == "") { richTextBox20.Visible = x; checkBox20.Visible = x; }
            if (richTextBox21.Text == "") { richTextBox21.Visible = x; checkBox21.Visible = x; }

        }
        private void readOnly(bool y)
        {
            if (richTextBox1.Text != "") { richTextBox1.ReadOnly = y; }
            if (richTextBox2.Text != "") { richTextBox2.ReadOnly = y; }
            if (richTextBox3.Text != "") { richTextBox3.ReadOnly = y; }
            if (richTextBox4.Text != "") { richTextBox4.ReadOnly = y; }
            if (richTextBox5.Text != "") { richTextBox5.ReadOnly = y; }
            if (richTextBox6.Text != "") { richTextBox6.ReadOnly = y; }
            if (richTextBox7.Text != "") { richTextBox7.ReadOnly = y; }
            if (richTextBox8.Text != "") { richTextBox8.ReadOnly = y; }
            if (richTextBox9.Text != "") { richTextBox9.ReadOnly = y; }
            if (richTextBox10.Text != "") { richTextBox10.ReadOnly = y; }
            if (richTextBox11.Text != "") { richTextBox11.ReadOnly = y; }
            if (richTextBox12.Text != "") { richTextBox12.ReadOnly = y; }
            if (richTextBox13.Text != "") { richTextBox13.ReadOnly = y; }
            if (richTextBox14.Text != "") { richTextBox14.ReadOnly = y; }
            if (richTextBox15.Text != "") { richTextBox15.ReadOnly = y; }
            if (richTextBox16.Text != "") { richTextBox16.ReadOnly = y; }
            if (richTextBox17.Text != "") { richTextBox17.ReadOnly = y; }
            if (richTextBox18.Text != "") { richTextBox18.ReadOnly = y; }
            if (richTextBox19.Text != "") { richTextBox19.ReadOnly = y; }
            if (richTextBox20.Text != "") { richTextBox20.ReadOnly = y; }
            if (richTextBox21.Text != "") { richTextBox21.ReadOnly = y; }
            
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideboxes(true);
            button1.Visible = false;
            button2.Visible = true;
            readOnly(false);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hideboxes(false);
            button2.Visible = false;
            switch (DateTime.Now.DayOfWeek.ToString())
            {
                case "Monday": panel1.BackColor = Color.LightGreen; break;
                case "Tuesday": panel2.BackColor = Color.LightGreen; break;
                case "Wednesday": panel3.BackColor = Color.LightGreen; break;
                case "Thursday": panel4.BackColor = Color.LightGreen; break;
                case "Friday": panel5.BackColor = Color.LightGreen; break;
                case "Saturday": panel6.BackColor = Color.LightGreen; break;
                case "Sunday": panel7.BackColor = Color.LightGreen; break;
                default:
                    break;
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            hideboxes(false);
            readOnly(true);
            button1.Visible = true;
            button2.Visible = false;
        }
    }
}
