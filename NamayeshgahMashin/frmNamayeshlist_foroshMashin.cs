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
    public partial class frmNamayeshlist_foroshMashin : Form
    {
        foroshMadhinQuery query = new foroshMadhinQuery();
        public frmNamayeshlist_foroshMashin()
        {
            InitializeComponent();
        }

        private void frmNamayeshlist_foroshMashin_Load(object sender, EventArgs e)
        {
            dataGridView_foroshmashin.DataSource = query.AllforoshMashin();
            dataGridView_foroshmashin.Columns[0].HeaderText = "کد شناسه فروش ماشین";
            dataGridView_foroshmashin.Columns[1].HeaderText = "کد شناسه مسئول فروش";
            dataGridView_foroshmashin.Columns[2].HeaderText = "کد شناسه مشتری";
            dataGridView_foroshmashin.Columns[3].HeaderText = "کد شناسه ماشین";
            dataGridView_foroshmashin.Columns[4].HeaderText = "قیمت خودرو";
            dataGridView_foroshmashin.Columns[5].HeaderText = "تاریخ فروش";
            dataGridView_foroshmashin.Columns[6].HeaderText = "توضیحات";
        }

        private void txtserch_TextChanged(object sender, EventArgs e)
        {
            (dataGridView_foroshmashin.DataSource as DataTable).DefaultView.RowFilter = string.Format("IdMashin LIKE '{0}%'", txtserch.Text);
        }
    }
    }

