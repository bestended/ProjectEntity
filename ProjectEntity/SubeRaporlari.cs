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
    public partial class SubeRaporlari : Form
    {
        RentsCarEntities con = new RentsCarEntities();
        public SubeRaporlari()
        {
            InitializeComponent();
        }

        private void btn_subeCalisanMüsteri_Click(object sender, EventArgs e)
        {
            var gelen = from bra in con.Branches
                        join emp in con.Employees
                        on bra.branchNum equals emp.brancNum
                        join car in con.Cars
                        on bra.branchNum equals car.branchNum
                        join cus in con.Customers
                        on car.customerId equals cus.customerId

                        where bra.branchName == txt_subeAdi.Text
                        select new
                        {
                            bra.branchName,
                            emp.employeeNameSurname,
                            cus.customerNameSurname
                            
                        };

            dgw_subeRapor.DataSource = gelen.ToList();


        }

        private void btn_clisanSayiSiralama_Click(object sender, EventArgs e)
        {

            var gelen = from i in con.Branches
                        orderby i.employeesCount
                        select i;
            dgw_subeRapor.DataSource = gelen.ToList();

        }

        private void btn_calisanIsimArabaAd_Click(object sender, EventArgs e)
        {

            var gelen = from bra in con.Branches
                        join emp in con.Employees
                        on bra.branchNum equals emp.brancNum
                        join car in con.Cars
                        on bra.branchNum equals car.branchNum
                        where bra.branchName == txt_subeAdi1.Text
                        select new
                        {
                         bra.branchName,
                         emp.employeeNameSurname,
                         car.brand


                        };

           dgw_subeRapor.DataSource = gelen.ToList();

        }
    }
}
