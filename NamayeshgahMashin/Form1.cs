using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NamayeshgahMashin
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

        private void btnlistmoshtari_Click(object sender, EventArgs e)
        {
            frmNamayeshlist_moshtari frm = new frmNamayeshlist_moshtari();
            frm.Show();
        }

        private void btnmoshtari_Click(object sender, EventArgs e)
        {
            frmMoshtari frm = new frmMoshtari();
            frm.Show();
        }

        private void btnNamyeshlist_masolforosh_Click(object sender, EventArgs e)
        {
            frmNamayeshlist_masolforosh frm = new frmNamayeshlist_masolforosh();
            frm.Show();
        }

        private void btnmasolforosh_Click(object sender, EventArgs e)
        {
            frmMasolforosh frm = new frmMasolforosh();
            frm.Show();
        }

        private void btnNamayeshlist_mashin_Click(object sender, EventArgs e)
        {
            frmNamayeshlist_Mashin frm = new frmNamayeshlist_Mashin();
            frm.Show();
        }

        private void btnmashin_Click(object sender, EventArgs e)
        {

            frmMashin frm = new frmMashin();
            frm.Show();
        }

        private void btnNamayeshlist_forosh_Click(object sender, EventArgs e)
        {
            frmNamayeshlist_foroshMashin frm = new frmNamayeshlist_foroshMashin();
            frm.Show();
        }

        private void btnforoshMashin_Click(object sender, EventArgs e)
        {
            frmForoshmashin frm = new frmForoshmashin();
            frm.Show();
        }
    }
}
