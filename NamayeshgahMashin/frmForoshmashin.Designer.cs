namespace NamayeshgahMashin
{
    partial class frmForoshmashin
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
            this.dataGridView_foroshmashin = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsabt = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtidForoshmashin = new System.Windows.Forms.TextBox();
            this.txtghaimat = new System.Windows.Forms.TextBox();
            this.txtTozihat = new System.Windows.Forms.TextBox();
            this.errorProviderForoshmafhin = new System.Windows.Forms.ErrorProvider(this.components);
            this.maskedTarikhforosh = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxIdmsolForosh = new System.Windows.Forms.ComboBox();
            this.comboBoxIdMoshtari = new System.Windows.Forms.ComboBox();
            this.comboBoxIdMashin = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_foroshmashin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderForoshmafhin)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_foroshmashin
            // 
            this.dataGridView_foroshmashin.AllowUserToAddRows = false;
            this.dataGridView_foroshmashin.AllowUserToDeleteRows = false;
            this.dataGridView_foroshmashin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_foroshmashin.Location = new System.Drawing.Point(1, 131);
            this.dataGridView_foroshmashin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView_foroshmashin.Name = "dataGridView_foroshmashin";
            this.dataGridView_foroshmashin.ReadOnly = true;
            this.dataGridView_foroshmashin.Size = new System.Drawing.Size(695, 146);
            this.dataGridView_foroshmashin.TabIndex = 0;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(347, 283);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(74, 23);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "حذف";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsabt
            // 
            this.btnsabt.Location = new System.Drawing.Point(429, 283);
            this.btnsabt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnsabt.Name = "btnsabt";
            this.btnsabt.Size = new System.Drawing.Size(74, 23);
            this.btnsabt.TabIndex = 4;
            this.btnsabt.Text = "ثبت ویرایش";
            this.btnsabt.UseVisualStyleBackColor = true;
            this.btnsabt.Click += new System.EventHandler(this.btnsabt_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(509, 283);
            this.btnedit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(74, 23);
            this.btnedit.TabIndex = 5;
            this.btnedit.Text = "ویرایش";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(591, 283);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(74, 23);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "افزودن";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(569, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "کد شناسه فروش ماشین";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "کد شناسه ماشین";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "کد شناسه مشتری";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "قیمت خودرو";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(569, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "توضیحات";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "تاریخ فروش";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "کدشناسه مسئول فروش";
            // 
            // txtidForoshmashin
            // 
            this.txtidForoshmashin.Location = new System.Drawing.Point(463, 12);
            this.txtidForoshmashin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtidForoshmashin.Name = "txtidForoshmashin";
            this.txtidForoshmashin.Size = new System.Drawing.Size(100, 20);
            this.txtidForoshmashin.TabIndex = 8;
            // 
            // txtghaimat
            // 
            this.txtghaimat.Location = new System.Drawing.Point(217, 38);
            this.txtghaimat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtghaimat.Name = "txtghaimat";
            this.txtghaimat.Size = new System.Drawing.Size(100, 20);
            this.txtghaimat.TabIndex = 8;
            // 
            // txtTozihat
            // 
            this.txtTozihat.Location = new System.Drawing.Point(12, 71);
            this.txtTozihat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTozihat.Multiline = true;
            this.txtTozihat.Name = "txtTozihat";
            this.txtTozihat.Size = new System.Drawing.Size(551, 41);
            this.txtTozihat.TabIndex = 8;
            // 
            // errorProviderForoshmafhin
            // 
            this.errorProviderForoshmafhin.ContainerControl = this;
            // 
            // maskedTarikhforosh
            // 
            this.maskedTarikhforosh.Location = new System.Drawing.Point(11, 38);
            this.maskedTarikhforosh.Mask = "0000/00/00";
            this.maskedTarikhforosh.Name = "maskedTarikhforosh";
            this.maskedTarikhforosh.Size = new System.Drawing.Size(100, 20);
            this.maskedTarikhforosh.TabIndex = 9;
            // 
            // comboBoxIdmsolForosh
            // 
            this.comboBoxIdmsolForosh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIdmsolForosh.FormattingEnabled = true;
            this.comboBoxIdmsolForosh.Location = new System.Drawing.Point(217, 11);
            this.comboBoxIdmsolForosh.Name = "comboBoxIdmsolForosh";
            this.comboBoxIdmsolForosh.Size = new System.Drawing.Size(101, 21);
            this.comboBoxIdmsolForosh.TabIndex = 10;
            // 
            // comboBoxIdMoshtari
            // 
            this.comboBoxIdMoshtari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIdMoshtari.FormattingEnabled = true;
            this.comboBoxIdMoshtari.Location = new System.Drawing.Point(12, 11);
            this.comboBoxIdMoshtari.Name = "comboBoxIdMoshtari";
            this.comboBoxIdMoshtari.Size = new System.Drawing.Size(101, 21);
            this.comboBoxIdMoshtari.TabIndex = 10;
            // 
            // comboBoxIdMashin
            // 
            this.comboBoxIdMashin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIdMashin.FormattingEnabled = true;
            this.comboBoxIdMashin.Location = new System.Drawing.Point(462, 38);
            this.comboBoxIdMashin.Name = "comboBoxIdMashin";
            this.comboBoxIdMashin.Size = new System.Drawing.Size(101, 21);
            this.comboBoxIdMashin.TabIndex = 10;
            // 
            // frmForoshmashin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 318);
            this.Controls.Add(this.comboBoxIdMashin);
            this.Controls.Add(this.comboBoxIdMoshtari);
            this.Controls.Add(this.comboBoxIdmsolForosh);
            this.Controls.Add(this.maskedTarikhforosh);
            this.Controls.Add(this.txtTozihat);
            this.Controls.Add(this.txtghaimat);
            this.Controls.Add(this.txtidForoshmashin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsabt);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dataGridView_foroshmashin);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmForoshmashin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فروش ماشین";
            this.Load += new System.EventHandler(this.frmForoshmashin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_foroshmashin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderForoshmafhin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_foroshmashin;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsabt;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtidForoshmashin;
        private System.Windows.Forms.TextBox txtghaimat;
        private System.Windows.Forms.TextBox txtTozihat;
        private System.Windows.Forms.ErrorProvider errorProviderForoshmafhin;
        private System.Windows.Forms.ComboBox comboBoxIdMashin;
        private System.Windows.Forms.ComboBox comboBoxIdMoshtari;
        private System.Windows.Forms.ComboBox comboBoxIdmsolForosh;
        private System.Windows.Forms.MaskedTextBox maskedTarikhforosh;
    }
}