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
    public partial class frmMasolforosh : Form
    {
        masolforoshQuery query = new masolforoshQuery();
        Masolforosh foroshande = new Masolforosh();
        public frmMasolforosh()
        {
            InitializeComponent();
        }

        private void frmMasolforosh_Load(object sender, EventArgs e)
        {
            dataGridView_masolforosh.DataSource = query.Allmasolforosh();
            dataGridView_masolforosh.Columns[0].HeaderText = "کد مسئول فروش";
            dataGridView_masolforosh.Columns[1].HeaderText = "نام";
            dataGridView_masolforosh.Columns[2].HeaderText = "نام خانوادگی";
            dataGridView_masolforosh.Columns[3].HeaderText = "موبایل";
            dataGridView_masolforosh.Columns[4].HeaderText = "آدرس";
            btnsabt.Enabled = false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtidMasolforosh.Text=="")
            {
                errorProviderMasolforosh.SetError(txtidMasolforosh, "اطلاعات این قسمت باید پرشود");
            }
            else if (txtfirstname.Text=="")
            {
                errorProviderMasolforosh.SetError(txtfirstname, "اطلاعات این قسمت باید پرشود");
            }
            else if (txtlastname.Text=="")
            {
                errorProviderMasolforosh.SetError(txtlastname, "اطلاعات این قسمت باید پرشود");
            }
            else if (txtmobile.Text=="")
            {
                errorProviderMasolforosh.SetError(txtmobile, "اطلاعات این قسمت باید پرشود");
            }
            else if (txtaddress.Text=="")
            {
                errorProviderMasolforosh.SetError(txtaddress, "اطلاعات این قسمت باید پرشود");
            }
            else
            {
                foroshande.idmasolforosh = Convert.ToInt32(txtidMasolforosh.Text);
                foroshande.firstname = txtfirstname.Text;
                foroshande.lastname = txtlastname.Text;
                foroshande.mobile = txtmobile.Text;
                foroshande.address = txtaddress.Text;
                query.insert("insert into tblMasolforosh(idmasolforosh,firstname,lastname,mobile,adress)values(@idmasolforosh,@firstname,@lastname,@mobile,@adress)", foroshande);
                MessageBox.Show("ثبت شد");
                errorProviderMasolforosh.SetError(txtaddress, "");
                errorProviderMasolforosh.SetError(txtfirstname, "");
                errorProviderMasolforosh.SetError(txtidMasolforosh, "");
                errorProviderMasolforosh.SetError(txtlastname, "");
                errorProviderMasolforosh.SetError(txtmobile, "");
                txtaddress.Text = "";
                txtfirstname.Text = "";
                txtidMasolforosh.Text = "";
                txtlastname.Text = "";
                txtmobile.Text = "";
                frmMasolforosh_Load(null, null);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            txtidMasolforosh.Text = dataGridView_masolforosh.CurrentRow.Cells[0].Value.ToString();
            txtfirstname.Text = dataGridView_masolforosh.CurrentRow.Cells[1].Value.ToString();
            txtlastname.Text = dataGridView_masolforosh.CurrentRow.Cells[2].Value.ToString();
            txtmobile.Text = dataGridView_masolforosh.CurrentRow.Cells[3].Value.ToString();
            txtaddress.Text = dataGridView_masolforosh.CurrentRow.Cells[4].Value.ToString();
            btnadd.Enabled = false;
            btnsabt.Enabled = true;
            btndelete.Enabled = false;
        }

        private void btnsabt_Click(object sender, EventArgs e)
        {
            foroshande.idmasolforosh = Convert.ToInt32(txtidMasolforosh.Text);
            foroshande.firstname = txtfirstname.Text;
            foroshande.lastname = txtlastname.Text;
            foroshande.mobile = txtmobile.Text;
            foroshande.address = txtaddress.Text;
            query.edit("update tblMasolforosh set idmasolforosh=@idmasolforosh,firstname=@firstname,lastname=@lastname,mobile=@mobile,adress=@adress where idmasolforosh=@idmasolforosh", foroshande);
            MessageBox.Show("ویرایش شد");
            txtaddress.Text = "";
            txtfirstname.Text = "";
            txtidMasolforosh.Text = "";
            txtlastname.Text = "";
            txtmobile.Text = "";
            frmMasolforosh_Load(null, null);
            btnadd.Enabled = true;
            btndelete.Enabled = true;
            btnsabt.Enabled = false;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ایا مایل به حدف هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foroshande.idmasolforosh =Convert.ToInt32(dataGridView_masolforosh.CurrentRow.Cells[0].Value.ToString());
                query.delete("delete from tblMasolforosh where idmasolforosh=@idmasolforosh", foroshande);
                frmMasolforosh_Load(null, null);
            }
           
           
        }
    }
}
