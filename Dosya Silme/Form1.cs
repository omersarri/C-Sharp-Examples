using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dosya_Silme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string userName = Environment.UserName;
            System.IO.DirectoryInfo di = new DirectoryInfo("C:/Users/Omer/Desktop/");
            Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);

            foreach (FileInfo file in di.EnumerateFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.EnumerateDirectories())
            {
                dir.Delete(true);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
