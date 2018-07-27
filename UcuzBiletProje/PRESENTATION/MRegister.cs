using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UcuzBiletProje.ENTITY;
using UcuzBiletProje.BLL;
namespace UcuzBiletProje
{
    public partial class MRegister : Form
    {
        public MRegister()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ana ana = new Ana();
            this.Hide();
            ana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EKullanici yeniKullanici = new EKullanici();
            yeniKullanici.adS = adSoyadText.Text;
            yeniKullanici.email = emailText.Text;
            yeniKullanici.password = sifreText.Text;
            yeniKullanici.telefon = telefonText.Text;
            BKullanici.Insert(yeniKullanici);

        }

        private void MRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
