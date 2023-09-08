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
    public partial class Müsterilerim : Form
    {
        RentsCarEntities con = new RentsCarEntities();

        public Müsterilerim()
        {
            InitializeComponent();
        }

        private void btn_tümListelerim_Click(object sender, EventArgs e)
        {
            dgw_müsteriler.DataSource = con.Customers.ToList();
        }

        private void btn_eklemem_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.customerNameSurname = txt_müsteriAdi.Text;
            c.Telephone = txt_telefon.Text;
            c.Age = Convert.ToInt32(txt_yas.Text);
            c.Balance = Convert.ToInt32(txt_kazanc.Text);
            c.Capora = Convert.ToInt32(txt_kapora.Text);
            con.Customers.Add(c);
            con.SaveChanges();

        }

        private void btn_güncellemem_Click(object sender, EventArgs e)
        {

            int ID = Convert.ToInt32(txt_müsteriAdi.Tag);
            var gelenNesne = con.Customers.Where(i => i.customerId == ID).FirstOrDefault();

            gelenNesne.customerNameSurname = txt_müsteriAdi.Text;
            gelenNesne.Telephone = txt_telefon.Text;
            gelenNesne.Age = Convert.ToInt32(txt_yas.Text);
            gelenNesne.Balance = Convert.ToInt32(txt_kazanc.Text);
            gelenNesne.Capora = Convert.ToInt32(txt_kapora.Text);
            


            con.SaveChanges();
            dgw_müsteriler.DataSource = gelenNesne;



        }

        private void btn_silmem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txt_müsteriAdi.Tag);
            var gelenSilNesnesi = con.Customers.Where(i => i.customerId == ID).FirstOrDefault();
            con.Customers.Remove(gelenSilNesnesi);
            con.SaveChanges();


        }

        private void btn_aramam_Click(object sender, EventArgs e)
        {
            dgw_müsteriler.DataSource = con.Customers.Where(i => i.customerNameSurname == txt_müsteriAdi.Text).ToList();




        }

        private void dgw_müsteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgw_müsteriler.CurrentRow;
            txt_müsteriAdi.Tag = row.Cells["customerId"].Value.ToString();
            txt_müsteriAdi.Text = row.Cells["customerNameSurname"].Value.ToString();
            txt_telefon.Text = row.Cells["Telephone"].Value.ToString();
            txt_yas.Text = row.Cells["Age"].Value.ToString();
            txt_kazanc.Text = row.Cells["Balance"].Value.ToString();
            txt_kapora.Text = row.Cells["Capora"].Value.ToString();
           

        }

        private void btn_önceki_Click(object sender, EventArgs e)
        {
            MenüEkrani ekran = new MenüEkrani();
            ekran.Show();
            this.Hide();

        }

        private void btn_sonraki_Click(object sender, EventArgs e)
        {
            MüsteriRaporEkrani ekranRaporMüsteri = new MüsteriRaporEkrani();
            ekranRaporMüsteri.Show();
            this.Hide();
        }
    }
}
