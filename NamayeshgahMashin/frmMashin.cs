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
    public partial class frmMashin : Form
    {
        mashinQuery query = new mashinQuery();
        Mashin m = new Mashin();
        public frmMashin()
        {
            InitializeComponent();
        }

        private void frmMashin_Load(object sender, EventArgs e)
        {
            dataGridView_mashin.DataSource = query.Allmashin();
            dataGridView_mashin.Columns[0].HeaderText = "شناسه ماشین";
            dataGridView_mashin.Columns[1].HeaderText = "نام ماشین";
            dataGridView_mashin.Columns[2].HeaderText = "رنگ ماشین";
            dataGridView_mashin.Columns[3].HeaderText = "کارخانه سازنده";
            dataGridView_mashin.Columns[4].HeaderText = "محل تولید";
            dataGridView_mashin.Columns[5].HeaderText = "توضیحات";
            btnsabt.Enabled = false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtidmashin.Text=="")
            {
                errorProvider_mashin.SetError(txtidmashin, "اطلاعات این قسمت باید پرشود");
            }
            else if (txtnameMashin.Text=="")
            {
                errorProvider_mashin.SetError(txtnameMashin, "اطلاعات این قسمت باید پرشود");
            }
            else if (txtrangMashin.Text=="")
            {
                errorProvider_mashin.SetError(txtrangMashin, "اطلاعات این قسمت باید پرشود");
            }
            else if (txtkarkhaneSazande.Text=="")
            {
                errorProvider_mashin.SetError(txtkarkhaneSazande, "اطلاعات این قسمت باید پرشود");
            }
            else if (txtmahaleTolid.Text=="")
            {
                errorProvider_mashin.SetError(txtmahaleTolid, "اطلاعات این قسمت باید پرشود");
            }
            else
            {
                m.idmashin =Convert.ToInt32(txtidmashin.Text);
                m.nameMashin = txtnameMashin.Text;
                m.rangMashin = txtrangMashin.Text;
                m.karkhaneMashin = txtkarkhaneSazande.Text;
                m.mahaletolid = txtmahaleTolid.Text;
                m.tozihat = txttozihat.Text;
                query.insert("insert into tblMashin (idmashin,nameMashin,rangMashin,karkhaneMashin,mahaletolid,tozihat)values(@idmashin,@nameMashin,@rangMashin,@karkhaneMashin,@mahaletolid,@tozihat)", m);
                MessageBox.Show("اطلاعات ثبت شد");
                errorProvider_mashin.SetError(txtidmashin, "");
                txtidmashin.Text = "";
                errorProvider_mashin.SetError(txtkarkhaneSazande, "");
                txtkarkhaneSazande.Text = "";
                errorProvider_mashin.SetError(txtmahaleTolid, "");
                txtmahaleTolid.Text = "";
                errorProvider_mashin.SetError(txtnameMashin, "");
                txtnameMashin.Text = "";
                errorProvider_mashin.SetError(txtrangMashin, "");
                txtrangMashin.Text = "";
                txttozihat.Text = "";
                frmMashin_Load(null, null);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مایل به حذف هستید؟","حذف",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                m.idmashin =Convert.ToInt32(dataGridView_mashin.CurrentRow.Cells[0].Value.ToString());
                query.delete("delete from tblMashin where idmashin=@idmashin",m);
                frmMashin_Load(null, null);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            txtidmashin.Text = dataGridView_mashin.CurrentRow.Cells[0].Value.ToString();
            txtnameMashin.Text = dataGridView_mashin.CurrentRow.Cells[1].Value.ToString();
            txtrangMashin.Text = dataGridView_mashin.CurrentRow.Cells[2].Value.ToString();
            txtkarkhaneSazande.Text = dataGridView_mashin.CurrentRow.Cells[3].Value.ToString();
            txtmahaleTolid.Text = dataGridView_mashin.CurrentRow.Cells[4].Value.ToString();
            txttozihat.Text = dataGridView_mashin.CurrentRow.Cells[5].Value.ToString();
            btnadd.Enabled = false;
            btndelete.Enabled = false;
            btnsabt.Enabled = true;
        }

        private void btnsabt_Click(object sender, EventArgs e)
        {
            m.idmashin = Convert.ToInt32(txtidmashin.Text);
            m.nameMashin = txtnameMashin.Text;
            m.rangMashin = txtrangMashin.Text;
            m.karkhaneMashin = txtkarkhaneSazande.Text;
            m.mahaletolid = txtmahaleTolid.Text;
            m.tozihat = txttozihat.Text;
            query.edit("update tblMashin set idmashin=@idmashin,nameMashin=@nameMashin,rangMashin=@rangMashin,karkhaneMashin=@karkhaneMashin,mahaletolid=@mahaletolid,tozihat=@tozihat where idmashin=@idmashin", m);
            MessageBox.Show("اطلاعات ویرایش شد");
            btnsabt.Enabled = false;
            btndelete.Enabled = true;
            btnadd.Enabled = true;
            txtrangMashin.Text = "";
            txttozihat.Text = "";
            txtnameMashin.Text = "";
            txtidmashin.Text = "";
            txtkarkhaneSazande.Text = "";
            txtmahaleTolid.Text = "";
            frmMashin_Load(null, null);

        }
      
    }
}
