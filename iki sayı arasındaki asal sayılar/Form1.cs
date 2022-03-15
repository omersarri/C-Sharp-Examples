using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iki_sayı_arasındaki_asal_sayılar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int firstNo = Convert.ToInt32(textBox1.Text);
            int secondNo = Convert.ToInt32(textBox2.Text);
            List<int> numbers = new List<int>();
            for (int i = firstNo; i <= secondNo; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i%j==0)
                    {
                        numbers.Add(j);
                    }
                }
                if (numbers.Count < 3)
                {
                    listBox1.Items.Add(i);
                    
                }
                numbers.Clear();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
