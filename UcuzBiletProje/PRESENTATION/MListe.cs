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
    public partial class MListe : Form
    {
        List<ESeyahat> seyahat;
        string a;
        string b;
        public MListe(string a, string b)
        {
            this.a = a;
            this.b = b;
            InitializeComponent();
        }

        private void MListe_Load(object sender, EventArgs e)
        {
            //int aktarma;
            seyahat= BSeyahat.SeyahatNeredenNereye(a,b);
            dataGridView1.DataSource = seyahat;
            if (dataGridView1.ColumnCount <= 0)
            {
                MessageBox.Show("Seyahat bulunamadı");
                
            }
            else
            {
                dataGridView1.Columns["sId"].Visible = false;
                dataGridView1.Columns["firmaId"].Visible = false;
                dataGridView1.Columns["firmaAdi"].HeaderText = "Firma Adı";
                //aktarma = Convert.ToInt32(dataGridView1.Columns["aktarmali"]);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MAna mAna = new MAna();
            this.Hide();
            mAna.Show();
        }
    }
}
