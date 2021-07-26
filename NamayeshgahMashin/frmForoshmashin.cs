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
    public partial class frmForoshmashin : Form
    {
        foroshMadhinQuery query = new foroshMadhinQuery();
        mashinQuery mashin = new mashinQuery();
        masolforoshQuery masolforosh = new masolforoshQuery();
        moshtariQuery moshtari = new moshtariQuery();
        foroshMashin f = new foroshMashin();
        public frmForoshmashin()
        {
            InitializeComponent();
        }
        private void frmForoshmashin_Load(object sender, EventArgs e)
        {
            btnsabt.Enabled = false;
            comboBoxIdMashin.DataSource = mashin.Allmashin();
            comboBoxIdMashin.ValueMember = "IdMashin";
          

            comboBoxIdMoshtari.DataSource = moshtari.Allmoshtari();
            comboBoxIdMoshtari.ValueMember = "IdMoshtari";

            comboBoxIdmsolForosh.DataSource = masolforosh.Allmasolforosh();
            comboBoxIdmsolForosh.ValueMember = "IdMasolforosh";

            dataGridView_foroshmashin.DataSource = query.AllforoshMashin();
            dataGridView_foroshmashin.Columns[0].HeaderText = "کد شناسه فروش ماشین";
            dataGridView_foroshmashin.Columns[1].HeaderText = "کد شناسه مسئول فروش";
            dataGridView_foroshmashin.Columns[2].HeaderText = "کد شناسه مشتری";
            dataGridView_foroshmashin.Columns[3].HeaderText = "کد شناسه ماشین";
            dataGridView_foroshmashin.Columns[4].HeaderText = "قیمت خودرو";
            dataGridView_foroshmashin.Columns[5].HeaderText = "تاریخ فروش";
            dataGridView_foroshmashin.Columns[6].HeaderText = "توضیحات";
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtidForoshmashin.Text=="")
            {
                errorProviderForoshmafhin.SetError(txtidForoshmashin, "اطلاعات این قسمت باید پرشود");
            }
            else if (comboBoxIdmsolForosh.Text=="")
            {
                errorProviderForoshmafhin.SetError(comboBoxIdmsolForosh, "اطلاعات این قسمت باید پرشود");
            }
            else if (comboBoxIdMoshtari.Text=="")
            {
                errorProviderForoshmafhin.SetError(comboBoxIdMoshtari, "اطلاعات این قسمت باید پرشود");
            }
            else if (comboBoxIdMashin.Text=="")
            {
                errorProviderForoshmafhin.SetError(comboBoxIdMashin, "اطلاعات این قسمت باید پرشود");
            }
            else if (txtghaimat.Text=="")
            {
                errorProviderForoshmafhin.SetError(txtghaimat, "اطلاعات این قسمت باید پرشود");
            }
            else if (maskedTarikhforosh.MaskCompleted==false)
            {
                errorProviderForoshmafhin.SetError(maskedTarikhforosh, "اطلاعات این قسمت باید پرشود");
            }
            else
            {
                f.IdForoshmashin = Convert.ToInt32(txtidForoshmashin.Text);
                f.IdMasolForosh = Convert.ToInt32(comboBoxIdmsolForosh.Text);
                f.IdMoshtari = Convert.ToInt32(comboBoxIdMoshtari.Text);
                f.IdMashin = comboBoxIdMashin.Text;
                f.Ghaimat = Convert.ToSingle(txtghaimat.Text);
                f.Tarikhforosh = maskedTarikhforosh.Text;
                f.Tozihat = txtTozihat.Text;
                query.insert("insert into tblForoshmashin(IdForoshmashin,IdMasolForosh,IdMoshtari,IdMashin,Ghaimat,Tarikhforosh,Tozihat)values(@IdForoshmashin,@IdMasolForosh,@IdMoshtari,@IdMashin,@Ghaimat,@Tarikhforosh,@Tozihat)", f);
                MessageBox.Show("اطلاعات ثبت شد");
                errorProviderForoshmafhin.SetError(txtidForoshmashin, "");
                txtidForoshmashin.Text = "";
                errorProviderForoshmafhin.SetError(comboBoxIdmsolForosh, "");
                comboBoxIdmsolForosh.Text = "";
                errorProviderForoshmafhin.SetError(comboBoxIdMoshtari, "");
                comboBoxIdMoshtari.Text = "";
                errorProviderForoshmafhin.SetError(comboBoxIdMashin, "");
                comboBoxIdMashin.Text = "";
                errorProviderForoshmafhin.SetError(txtghaimat, "");
                txtghaimat.Text = "";
                errorProviderForoshmafhin.SetError(maskedTarikhforosh, "");
                maskedTarikhforosh.Text = "";
                errorProviderForoshmafhin.SetError(txtTozihat, "");
                txtTozihat.Text = "";
                frmForoshmashin_Load(null, null);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            txtidForoshmashin.Text = dataGridView_foroshmashin.CurrentRow.Cells[0].Value.ToString();
            comboBoxIdmsolForosh.Text = dataGridView_foroshmashin.CurrentRow.Cells[1].Value.ToString();
            comboBoxIdMoshtari.Text = dataGridView_foroshmashin.CurrentRow.Cells[2].Value.ToString();
            comboBoxIdMashin.Text = dataGridView_foroshmashin.CurrentRow.Cells[3].Value.ToString();
            txtghaimat.Text = dataGridView_foroshmashin.CurrentRow.Cells[4].Value.ToString();
            maskedTarikhforosh.Text = dataGridView_foroshmashin.CurrentRow.Cells[5].Value.ToString();
            txtTozihat.Text = dataGridView_foroshmashin.CurrentRow.Cells[6].Value.ToString();
            btnadd.Enabled = false;
            btndelete.Enabled = false;
            btnsabt.Enabled = true;

        }

        private void btnsabt_Click(object sender, EventArgs e)
        {
            f.IdForoshmashin = Convert.ToInt32(txtidForoshmashin.Text);
            f.IdMasolForosh = Convert.ToInt32(comboBoxIdmsolForosh.Text);
            f.IdMoshtari = Convert.ToInt32(comboBoxIdMoshtari.Text);
            f.IdMashin = comboBoxIdMashin.Text;
            f.Ghaimat = Convert.ToSingle(txtghaimat.Text);
            f.Tarikhforosh = maskedTarikhforosh.Text;
            f.Tozihat = txtTozihat.Text;
            query.edit("update tblForoshmashin set IdForoshmashin=@IdForoshmashin,IdMasolForosh=@IdMasolForosh" +
                ",IdMoshtari=@IdMoshtari,IdMashin=@IdMashin,Ghaimat=@Ghaimat,Tarikhforosh=@Tarikhforosh,Tozihat=@Tozihat where IdForoshmashin=@IdForoshmashin", f);
            MessageBox.Show("اطلاعات ویرایش شد");
            txtidForoshmashin.Text = "";
            comboBoxIdmsolForosh.Text = "";
            txtTozihat.Text = "";
            maskedTarikhforosh.Text = "";
            comboBoxIdMashin.Text = "";
            frmForoshmashin_Load(null, null);
            btnadd.Enabled = true;
            btndelete.Enabled = true;
            btnsabt.Enabled = false;

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مایل به حذف هستید؟", "حذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                f.IdForoshmashin = Convert.ToInt32(dataGridView_foroshmashin.CurrentRow.Cells[0].Value.ToString());
                query.delete("delete from tblForoshmashin where IdForoshmashin=@IdForoshmashin",f);
                frmForoshmashin_Load(null, null);

            }
        }
    }
}
