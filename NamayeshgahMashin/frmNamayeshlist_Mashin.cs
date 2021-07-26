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
    public partial class frmNamayeshlist_Mashin : Form
    {
        mashinQuery query = new mashinQuery();
        public frmNamayeshlist_Mashin()
        {
            InitializeComponent();
        }

        private void frmNamayeshlist_Mashin_Load(object sender, EventArgs e)
        {
            dataGridView_mashin.DataSource = query.Allmashin();
            dataGridView_mashin.Columns[0].HeaderText = "شناسه ماشین";
            dataGridView_mashin.Columns[1].HeaderText = "نام ماشین";
            dataGridView_mashin.Columns[2].HeaderText = "رنگ ماشین";
            dataGridView_mashin.Columns[3].HeaderText = "کارخانه سازنده";
            dataGridView_mashin.Columns[4].HeaderText = "محل تولید";
            dataGridView_mashin.Columns[5].HeaderText = "توضیحات";
        }

        private void txtserch_TextChanged(object sender, EventArgs e)
        {
            (dataGridView_mashin.DataSource as DataTable).DefaultView.RowFilter = string.Format("nameMashin LIKE '{0}%'", txtserch.Text);
        }
    }
}
