namespace ProjectEntity
{
    partial class YetkiliSifreEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YetkiliSifreEkrani));
            this.label2 = new System.Windows.Forms.Label();
            this.btn_yetkiliGiris = new System.Windows.Forms.Button();
            this.pct_yetkiliLock = new System.Windows.Forms.PictureBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pct_yetkiliLock)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(133, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Şifre";
            // 
            // btn_yetkiliGiris
            // 
            this.btn_yetkiliGiris.Location = new System.Drawing.Point(137, 124);
            this.btn_yetkiliGiris.Name = "btn_yetkiliGiris";
            this.btn_yetkiliGiris.Size = new System.Drawing.Size(325, 23);
            this.btn_yetkiliGiris.TabIndex = 17;
            this.btn_yetkiliGiris.Text = "Yetkili Girişi";
            this.btn_yetkiliGiris.UseVisualStyleBackColor = true;
            this.btn_yetkiliGiris.Click += new System.EventHandler(this.btn_yetkiliGiris_Click);
            // 
            // pct_yetkiliLock
            // 
            this.pct_yetkiliLock.Image = ((System.Drawing.Image)(resources.GetObject("pct_yetkiliLock.Image")));
            this.pct_yetkiliLock.Location = new System.Drawing.Point(31, 44);
            this.pct_yetkiliLock.Name = "pct_yetkiliLock";
            this.pct_yetkiliLock.Size = new System.Drawing.Size(96, 103);
            this.pct_yetkiliLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_yetkiliLock.TabIndex = 16;
            this.pct_yetkiliLock.TabStop = false;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(271, 83);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(191, 20);
            this.txt_sifre.TabIndex = 15;
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(271, 44);
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(191, 20);
            this.txt_kullaniciAdi.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // YetkiliSifreEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 189);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_yetkiliGiris);
            this.Controls.Add(this.pct_yetkiliLock);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kullaniciAdi);
            this.Controls.Add(this.label1);
            this.Name = "YetkiliSifreEkrani";
            this.Text = "Yetkili Giriş Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.pct_yetkiliLock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_yetkiliGiris;
        private System.Windows.Forms.PictureBox pct_yetkiliLock;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_kullaniciAdi;
        private System.Windows.Forms.Label label1;
    }
}

