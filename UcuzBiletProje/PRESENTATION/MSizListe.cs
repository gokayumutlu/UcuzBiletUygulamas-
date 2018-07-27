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
namespace UcuzBiletProje.PRESENTATION
{
    public partial class MSizListe : Form
    {
        List<ESeyahat> seyahat;
        string a;
        string b;
        public MSizListe(string a, string b)
        {
            this.a = a;
            this.b = b;
            InitializeComponent();
        }

        private void MSizListe_Load(object sender, EventArgs e)
        {
            
            seyahat = BSeyahat.SeyahatNeredenNereye(a,b);
            dataGridView1.DataSource = seyahat;
            dataGridView1.Columns["sId"].Visible = false;
            dataGridView1.Columns["firmaId"].Visible = false;
            dataGridView1.Columns["firmaAdi"].HeaderText = "Firma Adı";
            dataGridView1.Columns["aktarmali"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MAna mAna = new MAna();
            this.Hide();
            mAna.Show();
        }
    }
}
