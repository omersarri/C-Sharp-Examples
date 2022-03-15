using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string urun_ismi = textBox1.Text;
            int urun_fiyati = Convert.ToInt32(textBox2.Text);
            int vergili_fiyat = urun_fiyati * 8 / 100 + urun_fiyati;
            listBox1.Items.Add($"{urun_ismi} Yüzde 8 KDV İle {vergili_fiyat} Liraya Denk Geliyor.");
        }
    }
}
