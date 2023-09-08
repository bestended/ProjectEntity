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
    public partial class MenüEkrani : Form
    {
        public MenüEkrani()
        {
            InitializeComponent();
        }

      
      


        private void btn_araclar_Click(object sender, EventArgs e)
        {
            AraclarEkrani ekranimArac = new AraclarEkrani();
            ekranimArac.Show();
            this.Hide();
        }

        private void btn_subeler_Click(object sender, EventArgs e)
        {
            Subeler sube = new Subeler();
            sube.Show();
            this.Hide();



        }

        private void btn_müsteriler_Click(object sender, EventArgs e)
        {
            Müsterilerim müsterim = new Müsterilerim();
            müsterim.Show();
            this.Hide();
        }

        private void btn_personeller_Click(object sender, EventArgs e)
        {

            PersonelList pers = new PersonelList();
            pers.Show();
            this.Hide();



        }

       
    }
}
