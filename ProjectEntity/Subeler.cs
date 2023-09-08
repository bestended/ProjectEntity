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
    public partial class Subeler : Form
    {
        RentsCarEntities con = new RentsCarEntities();
        public Subeler()
        {
            InitializeComponent();
        }

        private void btn_tümListem_Click(object sender, EventArgs e)
        {
            dgw_subeler.DataSource = con.Branches.ToList();

        }

        private void btn_ekleme_Click(object sender, EventArgs e)
        {
            Branch b = new Branch();
            b.branchName = txt_biransAdi.Text;
            b.employeesCount = Convert.ToInt32(txt_calisanlar.Text);
            b.carStock = Convert.ToInt32(txt_arabaStok.Text);
            con.Branches.Add(b);
            con.SaveChanges();



        }

        private void btn_güncelleme_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txt_biransAdi.Tag);
            var gelenDeger=con.Branches.Where(i => i.branchNum == ID).FirstOrDefault();

            gelenDeger.branchName = txt_biransAdi.Text;
            gelenDeger.employeesCount = Convert.ToInt32(txt_calisanlar.Text);
            gelenDeger.carStock = Convert.ToInt32(txt_arabaStok.Text);
            con.SaveChanges();
            dgw_subeler.DataSource = gelenDeger;

        }

        private void btn_silme_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txt_biransAdi.Tag);
            var gelenDeger = con.Branches.Where(i => i.branchNum == ID).FirstOrDefault();
            con.Branches.Remove(gelenDeger);
            con.SaveChanges();
        }

        private void btn_arama_Click(object sender, EventArgs e)
        {

            dgw_subeler.DataSource = con.Branches.Where(i => i.branchName == txt_biransAdi.Text).ToList();
        

           

        }

        private void dgw_subeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgw_subeler.CurrentRow;
            txt_biransAdi.Tag=row.Cells["branchNum"].Value.ToString();
            txt_biransAdi.Text = row.Cells["branchName"].Value.ToString();
            txt_calisanlar.Text = row.Cells["employees"].Value.ToString();
            txt_arabaStok.Text = row.Cells["carStock"].Value.ToString();

        }

        private void btn_önceki_Click(object sender, EventArgs e)
        {

            MenüEkrani ekran = new MenüEkrani();
            ekran.Show();
         


        }

        private void btn_sonraki_Click(object sender, EventArgs e)
        {
            SubeRaporlari subeRaporlari = new SubeRaporlari();
            subeRaporlari.Show();
        }
    }
}
