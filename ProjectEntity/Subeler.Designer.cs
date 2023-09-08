namespace ProjectEntity
{
    partial class Subeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subeler));
            this.txt_biransAdi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_calisanlar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_arabaStok = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgw_subeler = new System.Windows.Forms.DataGridView();
            this.btn_tümListem = new System.Windows.Forms.Button();
            this.btn_arama = new System.Windows.Forms.Button();
            this.btn_silme = new System.Windows.Forms.Button();
            this.btn_güncelleme = new System.Windows.Forms.Button();
            this.btn_ekleme = new System.Windows.Forms.Button();
            this.btn_önceki = new System.Windows.Forms.Button();
            this.btn_sonraki = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_subeler)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_biransAdi
            // 
            this.txt_biransAdi.Location = new System.Drawing.Point(178, 50);
            this.txt_biransAdi.Name = "txt_biransAdi";
            this.txt_biransAdi.Size = new System.Drawing.Size(218, 20);
            this.txt_biransAdi.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(32, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "Branş Adı";
            // 
            // txt_calisanlar
            // 
            this.txt_calisanlar.Location = new System.Drawing.Point(178, 101);
            this.txt_calisanlar.Name = "txt_calisanlar";
            this.txt_calisanlar.Size = new System.Drawing.Size(218, 20);
            this.txt_calisanlar.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Çalışan Sayısı";
            // 
            // txt_arabaStok
            // 
            this.txt_arabaStok.Location = new System.Drawing.Point(178, 153);
            this.txt_arabaStok.Name = "txt_arabaStok";
            this.txt_arabaStok.Size = new System.Drawing.Size(218, 20);
            this.txt_arabaStok.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Araba Stok";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgw_subeler);
            this.groupBox1.Location = new System.Drawing.Point(417, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 345);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şubeler";
            // 
            // dgw_subeler
            // 
            this.dgw_subeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_subeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_subeler.Location = new System.Drawing.Point(3, 16);
            this.dgw_subeler.Name = "dgw_subeler";
            this.dgw_subeler.Size = new System.Drawing.Size(316, 326);
            this.dgw_subeler.TabIndex = 0;
            this.dgw_subeler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_subeler_CellClick);
            // 
            // btn_tümListem
            // 
            this.btn_tümListem.Location = new System.Drawing.Point(22, 201);
            this.btn_tümListem.Name = "btn_tümListem";
            this.btn_tümListem.Size = new System.Drawing.Size(374, 23);
            this.btn_tümListem.TabIndex = 42;
            this.btn_tümListem.Text = "Tüm Liste";
            this.btn_tümListem.UseVisualStyleBackColor = true;
            this.btn_tümListem.Click += new System.EventHandler(this.btn_tümListem_Click);
            // 
            // btn_arama
            // 
            this.btn_arama.Location = new System.Drawing.Point(321, 240);
            this.btn_arama.Name = "btn_arama";
            this.btn_arama.Size = new System.Drawing.Size(75, 23);
            this.btn_arama.TabIndex = 41;
            this.btn_arama.Text = "ARA";
            this.btn_arama.UseVisualStyleBackColor = true;
            this.btn_arama.Click += new System.EventHandler(this.btn_arama_Click);
            // 
            // btn_silme
            // 
            this.btn_silme.Location = new System.Drawing.Point(221, 240);
            this.btn_silme.Name = "btn_silme";
            this.btn_silme.Size = new System.Drawing.Size(75, 23);
            this.btn_silme.TabIndex = 40;
            this.btn_silme.Text = "SİL";
            this.btn_silme.UseVisualStyleBackColor = true;
            this.btn_silme.Click += new System.EventHandler(this.btn_silme_Click);
            // 
            // btn_güncelleme
            // 
            this.btn_güncelleme.Location = new System.Drawing.Point(124, 240);
            this.btn_güncelleme.Name = "btn_güncelleme";
            this.btn_güncelleme.Size = new System.Drawing.Size(75, 23);
            this.btn_güncelleme.TabIndex = 39;
            this.btn_güncelleme.Text = "GÜNCELLE";
            this.btn_güncelleme.UseVisualStyleBackColor = true;
            this.btn_güncelleme.Click += new System.EventHandler(this.btn_güncelleme_Click);
            // 
            // btn_ekleme
            // 
            this.btn_ekleme.Location = new System.Drawing.Point(22, 240);
            this.btn_ekleme.Name = "btn_ekleme";
            this.btn_ekleme.Size = new System.Drawing.Size(75, 23);
            this.btn_ekleme.TabIndex = 38;
            this.btn_ekleme.Text = "EKLE";
            this.btn_ekleme.UseVisualStyleBackColor = true;
            this.btn_ekleme.Click += new System.EventHandler(this.btn_ekleme_Click);
            // 
            // btn_önceki
            // 
            this.btn_önceki.BackColor = System.Drawing.Color.Transparent;
            this.btn_önceki.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_önceki.BackgroundImage")));
            this.btn_önceki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_önceki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_önceki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_önceki.Location = new System.Drawing.Point(36, 343);
            this.btn_önceki.Name = "btn_önceki";
            this.btn_önceki.Size = new System.Drawing.Size(47, 38);
            this.btn_önceki.TabIndex = 43;
            this.btn_önceki.UseVisualStyleBackColor = false;
            this.btn_önceki.Click += new System.EventHandler(this.btn_önceki_Click);
            // 
            // btn_sonraki
            // 
            this.btn_sonraki.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sonraki.BackgroundImage")));
            this.btn_sonraki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sonraki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sonraki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sonraki.Location = new System.Drawing.Point(337, 343);
            this.btn_sonraki.Name = "btn_sonraki";
            this.btn_sonraki.Size = new System.Drawing.Size(47, 38);
            this.btn_sonraki.TabIndex = 44;
            this.btn_sonraki.UseVisualStyleBackColor = true;
            this.btn_sonraki.Click += new System.EventHandler(this.btn_sonraki_Click);
            // 
            // Subeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(751, 417);
            this.Controls.Add(this.btn_sonraki);
            this.Controls.Add(this.btn_önceki);
            this.Controls.Add(this.btn_tümListem);
            this.Controls.Add(this.btn_arama);
            this.Controls.Add(this.btn_silme);
            this.Controls.Add(this.btn_güncelleme);
            this.Controls.Add(this.btn_ekleme);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_arabaStok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_calisanlar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_biransAdi);
            this.Controls.Add(this.label11);
            this.Name = "Subeler";
            this.Text = "Şubeler";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_subeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_biransAdi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_calisanlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_arabaStok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgw_subeler;
        private System.Windows.Forms.Button btn_tümListem;
        private System.Windows.Forms.Button btn_arama;
        private System.Windows.Forms.Button btn_silme;
        private System.Windows.Forms.Button btn_güncelleme;
        private System.Windows.Forms.Button btn_ekleme;
        private System.Windows.Forms.Button btn_önceki;
        private System.Windows.Forms.Button btn_sonraki;
    }
}