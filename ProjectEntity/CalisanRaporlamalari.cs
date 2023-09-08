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
    public partial class CalisanRaporlamalari : Form
    {
        RentsCarEntities con = new RentsCarEntities();
        public CalisanRaporlamalari()
        {
            InitializeComponent();
        }

        private void btn_clisanMaasSiralama_Click(object sender, EventArgs e)
        {
            var gelen = from emp in con.Employees
                        orderby emp.salary
                        select new
                        {
                            emp.employeeNameSurname,
                            emp.salary

                        };

            dgw_calisanRapor.DataSource = gelen.ToList();

        }

        private void btn_subeCalisanMüsteri_Click(object sender, EventArgs e)
        {

            var gelen = from emp in con.Employees
                        join bra in con.Branches
                        on emp.brancNum equals bra.branchNum
                        where emp.employeeNameSurname == txt_calisanAdi.Text
                        select new
                        {
                            emp.employeeNameSurname,
                            bra.branchName

                        };
            dgw_calisanRapor.DataSource = gelen.ToList();

        }

        private void btn_calisanSatisAd_Click(object sender, EventArgs e)
        {


            var gelen = from emp in con.Employees
                        join bra in con.Branches
                        on emp.brancNum equals bra.branchNum
                        join car in con.Cars
                        on bra.branchNum equals car.branchNum
                        where emp.employeeNameSurname == txt_calisanSatisAd.Text
                        select new
                        {
                            emp.employeeNameSurname,
                            bra.branchName,
                            car.brand


                        };

            dgw_calisanRapor.DataSource = gelen.ToList();



        }

        private void btn_maasGrupla_Click(object sender, EventArgs e)
        {
            var gelen = from emp in con.Employees
                        orderby emp.salary
                        group emp by emp.salary into calisanMaas
                        select calisanMaas;
                       
            dgw_calisanRapor.DataSource = gelen.ToList();



        }
    }
}
