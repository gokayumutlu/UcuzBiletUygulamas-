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
using UcuzBiletProje.ENTITY;
using UcuzBiletProje.BLL;
using UcuzBiletProje.PRESENTATION;
namespace UcuzBiletProje
{
    public partial class MAna : Form
    {
        List<ESeyahatYerleri> seyahatYerleri;
        List<ESeyahatYerleri> seyahatYerleri2;
        string a,b;
        public MAna()
        {
            InitializeComponent();
        }

        private void MAna_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = false;
            seyahatYerleri = BSeyahatYerleri.SeyahatYerleri();
            comboNereden.DataSource = seyahatYerleri;
            comboNereden.DisplayMember = "yerAdi";
            comboNereden.ValueMember = "yerId";
            
            

            seyahatYerleri2 = BSeyahatYerleri.SeyahatYerleri();
            comboNereye.DataSource = seyahatYerleri2;
            comboNereye.DisplayMember = "yerAdi";
            comboNereye.ValueMember = "yerId";

            
        }

        
        private void araButton_Click(object sender, EventArgs e)
        {
            

            if (aktarmasizCheckBox.Checked)
            {
                MSizListe mSiz = new MSizListe(a,b);
                this.Hide();
                mSiz.Show();
            }
            else
            {
                MListe mListe = new MListe(a,b);
                this.Hide();
                mListe.Show();
            }
            
        }

        private void comboNereden_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = comboNereden.GetItemText(comboNereden.SelectedItem);
        }

        private void comboNereye_SelectedIndexChanged(object sender, EventArgs e)
        {
            b = comboNereye.GetItemText(comboNereye.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ana ana = new Ana();
            this.Hide();
            ana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(a+" "+b);
        }
    }
}
