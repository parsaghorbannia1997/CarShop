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
    public partial class frmNamayeshlist_masolforosh : Form
    {
        masolforoshQuery query = new masolforoshQuery();
        public frmNamayeshlist_masolforosh()
        {
            InitializeComponent();
        }

        private void frmNamayeshlist_masolforosh_Load(object sender, EventArgs e)
        {
            dataGridView_masolforosh.DataSource = query.Allmasolforosh();
            dataGridView_masolforosh.Columns[0].HeaderText = "کد مسئول فروش";
            dataGridView_masolforosh.Columns[1].HeaderText = "نام";
            dataGridView_masolforosh.Columns[2].HeaderText = "نام خانوادگی";
            dataGridView_masolforosh.Columns[3].HeaderText = "موبایل";
            dataGridView_masolforosh.Columns[4].HeaderText = "آدرس";
      
        }

       
        private void txtserch_TextChanged(object sender, EventArgs e)
        {
            (dataGridView_masolforosh.DataSource as DataTable).DefaultView.RowFilter = string.Format("lastname LIKE '{0}%'", txtserch.Text);
        }
    }
}
