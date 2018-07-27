using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UcuzBiletProje.FACADE;
namespace UcuzBiletProje
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ana ana = new Ana();
            this.Hide();
            ana.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Kontrol.FLogin(emailText.Text, sifreText.Text))
            {
                string firmaAdi = Kontrol.FirmaAdi();
                int firmaId = Kontrol.FirmaId();
                FGAna fGAna = new FGAna(firmaAdi,firmaId);
                this.Hide();
                fGAna.Show();
            }
            else
            {
                label3.Visible = true;
            }
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
        }
    }
}
