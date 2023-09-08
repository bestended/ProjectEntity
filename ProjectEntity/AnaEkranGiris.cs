using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEntity
{
    public partial class AnaEkranGiris : Form
    {
        public AnaEkranGiris()
        {
            InitializeComponent();
        }

        private void btn_yetkiliGiris_Click(object sender, EventArgs e)
        {
            YetkiliSifreEkrani sifreEkran = new YetkiliSifreEkrani();
            sifreEkran.Show();
            this.Hide();

        }

        private void btn_müsteriGirisi_Click(object sender, EventArgs e)
        {
            MenüEkrani ekranim = new MenüEkrani();
            Button btnMüsteri=(Button)ekranim.Controls["btn_müsteriler"];
            Button btnPersonel = (Button)ekranim.Controls["btn_personeller"];
            btnMüsteri.Enabled = false;
            btnMüsteri.BackColor = Color.Gray;
            

            btnPersonel.Enabled = false;
            btnPersonel.BackColor = Color.Gray;




            ekranim.Show();
            this.Hide();
        }
    }
}
