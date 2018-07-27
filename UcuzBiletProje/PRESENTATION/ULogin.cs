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
    public partial class ULogin : Form
    {
        public ULogin()
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
            if (Kontrol.ULogin(emailText.Text, sifreText.Text))
            {
                UGAna uGAna = new UGAna();
                this.Hide();
                uGAna.Show();
            }
            else
            {
                label3.Visible = true;
            }
        }

        private void ULogin_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
        }
    }
}
