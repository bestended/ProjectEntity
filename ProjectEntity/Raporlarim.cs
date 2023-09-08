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
    public partial class Raporlarim : Form
    {
        public Raporlarim()
        {
            InitializeComponent();
        }

        private void Raporlarim_Load(object sender, EventArgs e)
        {

        }

        private void btn_müsteriRapor_Click(object sender, EventArgs e)
        {
            MüsteriRaporEkrani müsteriEkran = new MüsteriRaporEkrani();
            müsteriEkran.Show();

            this.Hide();
        }
    }
}
