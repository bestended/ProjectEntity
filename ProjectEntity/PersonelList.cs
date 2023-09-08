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
    public partial class PersonelList : Form
    {
        RentsCarEntities con = new RentsCarEntities();
        public PersonelList()
        {
            InitializeComponent();
        }

        private void btn_tümList_Click(object sender, EventArgs e)
        {

            dgw_personeller.DataSource = con.Employees.ToList();


        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {


            Employee e1 = new Employee();
            e1.employeeNameSurname = txt_calisanAdi.Text;
            e1.employeePhone = txt_calisanTelefon.Text;
            e1.title = txt_ünvan.Text;
            e1.mail = txt_mail.Text;
            e1.salary = Convert.ToInt32(txt_maas.Text);
            e1.brancNum = Convert.ToInt32(txt_bransNo.Text);
            con.Employees.Add(e1);
            con.SaveChanges();


        }

        private void btn_güncel_Click(object sender, EventArgs e)
        {

            int ID = Convert.ToInt32(txt_calisanAdi.Tag);
            var nesne=con.Employees.Where(i => i.employeeNum == ID).FirstOrDefault();


            nesne.employeeNameSurname = txt_calisanAdi.Text;
            nesne.employeePhone = txt_calisanTelefon.Text;
            nesne.title = txt_ünvan.Text;
            nesne.mail = txt_mail.Text;
            nesne.salary = Convert.ToInt32(txt_maas.Text);
            nesne.brancNum = Convert.ToInt32(txt_bransNo.Text);

            con.SaveChanges();
            dgw_personeller.DataSource = nesne;



        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txt_calisanAdi.Tag);
            var gelenSilNesnesi = con.Employees.Where(i => i.employeeNum == ID).FirstOrDefault();
            con.Employees.Remove(gelenSilNesnesi);
            con.SaveChanges();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            dgw_personeller.DataSource = con.Employees.Where(i => i.employeeNameSurname == txt_calisanAdi.Text).ToList();


        }

        private void dgw_personeller_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dgw_personeller.CurrentRow;
            txt_calisanAdi.Tag = row.Cells["employeeNum"].Value.ToString();
            txt_calisanAdi.Text = row.Cells["employeeNameSurname"].Value.ToString();
            txt_calisanTelefon.Text = row.Cells["employeePhone"].Value.ToString();
            txt_ünvan.Text = row.Cells["title"].Value.ToString();
            txt_mail.Text = row.Cells["mail"].Value.ToString();
            txt_maas.Text = row.Cells["salary"].Value.ToString();
            txt_bransNo.Text = row.Cells["brancNum"].Value.ToString();


        }

        private void btn_önceki_Click(object sender, EventArgs e)
        {
            MenüEkrani ekran = new MenüEkrani();
            ekran.Show();
            this.Hide();
        }

        private void btn_sonraki_Click(object sender, EventArgs e)
        {
            CalisanRaporlamalari calisanRaporlamalari = new CalisanRaporlamalari();
            calisanRaporlamalari.Show();



        }
    }
}
