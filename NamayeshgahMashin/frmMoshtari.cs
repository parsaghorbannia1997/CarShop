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
    public partial class frmMoshtari : Form
    {
        moshtariQuery query = new moshtariQuery();
        Moshtari moshtari = new Moshtari();
        public frmMoshtari()
        {
            InitializeComponent();
        }

        private void frmMoshtari_Load(object sender, EventArgs e)
        {
            dataGridView_moshtari.DataSource = query.Allmoshtari();
            dataGridView_moshtari.Columns[0].HeaderText = "کد مشتری";
            dataGridView_moshtari.Columns[1].HeaderText = " نام";
            dataGridView_moshtari.Columns[2].HeaderText = "نام خانوادگی";
            dataGridView_moshtari.Columns[3].HeaderText = "موبایل";
            dataGridView_moshtari.Columns[4].HeaderText = "آدرس";
        
            btnsabt.Enabled = false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtidMoshtari.Text=="")
            {
             
                errorProviderMoshtari.SetError(txtidMoshtari, "اطلاعات این قسمت باید پرشود");
             
            }
            else if(txtfirstname.Text=="")
            {
           
                errorProviderMoshtari.SetError(txtfirstname, "اطلاعات این قسمت باید پرشود");
             
            }
            else if (txtlastname.Text=="")
            {
           
                errorProviderMoshtari.SetError(txtlastname, "اطلاعات این قسمت باید پرشود");
           
            }

            else if (txtmobile.Text=="")
            {
                errorProviderMoshtari.SetError(txtmobile, "اطلاعات این قسمت باید پرشود");
            }
            else if (txtaddress.Text=="")
            {
                errorProviderMoshtari.SetError(txtaddress, "اطلاعات این قسمت باید پرشود");
            }
            else
            {
                moshtari.idmoshtari = Convert.ToInt32(txtidMoshtari.Text);
                moshtari.firstname = txtfirstname.Text;
                moshtari.lastname = txtlastname.Text;
                moshtari.mobile = txtmobile.Text;
                moshtari.address = txtaddress.Text;
                query.insert("insert into tblMoshtari (idmoshtari,firstname,lastname,mobile,address)values(@idmoshtari,@firstname,@lastname,@mobile,@address)", moshtari);
                MessageBox.Show("موفقیت");
                frmMoshtari_Load(null, null);
                errorProviderMoshtari.SetError(txtidMoshtari, "");
                errorProviderMoshtari.SetError(txtfirstname, "");
                errorProviderMoshtari.SetError(txtlastname, "");
                txtaddress.Text = "";
                txtfirstname.Text = "";
                txtidMoshtari.Text = "";
                txtlastname.Text = "";
                txtmobile.Text = "";
            }
        }
        private void btnsabt_Click(object sender, EventArgs e)
        {
            moshtari.idmoshtari = Convert.ToInt32(txtidMoshtari.Text);
            moshtari.firstname = txtfirstname.Text;
            moshtari.lastname = txtlastname.Text;
            moshtari.mobile = txtmobile.Text;
            moshtari.address = txtaddress.Text;
            query.edit("update tblMoshtari set idmoshtari=@idmoshtari,firstname=@firstname,lastname=@lastname,mobile=@mobile,address=@address where idmoshtari=@idmoshtari", moshtari);
            MessageBox.Show("موفقیت");
            frmMoshtari_Load(null, null);
            btnadd.Enabled = true;
            btnsabt.Enabled = false;
            btndelete.Enabled = true;
        }
        private void btnedit_Click(object sender, EventArgs e)
        {
            txtidMoshtari.Text = dataGridView_moshtari.CurrentRow.Cells[0].Value.ToString();
            txtfirstname.Text = dataGridView_moshtari.CurrentRow.Cells[1].Value.ToString();
            txtlastname.Text = dataGridView_moshtari.CurrentRow.Cells[2].Value.ToString();
            txtmobile.Text = dataGridView_moshtari.CurrentRow.Cells[3].Value.ToString();
            txtaddress.Text = dataGridView_moshtari.CurrentRow.Cells[4].Value.ToString();
            btnadd.Enabled = false;
            btnedit.Enabled = true;
            btnsabt.Enabled = true;
            btndelete.Enabled = false;
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ایا مایل به حدف هستید؟","حذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                moshtari.idmoshtari = Convert.ToInt32(dataGridView_moshtari.CurrentRow.Cells[0].Value.ToString());
                query.delete("delete from tblMoshtari where idmoshtari=@idmoshtari", moshtari);
                frmMoshtari_Load(null, null);
            }
        }
    }
}
