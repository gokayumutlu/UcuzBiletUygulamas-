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
    public partial class Ana : Form
    {
        public Ana()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (Kontrol.MLogin(emailText.Text,sifreText.Text))
            {
                MAna mAna = new MAna();
                this.Hide();
                mAna.Show();
            }
            else
            {
                label3.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FLogin fLogin = new FLogin();
            this.Hide();
            fLogin.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ULogin uLogin = new ULogin();
            this.Hide();
            uLogin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MRegister mRegister = new MRegister();
            this.Hide();
            mRegister.Show();
        }

        private void Ana_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
        }
    }
}
