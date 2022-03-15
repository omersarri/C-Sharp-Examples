using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kim_milyoner_olmak_ister
{
    public partial class Form1 : Form
    {
        public int sayac = 1;
        public int timersayac = 31;
        
        public Form1()
        {
            InitializeComponent();
            label6.Text = "0";
            label8.Text = "0";
            timer1.Start();
            
        }

        public void Sorular(int sorunumber)
        {
            
            label5.Text = ("" + sorunumber);
            switch (sorunumber)
            {
                case 1:
                    richTextBox1.AppendText(Environment.NewLine + " Antalya'nın plakası kaçtır?");
                    radioButton1.Text = "06";
                    radioButton2.Text = "45";
                    radioButton3.Text = "70";
                    radioButton4.Text = "07";
                    
                    
                    break;
                case 2:
                    richTextBox1.Clear();
                    richTextBox1.AppendText(Environment.NewLine + " Bir işin uygun ve kolay olduğunu belirtmek için hangisi söylenir?");
                    radioButton1.Text = "Burnuma göre";
                    radioButton2.Text = "Dişime göre";
                    radioButton3.Text = "Kaşıma göre";
                    radioButton4.Text = "Bıyığıma göre";
                    break;
                case 3:
                    richTextBox1.Clear();
                    richTextBox1.AppendText(Environment.NewLine + "Atasözüne göre 'gönülden ırak olan' kimdir?");
                    radioButton1.Text = "Arabası tamircide olan";
                    radioButton2.Text = "Evi uzak olan";
                    radioButton3.Text = "Gözden ırak olan";
                    radioButton4.Text = "İş yeri karşıda olan";
                    break;
                case 4:
                    richTextBox1.Clear();
                    richTextBox1.AppendText(Environment.NewLine + "Sosyal medyada, kısa sürede ve kolayca takipçi kazanmak isteyenlerin uyguladığı klişe taktik hangisidir?");
                    radioButton1.Text = "Atara atar gidere gider";
                    radioButton2.Text = "Gözeg göz dişe diş";
                    radioButton3.Text = "Omuza omuz";
                    radioButton4.Text = "Takibe takip";
                    break;
            }
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            Sorular(1);
            
        }

         void richTextBox1_TextChanged(object sender, EventArgs e)
         {

         }

      

        public void button5_Click(object sender, EventArgs e)
        {
            
            if (sayac == 1 && radioButton4.Checked)
            {
                timer1.Stop();
                timersayac = 31;
                MessageBox.Show("Doğru");
                Sorular(2);
                sayac++;
                label6.Text = Convert.ToString(sayac - 1);
                label8.Text = Convert.ToString(1000);
                radioButton4.Checked = false;
                timer1.Start();
            }
            
            else if (sayac == 2 && radioButton2.Checked)
            {
                timer1.Stop();
                timersayac = 31;
                MessageBox.Show("Doğru");
                Sorular(3);
                sayac++;
                label6.Text = Convert.ToString(sayac - 1);
                label8.Text = Convert.ToString(2500);
                radioButton2.Checked = false;
                timer1.Start();
            }
            else if (sayac == 3 && radioButton3.Checked)
            {
                timer1.Stop();
                timersayac = 31;
                MessageBox.Show("Doğru");
                Sorular(4);
                sayac++;
                label6.Text = Convert.ToString(sayac - 1);
                label8.Text = Convert.ToString(5000);
                radioButton3.Checked = false;
                timer1.Start();
            }
            else if (sayac == 4 && radioButton4.Checked)
            {
                timer1.Stop();
                timersayac = 31;
                MessageBox.Show("Doğru");
                sayac++;
                label6.Text = Convert.ToString(sayac - 1);
                label8.Text = Convert.ToString(10000);
                timer1.Start();
                MessageBox.Show("Tebriklerin 10000 Tl ödülün sahibi oldunuz!");
                MessageBox.Show("Tabiki para falan vermicez");
                MessageBox.Show("Hadi şimdi SİKTİR!");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Kaybettin Cahil Cühela");
                Application.Exit();
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timersayac -= 1;
            label3.Text = timersayac.ToString();
            if (timersayac == 0)
            {
                timer1.Stop();
                MessageBox.Show("Süre Bitti Kaybettiniz");
                Application.Exit();
            }



        }
    }
}
