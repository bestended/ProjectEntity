namespace ProjectEntity
{
    partial class MenüEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenüEkrani));
            this.btn_personeller = new System.Windows.Forms.Button();
            this.btn_müsteriler = new System.Windows.Forms.Button();
            this.btn_subeler = new System.Windows.Forms.Button();
            this.btn_araclar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_personeller
            // 
            this.btn_personeller.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_personeller.BackgroundImage")));
            this.btn_personeller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_personeller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_personeller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_personeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_personeller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_personeller.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_personeller.Location = new System.Drawing.Point(319, 245);
            this.btn_personeller.Name = "btn_personeller";
            this.btn_personeller.Size = new System.Drawing.Size(169, 168);
            this.btn_personeller.TabIndex = 7;
            this.btn_personeller.Text = "PERSONELLER";
            this.btn_personeller.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_personeller.UseVisualStyleBackColor = true;
            this.btn_personeller.Click += new System.EventHandler(this.btn_personeller_Click);
            // 
            // btn_müsteriler
            // 
            this.btn_müsteriler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_müsteriler.BackgroundImage")));
            this.btn_müsteriler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_müsteriler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_müsteriler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_müsteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_müsteriler.ForeColor = System.Drawing.Color.Maroon;
            this.btn_müsteriler.Location = new System.Drawing.Point(37, 244);
            this.btn_müsteriler.Name = "btn_müsteriler";
            this.btn_müsteriler.Size = new System.Drawing.Size(169, 168);
            this.btn_müsteriler.TabIndex = 6;
            this.btn_müsteriler.Text = "MÜŞTERİLER";
            this.btn_müsteriler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_müsteriler.UseVisualStyleBackColor = true;
            this.btn_müsteriler.Click += new System.EventHandler(this.btn_müsteriler_Click);
            // 
            // btn_subeler
            // 
            this.btn_subeler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_subeler.BackgroundImage")));
            this.btn_subeler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_subeler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_subeler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_subeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_subeler.ForeColor = System.Drawing.Color.Yellow;
            this.btn_subeler.Location = new System.Drawing.Point(319, 34);
            this.btn_subeler.Name = "btn_subeler";
            this.btn_subeler.Size = new System.Drawing.Size(169, 168);
            this.btn_subeler.TabIndex = 5;
            this.btn_subeler.Text = "ŞUBELER";
            this.btn_subeler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_subeler.UseVisualStyleBackColor = true;
            this.btn_subeler.Click += new System.EventHandler(this.btn_subeler_Click);
            // 
            // btn_araclar
            // 
            this.btn_araclar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_araclar.BackgroundImage")));
            this.btn_araclar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_araclar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_araclar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_araclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_araclar.ForeColor = System.Drawing.Color.Teal;
            this.btn_araclar.Location = new System.Drawing.Point(37, 34);
            this.btn_araclar.Name = "btn_araclar";
            this.btn_araclar.Size = new System.Drawing.Size(169, 168);
            this.btn_araclar.TabIndex = 4;
            this.btn_araclar.Text = "ARAÇLAR";
            this.btn_araclar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_araclar.UseVisualStyleBackColor = true;
            this.btn_araclar.Click += new System.EventHandler(this.btn_araclar_Click);
            // 
            // MenüEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.btn_personeller);
            this.Controls.Add(this.btn_müsteriler);
            this.Controls.Add(this.btn_subeler);
            this.Controls.Add(this.btn_araclar);
            this.Name = "MenüEkrani";
            this.Text = "Menü Ekranı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_personeller;
        private System.Windows.Forms.Button btn_müsteriler;
        private System.Windows.Forms.Button btn_subeler;
        private System.Windows.Forms.Button btn_araclar;
    }
}