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
    public partial class MüsteriRaporEkrani : Form
    {
        RentsCarEntities con = new RentsCarEntities();
        public MüsteriRaporEkrani()
        {
            InitializeComponent();

        }

        private void btn_müsteriYasKirkBüyük_Click(object sender, EventArgs e)
        {
            dgw_müsteriRapor.DataSource = con.Customers.Where(i => i.Age>40).ToList();
        }

        private void btn_bakiyeBüyükKirkBin_Click(object sender, EventArgs e)
        {
            dgw_müsteriRapor.DataSource = con.Customers.Where(i => i.Balance > 40000).ToList();
        }

        private void btn_sonKayitYüzdeYirmi_Click(object sender, EventArgs e)
        {
            var gelen=con.Customers.Where(i => i.customerId < 6).Take(6);
            dgw_müsteriRapor.DataSource = gelen.ToList();


        }

        private void btn_kapora_BinUcBinArasi_Click(object sender, EventArgs e)
        {
            dgw_müsteriRapor.DataSource = con.Customers.Where(i => i.Capora > 1000 && i.Capora<3000).ToList();
        }

        private void btn_yasialtmisBesOlanlarSayisi_Click(object sender, EventArgs e)
        {
            dgw_müsteriRapor.DataSource = con.Customers.Where(i => i.Age == 65).ToList();
        }

        private void btn_yasialtmisBesOlanIsimler_Click(object sender, EventArgs e)
        {
            var gelen = from i in con.Customers
                        where i.Age == 65
                        select new
                        {
                            i.customerNameSurname,
                            i.Age
                         };



            dgw_müsteriRapor.DataSource = gelen.ToList();


        }

        private void btn_yasiKirkBüyükIsimAraba_Click(object sender, EventArgs e)
        {


            var gelen = from cu in con.Customers
                        join ca in con.Cars
                        on cu.customerId equals ca.customerId
                        where cu.Age > 40
                        select new
                        {
                         cu.Age,
                         cu.customerNameSurname,
                         ca.brand
                        };

            dgw_müsteriRapor.DataSource = gelen.ToList();

        }

        private void btn_ismeGöreArabaSubeBilgi_Click(object sender, EventArgs e)
        {
            var gelen = from cu in con.Customers
                        join ca in con.Cars
                        on cu.customerId equals ca.customerId
                        join br in con.Branches
                        on ca.branchNum equals br.branchNum
                        where cu.customerNameSurname == txt_müsteriIsim.Text
                        select new
                        {
                          Car=ca.carNum,
                          Sube=br.branchName
                        };

            dgw_müsteriRapor.DataSource = gelen.ToList();
            

            

        }

        private void btn_isimSubeBilgi_Click(object sender, EventArgs e)
        {

            var gelen = from cu in con.Customers
                        join ca in con.Cars
                        on cu.customerId equals ca.customerId
                        join br in con.Branches
                        on ca.branchNum equals br.branchNum
                        select new
                        {
                            cu.customerNameSurname,
                            br.branchName

                        };
            dgw_müsteriRapor.DataSource = gelen.ToList();



        }
    }
}
