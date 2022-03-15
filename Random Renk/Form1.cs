using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Renk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            int c = rnd.Next(0, 255);
            this.BackColor = Color.FromArgb(a, b, c);


        }
    }
}
