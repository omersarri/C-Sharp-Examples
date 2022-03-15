using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slayt_Gösterisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = folderBrowserDialog1.SelectedPath;
                
                string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                foreach (string item in files)
                {
                    listBox1.Items.Add(item.Substring(item.LastIndexOf("\\") + 1));
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = txtPath.Text + "\\" + listBox1.Items[sayac].ToString();
            sayac++;
            if (sayac == listBox1.Items.Count) 
            {
                sayac = 0;
            }
                
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if(trackBar1.Value == 0)
            {
                trackBar1.Value += 1;
            }
            timer1.Interval = trackBar1.Value * 1000;
            timer1.Start();
        }
    }
}
