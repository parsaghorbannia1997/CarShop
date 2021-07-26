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
    public partial class frmNamayeshlist_moshtari : Form
    {
        moshtariQuery query = new moshtariQuery();
        public frmNamayeshlist_moshtari()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmNamayeshlistmoshtari_Load(object sender, EventArgs e)
        {
            dataGridView_moshtari.DataSource = query.Allmoshtari();
            dataGridView_moshtari.Columns[0].HeaderText = "کد مشتری";
            dataGridView_moshtari.Columns[1].HeaderText = " نام";
            dataGridView_moshtari.Columns[2].HeaderText = "نام خانوادگی";
            dataGridView_moshtari.Columns[3].HeaderText = "موبایل";
            dataGridView_moshtari.Columns[4].HeaderText = "آدرس";
        }

        private void txtserch_TextChanged(object sender, EventArgs e)
        {
            (dataGridView_moshtari.DataSource as DataTable).DefaultView.RowFilter=string.Format("lastname LIKE '{0}%'", txtserch.Text);
        }
    }
}
