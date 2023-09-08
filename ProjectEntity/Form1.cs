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
    public partial class YetkiliSifreEkrani : Form
    {
        RentsCarEntities con = new RentsCarEntities();
        public YetkiliSifreEkrani()
        {
            InitializeComponent();
        }

        private void btn_yetkiliGiris_Click(object sender, EventArgs e)
        {


            bool dogrulama = con.YetkiliGirisis.Where(i=>i.kullaniciAdi==txt_kullaniciAdi.Text && i.sifre==txt_sifre.Text).Any();

            if (dogrulama)
            {
                MenüEkrani ekran = new MenüEkrani();
                ekran.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Başarısız giriş");
            }


        }
    }
}
