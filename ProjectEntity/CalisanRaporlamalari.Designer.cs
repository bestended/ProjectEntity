namespace ProjectEntity
{
    partial class CalisanRaporlamalari
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
            this.txt_calisanSatisAd = new System.Windows.Forms.TextBox();
            this.btn_calisanSatisAd = new System.Windows.Forms.Button();
            this.btn_clisanMaasSiralama = new System.Windows.Forms.Button();
            this.txt_calisanAdi = new System.Windows.Forms.TextBox();
            this.btn_subeCalisanMüsteri = new System.Windows.Forms.Button();
            this.grp_calisanBilgileri = new System.Windows.Forms.GroupBox();
            this.dgw_calisanRapor = new System.Windows.Forms.DataGridView();
            this.btn_maasGrupla = new System.Windows.Forms.Button();
            this.grp_calisanBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_calisanRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_calisanSatisAd
            // 
            this.txt_calisanSatisAd.Location = new System.Drawing.Point(12, 207);
            this.txt_calisanSatisAd.Name = "txt_calisanSatisAd";
            this.txt_calisanSatisAd.Size = new System.Drawing.Size(369, 20);
            this.txt_calisanSatisAd.TabIndex = 46;
            // 
            // btn_calisanSatisAd
            // 
            this.btn_calisanSatisAd.BackColor = System.Drawing.Color.IndianRed;
            this.btn_calisanSatisAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calisanSatisAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_calisanSatisAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_calisanSatisAd.Location = new System.Drawing.Point(12, 163);
            this.btn_calisanSatisAd.Name = "btn_calisanSatisAd";
            this.btn_calisanSatisAd.Size = new System.Drawing.Size(369, 38);
            this.btn_calisanSatisAd.TabIndex = 45;
            this.btn_calisanSatisAd.Text = "Adı girilen çalışanların hangi şubeden hangi arabayı sattığı";
            this.btn_calisanSatisAd.UseVisualStyleBackColor = false;
            this.btn_calisanSatisAd.Click += new System.EventHandler(this.btn_calisanSatisAd_Click);
            // 
            // btn_clisanMaasSiralama
            // 
            this.btn_clisanMaasSiralama.BackColor = System.Drawing.Color.IndianRed;
            this.btn_clisanMaasSiralama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clisanMaasSiralama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_clisanMaasSiralama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_clisanMaasSiralama.Location = new System.Drawing.Point(12, 95);
            this.btn_clisanMaasSiralama.Name = "btn_clisanMaasSiralama";
            this.btn_clisanMaasSiralama.Size = new System.Drawing.Size(369, 38);
            this.btn_clisanMaasSiralama.TabIndex = 44;
            this.btn_clisanMaasSiralama.Text = "Çalışan maaşlarına göre sıralama";
            this.btn_clisanMaasSiralama.UseVisualStyleBackColor = false;
            this.btn_clisanMaasSiralama.Click += new System.EventHandler(this.btn_clisanMaasSiralama_Click);
            // 
            // txt_calisanAdi
            // 
            this.txt_calisanAdi.Location = new System.Drawing.Point(12, 56);
            this.txt_calisanAdi.Name = "txt_calisanAdi";
            this.txt_calisanAdi.Size = new System.Drawing.Size(369, 20);
            this.txt_calisanAdi.TabIndex = 43;
            // 
            // btn_subeCalisanMüsteri
            // 
            this.btn_subeCalisanMüsteri.BackColor = System.Drawing.Color.IndianRed;
            this.btn_subeCalisanMüsteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_subeCalisanMüsteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_subeCalisanMüsteri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_subeCalisanMüsteri.Location = new System.Drawing.Point(12, 12);
            this.btn_subeCalisanMüsteri.Name = "btn_subeCalisanMüsteri";
            this.btn_subeCalisanMüsteri.Size = new System.Drawing.Size(369, 38);
            this.btn_subeCalisanMüsteri.TabIndex = 42;
            this.btn_subeCalisanMüsteri.Text = "Adı girilen çalışan isimleri ve şube adları";
            this.btn_subeCalisanMüsteri.UseVisualStyleBackColor = false;
            this.btn_subeCalisanMüsteri.Click += new System.EventHandler(this.btn_subeCalisanMüsteri_Click);
            // 
            // grp_calisanBilgileri
            // 
            this.grp_calisanBilgileri.Controls.Add(this.dgw_calisanRapor);
            this.grp_calisanBilgileri.Location = new System.Drawing.Point(647, 27);
            this.grp_calisanBilgileri.Name = "grp_calisanBilgileri";
            this.grp_calisanBilgileri.Size = new System.Drawing.Size(269, 397);
            this.grp_calisanBilgileri.TabIndex = 41;
            this.grp_calisanBilgileri.TabStop = false;
            this.grp_calisanBilgileri.Text = "Çalışan Bilgi Tablosu";
            // 
            // dgw_calisanRapor
            // 
            this.dgw_calisanRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_calisanRapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_calisanRapor.Location = new System.Drawing.Point(3, 16);
            this.dgw_calisanRapor.Name = "dgw_calisanRapor";
            this.dgw_calisanRapor.Size = new System.Drawing.Size(263, 378);
            this.dgw_calisanRapor.TabIndex = 0;
            // 
            // btn_maasGrupla
            // 
            this.btn_maasGrupla.BackColor = System.Drawing.Color.IndianRed;
            this.btn_maasGrupla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maasGrupla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_maasGrupla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_maasGrupla.Location = new System.Drawing.Point(12, 257);
            this.btn_maasGrupla.Name = "btn_maasGrupla";
            this.btn_maasGrupla.Size = new System.Drawing.Size(369, 38);
            this.btn_maasGrupla.TabIndex = 47;
            this.btn_maasGrupla.Text = "Çalışan maaşlarına göre  grupla";
            this.btn_maasGrupla.UseVisualStyleBackColor = false;
            this.btn_maasGrupla.Click += new System.EventHandler(this.btn_maasGrupla_Click);
            // 
            // CalisanRaporlamalari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.btn_maasGrupla);
            this.Controls.Add(this.txt_calisanSatisAd);
            this.Controls.Add(this.btn_calisanSatisAd);
            this.Controls.Add(this.btn_clisanMaasSiralama);
            this.Controls.Add(this.txt_calisanAdi);
            this.Controls.Add(this.btn_subeCalisanMüsteri);
            this.Controls.Add(this.grp_calisanBilgileri);
            this.Name = "CalisanRaporlamalari";
            this.Text = "CalisanRaporlamalari";
            this.grp_calisanBilgileri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_calisanRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_calisanSatisAd;
        private System.Windows.Forms.Button btn_calisanSatisAd;
        private System.Windows.Forms.Button btn_clisanMaasSiralama;
        private System.Windows.Forms.TextBox txt_calisanAdi;
        private System.Windows.Forms.Button btn_subeCalisanMüsteri;
        private System.Windows.Forms.GroupBox grp_calisanBilgileri;
        private System.Windows.Forms.DataGridView dgw_calisanRapor;
        private System.Windows.Forms.Button btn_maasGrupla;
    }
}