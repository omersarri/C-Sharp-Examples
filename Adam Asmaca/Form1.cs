using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adam_Asmaca
{
    public partial class Form1 : Form
    {
        int soru_sayi = 1;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            switch (soru_sayi)
            {
                case 1: textBox1.Text = "BU BİR BÖCEKTİR";
                    break;
                    
                default:
                    break;
            }
            
        }

        private void button_S_Click(object sender, EventArgs e)
        {
            if(soru_sayi==1)
            {
                Kutu1.Text = "S";
            }
        }

        private void button_I2_Click(object sender, EventArgs e)
        {
            if (soru_sayi == 1)
            {
                Kutu2.Text = "İ";
            }
        }

        private void button_N_Click(object sender, EventArgs e)
        {
            if (soru_sayi == 1)
            {
                Kutu3.Text = "N";
            }
        }

        private void button_E_Click(object sender, EventArgs e)
        {
            if (soru_sayi == 1)
            {
                Kutu4.Text = "E";
            }
        }

        private void button_K_Click(object sender, EventArgs e)
        {
            if (soru_sayi == 1)
            {
                Kutu4.Text = "K";
            }
        }
    }
}
