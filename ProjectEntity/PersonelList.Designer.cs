namespace ProjectEntity
{
    partial class PersonelList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelList));
            this.txt_calisanAdi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_calisanTelefon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ünvan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_maas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_bransNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgw_personel = new System.Windows.Forms.GroupBox();
            this.dgw_personeller = new System.Windows.Forms.DataGridView();
            this.btn_tümList = new System.Windows.Forms.Button();
            this.btn_ara = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_güncel = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sonraki = new System.Windows.Forms.Button();
            this.btn_önceki = new System.Windows.Forms.Button();
            this.dgw_personel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_personeller)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_calisanAdi
            // 
            this.txt_calisanAdi.Location = new System.Drawing.Point(227, 52);
            this.txt_calisanAdi.Name = "txt_calisanAdi";
            this.txt_calisanAdi.Size = new System.Drawing.Size(146, 20);
            this.txt_calisanAdi.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(52, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 20);
            this.label11.TabIndex = 35;
            this.label11.Text = "Çalışan Adı Soyadı";
            // 
            // txt_calisanTelefon
            // 
            this.txt_calisanTelefon.Location = new System.Drawing.Point(227, 93);
            this.txt_calisanTelefon.Name = "txt_calisanTelefon";
            this.txt_calisanTelefon.Size = new System.Drawing.Size(146, 20);
            this.txt_calisanTelefon.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(52, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Çalışan Telefonu";
            // 
            // txt_ünvan
            // 
            this.txt_ünvan.Location = new System.Drawing.Point(227, 135);
            this.txt_ünvan.Name = "txt_ünvan";
            this.txt_ünvan.Size = new System.Drawing.Size(146, 20);
            this.txt_ünvan.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(52, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Ünvan";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(227, 177);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(146, 20);
            this.txt_mail.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(52, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Mail";
            // 
            // txt_maas
            // 
            this.txt_maas.Location = new System.Drawing.Point(227, 218);
            this.txt_maas.Name = "txt_maas";
            this.txt_maas.Size = new System.Drawing.Size(146, 20);
            this.txt_maas.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(52, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Maaş";
            // 
            // txt_bransNo
            // 
            this.txt_bransNo.Location = new System.Drawing.Point(227, 263);
            this.txt_bransNo.Name = "txt_bransNo";
            this.txt_bransNo.Size = new System.Drawing.Size(146, 20);
            this.txt_bransNo.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(52, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Branş Numarası";
            // 
            // dgw_personel
            // 
            this.dgw_personel.Controls.Add(this.dgw_personeller);
            this.dgw_personel.Location = new System.Drawing.Point(428, 40);
            this.dgw_personel.Name = "dgw_personel";
            this.dgw_personel.Size = new System.Drawing.Size(366, 345);
            this.dgw_personel.TabIndex = 47;
            this.dgw_personel.TabStop = false;
            this.dgw_personel.Text = "Personel Listesi";
            // 
            // dgw_personeller
            // 
            this.dgw_personeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_personeller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_personeller.Location = new System.Drawing.Point(3, 16);
            this.dgw_personeller.Name = "dgw_personeller";
            this.dgw_personeller.Size = new System.Drawing.Size(360, 326);
            this.dgw_personeller.TabIndex = 0;
            this.dgw_personeller.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_personeller_CellClick);
            // 
            // btn_tümList
            // 
            this.btn_tümList.Location = new System.Drawing.Point(32, 316);
            this.btn_tümList.Name = "btn_tümList";
            this.btn_tümList.Size = new System.Drawing.Size(374, 23);
            this.btn_tümList.TabIndex = 53;
            this.btn_tümList.Text = "Tüm Liste";
            this.btn_tümList.UseVisualStyleBackColor = true;
            this.btn_tümList.Click += new System.EventHandler(this.btn_tümList_Click);
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(331, 355);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(75, 23);
            this.btn_ara.TabIndex = 52;
            this.btn_ara.Text = "ARA";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(231, 355);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 51;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_güncel
            // 
            this.btn_güncel.Location = new System.Drawing.Point(134, 355);
            this.btn_güncel.Name = "btn_güncel";
            this.btn_güncel.Size = new System.Drawing.Size(75, 23);
            this.btn_güncel.TabIndex = 50;
            this.btn_güncel.Text = "GÜNCELLE";
            this.btn_güncel.UseVisualStyleBackColor = true;
            this.btn_güncel.Click += new System.EventHandler(this.btn_güncel_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(32, 355);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 49;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sonraki
            // 
            this.btn_sonraki.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sonraki.BackgroundImage")));
            this.btn_sonraki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sonraki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sonraki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sonraki.Location = new System.Drawing.Point(744, 400);
            this.btn_sonraki.Name = "btn_sonraki";
            this.btn_sonraki.Size = new System.Drawing.Size(47, 38);
            this.btn_sonraki.TabIndex = 55;
            this.btn_sonraki.UseVisualStyleBackColor = true;
            this.btn_sonraki.Click += new System.EventHandler(this.btn_sonraki_Click);
            // 
            // btn_önceki
            // 
            this.btn_önceki.BackColor = System.Drawing.Color.Transparent;
            this.btn_önceki.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_önceki.BackgroundImage")));
            this.btn_önceki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_önceki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_önceki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_önceki.Location = new System.Drawing.Point(32, 400);
            this.btn_önceki.Name = "btn_önceki";
            this.btn_önceki.Size = new System.Drawing.Size(47, 38);
            this.btn_önceki.TabIndex = 54;
            this.btn_önceki.UseVisualStyleBackColor = false;
            this.btn_önceki.Click += new System.EventHandler(this.btn_önceki_Click);
            // 
            // PersonelList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.btn_sonraki);
            this.Controls.Add(this.btn_önceki);
            this.Controls.Add(this.btn_tümList);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_güncel);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.dgw_personel);
            this.Controls.Add(this.txt_bransNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_maas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ünvan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_calisanTelefon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_calisanAdi);
            this.Controls.Add(this.label11);
            this.Name = "PersonelList";
            this.Text = "Personel Listesi";
            this.dgw_personel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_personeller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_calisanAdi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_calisanTelefon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ünvan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_maas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_bransNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox dgw_personel;
        private System.Windows.Forms.DataGridView dgw_personeller;
        private System.Windows.Forms.Button btn_tümList;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_güncel;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sonraki;
        private System.Windows.Forms.Button btn_önceki;
    }
}