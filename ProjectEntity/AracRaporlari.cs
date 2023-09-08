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
    public partial class AracRaporlari : Form
    {
        RentsCarEntities con = new RentsCarEntities();
        public AracRaporlari()
        {
            InitializeComponent();
        }

        private void btn_markasiMercedesRenkMüsteri_Click(object sender, EventArgs e)
        {
            var gelen = from car in con.Cars
                        join cus in con.Customers
                        on car.customerId equals cus.customerId
                        where car.brand == txt_marka.Text
                        select new
                        {
                            car.brand,
                            car.color,
                            cus.customerNameSurname

                        };

            dgw_aracRapor.DataSource = gelen.ToList();

     


        }

        private void btn_fiyatiBelirtilenAraclar_Click(object sender, EventArgs e)
        {
            int aracFiyat=Convert.ToInt32(txt_aracFiyat.Text);
            var gelen=from car in con.Cars
                      join cus in con.Customers
                      on car.customerId equals cus.customerId
                      where car.carPrice > aracFiyat
                      select new
                      {
                          car.carPrice,
                          car.brand,                   
                          cus.customerNameSurname

                      };

            dgw_aracRapor.DataSource = gelen.ToList();

        }

        private void btn_splakaAracMüsteri_Click(object sender, EventArgs e)
        {
            var gelen = from car in con.Cars
                        join cus in con.Customers
                        on car.customerId equals cus.customerId
                        join bra in con.Branches 
                        on car.branchNum equals bra.branchNum
                        where car.plate == txt_plaka.Text
                        select new
                        {

                            car.plate,
                            car.brand,
                            cus.customerNameSurname,
                            bra.branchName
                            

                        };

            dgw_aracRapor.DataSource = gelen.ToList();
            
        }

        private void btn_modelAracSube_Click(object sender, EventArgs e)
        {

            int minModelim = Convert.ToInt32(txt_minModel.Text);
            int maxModelim = Convert.ToInt32(txt_maxModel.Text);

            var gelen = from m in con.Cars
                        join s in con.Branches
                        on m.branchNum equals s.branchNum
                        where m.model > minModelim && m.model < maxModelim
                        select new
                        {
                            m.model,
                            m.brand,
                            s.branchName

                        };

            dgw_aracRapor.DataSource = gelen.ToList();



        }

        private void btn_subeMüsteriAraba_Click(object sender, EventArgs e)
        {

            var gelen = from bra in con.Branches
                        join car in con.Cars
                        on bra.branchNum equals car.branchNum
                        join cus in con.Customers
                        on car.customerId equals cus.customerId
                        where bra.branchName==txt_sube.Text
                        select new
                        {
                            bra.branchName,
                            car.brand,
                            cus.customerNameSurname
                           

                        };

            dgw_aracRapor.DataSource = gelen.ToList();



        }
    }
}
