using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_dükkanıü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim = textBox1.Text;
            string soyisim = textBox2.Text;
            //listBox1.Items.Add(isim);
            //listBox1.Items.Add(soyisim);
            //foreach (object item in checkedListBox1.CheckedItems)
            //listBox1.Items.Add(item);
            listBox1.Items.Add(string.Format("{0}  {1}", isim, soyisim));
            foreach (object item in checkedListBox1.CheckedItems)
                listBox1.Items.Add(item);
            foreach (int i in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
