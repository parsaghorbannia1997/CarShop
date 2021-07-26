namespace NamayeshgahMashin
{
    partial class frmNamayeshlist_Mashin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNamayeshlist_Mashin));
            this.dataGridView_mashin = new System.Windows.Forms.DataGridView();
            this.txtserch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mashin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_mashin
            // 
            this.dataGridView_mashin.AllowUserToAddRows = false;
            this.dataGridView_mashin.AllowUserToDeleteRows = false;
            this.dataGridView_mashin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_mashin.Location = new System.Drawing.Point(1, 64);
            this.dataGridView_mashin.Name = "dataGridView_mashin";
            this.dataGridView_mashin.ReadOnly = true;
            this.dataGridView_mashin.Size = new System.Drawing.Size(597, 163);
            this.dataGridView_mashin.TabIndex = 0;
            // 
            // txtserch
            // 
            this.txtserch.Location = new System.Drawing.Point(260, 22);
            this.txtserch.Name = "txtserch";
            this.txtserch.Size = new System.Drawing.Size(134, 20);
            this.txtserch.TabIndex = 2;
            this.txtserch.TextChanged += new System.EventHandler(this.txtserch_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(400, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 34);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmNamayeshlist_Mashin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 231);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtserch);
            this.Controls.Add(this.dataGridView_mashin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNamayeshlist_Mashin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نمایش لیست ماشین";
            this.Load += new System.EventHandler(this.frmNamayeshlist_Mashin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mashin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_mashin;
        private System.Windows.Forms.TextBox txtserch;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}