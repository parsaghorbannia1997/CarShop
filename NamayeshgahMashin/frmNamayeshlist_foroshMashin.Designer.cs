namespace NamayeshgahMashin
{
    partial class frmNamayeshlist_foroshMashin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNamayeshlist_foroshMashin));
            this.dataGridView_foroshmashin = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtserch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_foroshmashin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_foroshmashin
            // 
            this.dataGridView_foroshmashin.AllowUserToAddRows = false;
            this.dataGridView_foroshmashin.AllowUserToDeleteRows = false;
            this.dataGridView_foroshmashin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_foroshmashin.Location = new System.Drawing.Point(3, 52);
            this.dataGridView_foroshmashin.Name = "dataGridView_foroshmashin";
            this.dataGridView_foroshmashin.ReadOnly = true;
            this.dataGridView_foroshmashin.Size = new System.Drawing.Size(533, 181);
            this.dataGridView_foroshmashin.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(315, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 34);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtserch
            // 
            this.txtserch.Location = new System.Drawing.Point(160, 12);
            this.txtserch.Name = "txtserch";
            this.txtserch.Size = new System.Drawing.Size(149, 20);
            this.txtserch.TabIndex = 5;
            this.txtserch.TextChanged += new System.EventHandler(this.txtserch_TextChanged);
            // 
            // frmNamayeshlist_foroshMashin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 233);
            this.Controls.Add(this.txtserch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView_foroshmashin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNamayeshlist_foroshMashin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نمایش لیست فروش";
            this.Load += new System.EventHandler(this.frmNamayeshlist_foroshMashin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_foroshmashin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_foroshmashin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtserch;
    }
}