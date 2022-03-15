using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yıldızlardan_Kare
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
            int firstNo = Convert.ToInt32(textBox1.Text);
            int lastNo = Convert.ToInt32(textBox2.Text);
            int total = 0;
            for (int i = firstNo; i <= lastNo; i++)
            {
                total = total + i;
            }
            MessageBox.Show(Convert.ToString(total));
        }
    }
}
