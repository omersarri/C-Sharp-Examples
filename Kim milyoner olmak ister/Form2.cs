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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f3 = new Form1();
            f3.ShowDialog();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("30 Saniye içinde doğru şıkkı seçip 'Sonraki Soru' butonuna basınız.");
        }
    }
}
