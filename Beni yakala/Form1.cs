using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beni_yakala
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
            MessageBox.Show("Tebrikler Amk");
        }

        private void button1_Hover(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayix = rnd.Next(50, 650);
            int sayiy = rnd.Next(50, 450);
            button1.Location = new Point(sayix, sayiy);
        }
    }
}
