using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Rezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }
        
        public void Form1_Load(object sender, EventArgs e)
        {
            int sayacx = 79;
            int sayacy = 77;
            for (int i = 1; i <= 50; i++)
            {
                Label lbl = new Label();
                ContextMenu cm = new ContextMenu();
                cm.MenuItems.Add(new MenuItem("Rezerve Et", new EventHandler(rezerve_Click)));
                cm.MenuItems.Add(new MenuItem("İptal Et", new EventHandler(iptal_Click)));
                
                lbl.ContextMenu = cm;
                lbl.Name = "Sıra" + i;
                lbl.Text = "Sıra " + i;
                lbl.BackColor = Color.LawnGreen;
                lbl.Size = new System.Drawing.Size(47, 52);
                lbl.Location = new System.Drawing.Point(sayacx, sayacy);
                this.Controls.Add(lbl);
                lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                sayacx += 60;
                if(i%10==0)
                {
                    sayacx = 79;
                    sayacy += 63;
                }
                


            }
        }
        private void iptal_Click(object sender, EventArgs e)
        {
            
            lbl.BackColor = Color.Red;
            //iptal.Enabled = false;
            //rezerve.Enabled = true;
        }

        private void rezerve_Click(object sender, EventArgs e)
        {
            
            lbl.BackColor = Color.Green;
            //iptal.Enabled = true;
            //rezerve.Enabled = false;
        }
    }
}
