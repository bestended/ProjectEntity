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
    public partial class AraclarEkrani : Form
    {
        RentsCarEntities con = new RentsCarEntities();
        public AraclarEkrani()
        {
            InitializeComponent();
        }

      

        private void btn_tümListe_Click(object sender, EventArgs e)
        {

            dgw_aracListe.DataSource = con.Cars.ToList();


        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Car a = new Car();
            a.carPrice = Convert.ToInt32(txt_fiyat.Text);
            a.plate = txt_plaka.Text;
            a.brand = txt_marka.Text;
            a.model = Convert.ToInt32(txt_model.Text);
            a.year = Convert.ToInt32(txt_Yil.Text);
            a.engine = txt_motor.Text;
            a.package = txt_paket.Text;
            a.color = txt_renk.Text;
            a.gear = txt_vites.Text;
            a.branchNum = Convert.ToInt32(txt_biransNo.Text);
            a.customerId = Convert.ToInt32(txt_customerId.Text);

            con.Cars.Add(a);
            con.SaveChanges();




        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {

            int ID = Convert.ToInt32(txt_plaka.Tag);
            var gelenNesne = con.Cars.Where(i => i.carNum == ID).FirstOrDefault();

            gelenNesne.carPrice = Convert.ToInt32(txt_fiyat.Text);
            gelenNesne.plate = txt_plaka.Text;
            gelenNesne.brand = txt_marka.Text;
            gelenNesne.model = Convert.ToInt32(txt_model.Text);
            gelenNesne.year = Convert.ToInt32(txt_Yil.Text);
            gelenNesne.engine = txt_motor.Text;
            gelenNesne.package = txt_paket.Text;
            gelenNesne.color = txt_renk.Text;
            gelenNesne.gear = txt_vites.Text;
            gelenNesne.branchNum = Convert.ToInt32(txt_biransNo.Text);
            gelenNesne.customerId = Convert.ToInt32(txt_customerId.Text);
            con.SaveChanges();
            dgw_aracListe.DataSource = gelenNesne;


        }

        private void dgw_aracListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dgw_aracListe.CurrentRow;
            txt_plaka.Tag=row.Cells["carNum"].Value.ToString();
            txt_fiyat.Text = row.Cells["carPrice"].Value.ToString();
            txt_plaka.Text = row.Cells["plate"].Value.ToString();
            txt_marka.Text = row.Cells["brand"].Value.ToString();
            txt_model.Text = row.Cells["model"].Value.ToString();
            txt_Yil.Text = row.Cells["year"].Value.ToString();
            txt_motor.Text = row.Cells["engine"].Value.ToString();
            txt_paket.Text = row.Cells["package"].Value.ToString();
            txt_renk.Text = row.Cells["color"].Value.ToString();
            txt_vites.Text = row.Cells["gear"].Value.ToString();
            txt_biransNo.Text = row.Cells["branchNum"].Value.ToString();
            txt_customerId.Text = row.Cells["customerId"].Value.ToString();




        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txt_plaka.Tag);
            var gelenSilNesnesi=con.Cars.Where(i=>i.branchNum==ID).FirstOrDefault();
            con.Cars.Remove(gelenSilNesnesi);
            con.SaveChanges();


        }

        private void btn_plakaSorgu_Click(object sender, EventArgs e)
        {
            dgw_aracListe.DataSource = con.Cars.ToList();
            con.Cars.Where(i => i.plate == txt_plaka.Text);



        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            dgw_aracListe.DataSource = con.Cars.Where(i => i.brand == txt_marka.Text).ToList();

        }

        private void btn_önceki_Click(object sender, EventArgs e)
        {
            MenüEkrani ekran = new MenüEkrani();
            ekran.Show();
            this.Hide();
        }

        private void btn_sonraki_Click(object sender, EventArgs e)
        {
            AracRaporlari aracRaporlari = new AracRaporlari();
            aracRaporlari.Show();

        }
    }
}
