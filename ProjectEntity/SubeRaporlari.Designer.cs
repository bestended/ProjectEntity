namespace ProjectEntity
{
    partial class SubeRaporlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubeRaporlari));
            this.grp_aracBilgileri = new System.Windows.Forms.GroupBox();
            this.dgw_subeRapor = new System.Windows.Forms.DataGridView();
            this.txt_subeAdi = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_subeCalisanMüsteri = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_clisanSayiSiralama = new System.Windows.Forms.Button();
            this.txt_subeAdi1 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_calisanIsimArabaAd = new System.Windows.Forms.Button();
            this.grp_aracBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_subeRapor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_aracBilgileri
            // 
            this.grp_aracBilgileri.Controls.Add(this.dgw_subeRapor);
            this.grp_aracBilgileri.Location = new System.Drawing.Point(635, 12);
            this.grp_aracBilgileri.Name = "grp_aracBilgileri";
            this.grp_aracBilgileri.Size = new System.Drawing.Size(269, 397);
            this.grp_aracBilgileri.TabIndex = 27;
            this.grp_aracBilgileri.TabStop = false;
            this.grp_aracBilgileri.Text = "Şube Bilgi Tablosu";
            // 
            // dgw_subeRapor
            // 
            this.dgw_subeRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_subeRapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_subeRapor.Location = new System.Drawing.Point(3, 16);
            this.dgw_subeRapor.Name = "dgw_subeRapor";
            this.dgw_subeRapor.Size = new System.Drawing.Size(263, 378);
            this.dgw_subeRapor.TabIndex = 0;
            // 
            // txt_subeAdi
            // 
            this.txt_subeAdi.Location = new System.Drawing.Point(77, 72);
            this.txt_subeAdi.Name = "txt_subeAdi";
            this.txt_subeAdi.Size = new System.Drawing.Size(369, 20);
            this.txt_subeAdi.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // btn_subeCalisanMüsteri
            // 
            this.btn_subeCalisanMüsteri.BackColor = System.Drawing.Color.IndianRed;
            this.btn_subeCalisanMüsteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_subeCalisanMüsteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_subeCalisanMüsteri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_subeCalisanMüsteri.Location = new System.Drawing.Point(77, 28);
            this.btn_subeCalisanMüsteri.Name = "btn_subeCalisanMüsteri";
            this.btn_subeCalisanMüsteri.Size = new System.Drawing.Size(369, 38);
            this.btn_subeCalisanMüsteri.TabIndex = 32;
            this.btn_subeCalisanMüsteri.Text = "Adı girilen şubedeki çalışan isimleri ve müşteri adları";
            this.btn_subeCalisanMüsteri.UseVisualStyleBackColor = false;
            this.btn_subeCalisanMüsteri.Click += new System.EventHandler(this.btn_subeCalisanMüsteri_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // btn_clisanSayiSiralama
            // 
            this.btn_clisanSayiSiralama.BackColor = System.Drawing.Color.IndianRed;
            this.btn_clisanSayiSiralama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clisanSayiSiralama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_clisanSayiSiralama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_clisanSayiSiralama.Location = new System.Drawing.Point(77, 111);
            this.btn_clisanSayiSiralama.Name = "btn_clisanSayiSiralama";
            this.btn_clisanSayiSiralama.Size = new System.Drawing.Size(369, 38);
            this.btn_clisanSayiSiralama.TabIndex = 35;
            this.btn_clisanSayiSiralama.Text = "Çalışan sayısına göre şubeleri sıralama";
            this.btn_clisanSayiSiralama.UseVisualStyleBackColor = false;
            this.btn_clisanSayiSiralama.Click += new System.EventHandler(this.btn_clisanSayiSiralama_Click);
            // 
            // txt_subeAdi1
            // 
            this.txt_subeAdi1.Location = new System.Drawing.Point(77, 223);
            this.txt_subeAdi1.Name = "txt_subeAdi1";
            this.txt_subeAdi1.Size = new System.Drawing.Size(369, 20);
            this.txt_subeAdi1.TabIndex = 40;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 179);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // btn_calisanIsimArabaAd
            // 
            this.btn_calisanIsimArabaAd.BackColor = System.Drawing.Color.IndianRed;
            this.btn_calisanIsimArabaAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calisanIsimArabaAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_calisanIsimArabaAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_calisanIsimArabaAd.Location = new System.Drawing.Point(77, 179);
            this.btn_calisanIsimArabaAd.Name = "btn_calisanIsimArabaAd";
            this.btn_calisanIsimArabaAd.Size = new System.Drawing.Size(369, 38);
            this.btn_calisanIsimArabaAd.TabIndex = 38;
            this.btn_calisanIsimArabaAd.Text = "Adı girilen şubedeki çalışan isimleri  ve araba adları";
            this.btn_calisanIsimArabaAd.UseVisualStyleBackColor = false;
            this.btn_calisanIsimArabaAd.Click += new System.EventHandler(this.btn_calisanIsimArabaAd_Click);
            // 
            // SubeRaporlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.txt_subeAdi1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_calisanIsimArabaAd);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_clisanSayiSiralama);
            this.Controls.Add(this.txt_subeAdi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_subeCalisanMüsteri);
            this.Controls.Add(this.grp_aracBilgileri);
            this.Name = "SubeRaporlari";
            this.Text = "SubeRaporlari";
            this.grp_aracBilgileri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_subeRapor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_aracBilgileri;
        private System.Windows.Forms.DataGridView dgw_subeRapor;
        private System.Windows.Forms.TextBox txt_subeAdi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_subeCalisanMüsteri;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_clisanSayiSiralama;
        private System.Windows.Forms.TextBox txt_subeAdi1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_calisanIsimArabaAd;
    }
}