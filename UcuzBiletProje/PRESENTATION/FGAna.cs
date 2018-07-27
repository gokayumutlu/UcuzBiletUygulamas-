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
    public partial class FGAna : Form
    {
        ESeyahat eSeyahat;
        List<ESeyahatYerleri> syNereden;
        List<ESeyahatYerleri> syNereye;
        List<ESeyahat> fSeyahat;
        string firmaAdi;
        int firmaId;
        public FGAna(string firmaAdi, int firmaId)
        {
            this.firmaAdi = firmaAdi;
            this.firmaId = firmaId;
            InitializeComponent();
            firmaAdiText.Visible = false;
            firmaIdText.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboNereden.Enabled = true;
            comboNereye.Enabled = true;
            ucretText.Enabled = true;
            sureText.Enabled = true;
            dateTimePicker1.Enabled = true;
            firmaAdiText.Enabled = true;
            firmaIdText.Enabled = true;
            checkBox1.Enabled = true;
        }

        private void FGAna_Load(object sender, EventArgs e)
        {
            comboNereden.Enabled = false;
            comboNereye.Enabled = false;
            ucretText.Enabled = false;
            sureText.Enabled = false;
            dateTimePicker1.Enabled = false;
            firmaAdiText.Enabled = false;
            firmaIdText.Enabled = false;
            checkBox1.Enabled = false;

            syNereden = BSeyahatYerleri.SeyahatYerleri();
            comboNereden.DataSource = syNereden;
            comboNereden.DisplayMember = "yerAdi";
            comboNereden.ValueMember = "yerId";

            syNereye = BSeyahatYerleri.SeyahatYerleri();
            comboNereye.DataSource = syNereye;
            comboNereye.DisplayMember = "yerAdi";
            comboNereye.ValueMember = "yerId";

        }

        private void onaylaButton_Click(object sender, EventArgs e)
        {
            eSeyahat = new ESeyahat();
            if (checkBox1.Checked)
            {
                eSeyahat.aktarmali = 1;
            }
            else
            {
                eSeyahat.aktarmali = 0;
            }
            //eSeyahat.firmaAdi = firmaAdiText.Text;
            eSeyahat.firmaAdi = firmaAdi;
            //eSeyahat.firmaId = Convert.ToInt32(firmaIdText.Text);
            eSeyahat.firmaId = firmaId;

            eSeyahat.sure = Convert.ToInt32(sureText.Text);
            eSeyahat.ucret = Convert.ToInt32(ucretText.Text);
            eSeyahat.tarih = dateTimePicker1.Value;
            eSeyahat.nereden = comboNereden.GetItemText(comboNereden.SelectedItem);
            eSeyahat.nereye = comboNereye.GetItemText(comboNereye.SelectedItem);
            BSeyahat.Insert(eSeyahat);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ana ana = new Ana();
            this.Hide();
            ana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fSeyahat=BSeyahat.FSeyahatler(firmaId);
            dataGridView1.DataSource = fSeyahat;
        }
    }
}
