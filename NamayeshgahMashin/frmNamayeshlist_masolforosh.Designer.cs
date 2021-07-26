namespace NamayeshgahMashin
{
    partial class frmNamayeshlist_masolforosh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNamayeshlist_masolforosh));
            this.dataGridView_masolforosh = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtserch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_masolforosh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_masolforosh
            // 
            this.dataGridView_masolforosh.AllowUserToAddRows = false;
            this.dataGridView_masolforosh.AllowUserToDeleteRows = false;
            this.dataGridView_masolforosh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_masolforosh.Location = new System.Drawing.Point(3, 56);
            this.dataGridView_masolforosh.Name = "dataGridView_masolforosh";
            this.dataGridView_masolforosh.ReadOnly = true;
            this.dataGridView_masolforosh.Size = new System.Drawing.Size(490, 195);
            this.dataGridView_masolforosh.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(320, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 34);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtserch
            // 
            this.txtserch.Location = new System.Drawing.Point(180, 12);
            this.txtserch.Name = "txtserch";
            this.txtserch.Size = new System.Drawing.Size(134, 20);
            this.txtserch.TabIndex = 6;
            this.txtserch.TextChanged += new System.EventHandler(this.txtserch_TextChanged);
            // 
            // frmNamayeshlist_masolforosh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 253);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtserch);
            this.Controls.Add(this.dataGridView_masolforosh);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNamayeshlist_masolforosh";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نمایش لیست مسئول فروش";
            this.Load += new System.EventHandler(this.frmNamayeshlist_masolforosh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_masolforosh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_masolforosh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtserch;
    }
}