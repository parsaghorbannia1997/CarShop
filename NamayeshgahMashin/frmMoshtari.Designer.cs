namespace NamayeshgahMashin
{
    partial class frmMoshtari
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView_moshtari = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtidMoshtari = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsabt = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.errorProviderMoshtari = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_moshtari)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMoshtari)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_moshtari
            // 
            this.dataGridView_moshtari.AllowUserToAddRows = false;
            this.dataGridView_moshtari.AllowUserToDeleteRows = false;
            this.dataGridView_moshtari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_moshtari.Location = new System.Drawing.Point(0, 122);
            this.dataGridView_moshtari.Name = "dataGridView_moshtari";
            this.dataGridView_moshtari.ReadOnly = true;
            this.dataGridView_moshtari.Size = new System.Drawing.Size(549, 152);
            this.dataGridView_moshtari.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtaddress);
            this.groupBox1.Controls.Add(this.txtmobile);
            this.groupBox1.Controls.Add(this.txtlastname);
            this.groupBox1.Controls.Add(this.txtfirstname);
            this.groupBox1.Controls.Add(this.txtidMoshtari);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 95);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات مشتری";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(29, 66);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(298, 20);
            this.txtaddress.TabIndex = 1;
            // 
            // txtmobile
            // 
            this.txtmobile.Location = new System.Drawing.Point(374, 62);
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(100, 20);
            this.txtmobile.TabIndex = 1;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(29, 32);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(114, 20);
            this.txtlastname.TabIndex = 1;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(227, 32);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(100, 20);
            this.txtfirstname.TabIndex = 1;
            // 
            // txtidMoshtari
            // 
            this.txtidMoshtari.Location = new System.Drawing.Point(374, 32);
            this.txtidMoshtari.Name = "txtidMoshtari";
            this.txtidMoshtari.Size = new System.Drawing.Size(100, 20);
            this.txtidMoshtari.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "آدرس";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "نام خانوادگی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "موبایل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "کد مشتری";
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(374, 294);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 2;
            this.btnedit.Text = "ویرایش";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(455, 294);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "افزودن";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsabt
            // 
            this.btnsabt.Location = new System.Drawing.Point(293, 294);
            this.btnsabt.Name = "btnsabt";
            this.btnsabt.Size = new System.Drawing.Size(75, 23);
            this.btnsabt.TabIndex = 2;
            this.btnsabt.Text = "ثبت ویرایش";
            this.btnsabt.UseVisualStyleBackColor = true;
            this.btnsabt.Click += new System.EventHandler(this.btnsabt_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(212, 294);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "حذف";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // errorProviderMoshtari
            // 
            this.errorProviderMoshtari.ContainerControl = this;
            // 
            // frmMoshtari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 329);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsabt);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_moshtari);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMoshtari";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مشتری";
            this.Load += new System.EventHandler(this.frmMoshtari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_moshtari)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMoshtari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_moshtari;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtidMoshtari;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsabt;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.ErrorProvider errorProviderMoshtari;
    }
}