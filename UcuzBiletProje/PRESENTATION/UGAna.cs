﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UcuzBiletProje.BLL;
using UcuzBiletProje.ENTITY;

namespace UcuzBiletProje
{
    public partial class UGAna : Form
    {
        List<EKullanici> kullaniciList;
        List<EFirma> firmaList;
        //List<EKullanici> firmaGorevliList;
        List<EFirmaYetkilisi> firmaYetkilisi;
        public UGAna()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kullaniciList = BKullanici.ButunKullanicilar();
            dataGridView1.DataSource = kullaniciList;
            dataGridView1.Columns["password"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            firmaList = BFirma.ButunFirmalar();
            dataGridView1.DataSource = firmaList;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EFirma eFirma = new EFirma();
            if (textBox1.Text!=null && textBox1.Text.Trim().Length>0)
            {
                eFirma.firmaAdi = textBox1.Text;
                BFirma.Insert(eFirma);
            }
            else
            {
                MessageBox.Show("TextBox'a firma adı girin! ");
            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //firmaGorevliList = BKullanici.FirmaGorevlileri();
            //dataGridView1.DataSource = firmaGorevliList;
            //dataGridView1.Columns["password"].Visible = false;

            firmaYetkilisi = BFirmaYetkilisi.ButunKullanicilar();
            dataGridView1.DataSource = firmaYetkilisi;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void UGAna_Load(object sender, EventArgs e)
        {
            button3.Visible = false;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Ana ana = new Ana();
            this.Hide();
            ana.Show();
        }
    }
}
