namespace ProjectEntity
{
    partial class AnaEkranGiris
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
            this.btn_yetkiliGiris = new System.Windows.Forms.Button();
            this.btn_müsteriGirisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_yetkiliGiris
            // 
            this.btn_yetkiliGiris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_yetkiliGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yetkiliGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_yetkiliGiris.Location = new System.Drawing.Point(57, 40);
            this.btn_yetkiliGiris.Name = "btn_yetkiliGiris";
            this.btn_yetkiliGiris.Size = new System.Drawing.Size(235, 185);
            this.btn_yetkiliGiris.TabIndex = 0;
            this.btn_yetkiliGiris.Text = "YETKİLİ GİRİŞİ";
            this.btn_yetkiliGiris.UseVisualStyleBackColor = false;
            this.btn_yetkiliGiris.Click += new System.EventHandler(this.btn_yetkiliGiris_Click);
            // 
            // btn_müsteriGirisi
            // 
            this.btn_müsteriGirisi.BackColor = System.Drawing.Color.Red;
            this.btn_müsteriGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_müsteriGirisi.Location = new System.Drawing.Point(358, 40);
            this.btn_müsteriGirisi.Name = "btn_müsteriGirisi";
            this.btn_müsteriGirisi.Size = new System.Drawing.Size(235, 185);
            this.btn_müsteriGirisi.TabIndex = 1;
            this.btn_müsteriGirisi.Text = "MÜŞTERİ GİRİŞİ";
            this.btn_müsteriGirisi.UseVisualStyleBackColor = false;
            this.btn_müsteriGirisi.Click += new System.EventHandler(this.btn_müsteriGirisi_Click);
            // 
            // AnaEkranGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(643, 276);
            this.Controls.Add(this.btn_müsteriGirisi);
            this.Controls.Add(this.btn_yetkiliGiris);
            this.Name = "AnaEkranGiris";
            this.Text = "Ana Ekran Girişi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_yetkiliGiris;
        private System.Windows.Forms.Button btn_müsteriGirisi;
    }
}