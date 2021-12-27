using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Büfe_Satış_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kazanc = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, cay, su, toplam;
            misir = Convert.ToInt16(txtMisir.Text);
            cay = Convert.ToInt16(txtCay.Text);
            bilet = Convert.ToInt16(txtBilet.Text);
            su = Convert.ToInt16(txtSu.Text);

            toplam = misir * 4 + cay * 2 + bilet * 8 + su * 1;

            lblToplam.Text = toplam.ToString() + " TL";

            kazanc = kazanc + toplam;
            lblKazanc.Text = kazanc.ToString() + " TL";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBilet.Text = "";
            txtCay.Text = "";
            txtMisir.Text = "";
            txtSu.Text = "";
            txtMisir.Focus();
        }
    }
}
