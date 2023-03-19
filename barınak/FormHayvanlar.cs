﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace barınak
{
    public partial class FormHayvanlar : Form
    {
        public FormHayvanlar()
        {
            InitializeComponent();
            HayvanGoruntule();
            MusteriGetir();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbvet; user Id= postgres; password=cagla12");

        public void HayvanGoruntule()
        {
            string liste = "select * from hayvangörüntüle";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(liste, baglanti);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtYas.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cbTur.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cbCins.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cbAdSoyad.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cbKisir.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }


        public void MusteriGetir()
        {
            cbAdSoyad.Items.Clear();

            baglanti.Open();
            NpgsqlCommand sorgu = new NpgsqlCommand("Select musteriBilgi from müsteribilgi", baglanti);
            sorgu.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sorgu);
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cbAdSoyad.Items.Add(dr["musteriBilgi"].ToString());
            }
            baglanti.Close();
        }

        public void TurGetir()
        {
            cbTur.Items.Clear();

            baglanti.Open();
            NpgsqlCommand sorgu = new NpgsqlCommand("Select tur_ad from tur", baglanti);
            sorgu.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sorgu);
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cbTur.Items.Add(dr["tur_ad"].ToString());
            }
            baglanti.Close();
        }

        private void FormHayvanlar_Load(object sender, EventArgs e)
        {
            TurGetir();
        }

        private void cbTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            NpgsqlCommand sorgu2 = new NpgsqlCommand("Select tur_id from tur where tur_ad=@c1", baglanti);
            sorgu2.Parameters.AddWithValue("@c1", cbTur.SelectedItem);
            DataTable dt1 = new DataTable();
            NpgsqlDataAdapter adp1 = new NpgsqlDataAdapter(sorgu2);
            adp1.Fill(dt1);

            foreach (DataRow dr in dt1.Rows)
            {
                labelTur.Text = (dr["tur_id"].ToString());
            }
            baglanti.Close();

            if (cbTur.SelectedIndex == 0)
            {
                cbCins.Items.Clear();
                baglanti.Open();
                NpgsqlCommand sorgu = new NpgsqlCommand("Select cins_ad from cins where " +
                    "cins_id<=5", baglanti);
                sorgu.ExecuteNonQuery();

                DataTable dt = new DataTable();
                NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sorgu);
                adp.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    cbCins.Items.Add(dr["cins_ad"].ToString());
                }
                baglanti.Close();

            }

            else if (cbTur.SelectedIndex == 1)
            {
                cbCins.Items.Clear();
                baglanti.Open();
                NpgsqlCommand sorgu = new NpgsqlCommand("Select cins_ad from cins where " +
                    "cins_id>5", baglanti);
                sorgu.ExecuteNonQuery();

                DataTable dt = new DataTable();
                NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sorgu);
                adp.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    cbCins.Items.Add(dr["cins_ad"].ToString());
                }
                baglanti.Close();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand sorgu2 = new NpgsqlCommand("delete from hayvanlar where hayvan_id=@p1", baglanti);
            sorgu2.Parameters.AddWithValue("@p1", int.Parse(txtID.Text));
            sorgu2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Hayvan başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HayvanGoruntule();

        }

       

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("Update hayvanlar set hayvan_ad=@p1,hayvan_yas=@p2,tur_id=@p3,cins_id=@p4, musteri_id=@p5, kisirlastirma_durum=@p6 where hayvan_id=@p7", baglanti);
            komut3.Parameters.AddWithValue("@p1", txtAd.Text);
            komut3.Parameters.AddWithValue("@p2", Convert.ToInt32(txtYas.Text));
            komut3.Parameters.AddWithValue("@p3", Convert.ToInt32(labelTur.Text));
            komut3.Parameters.AddWithValue("@p4", Convert.ToInt32(labelCins.Text));
            komut3.Parameters.AddWithValue("@p5", int.Parse(labelid.Text));
            komut3.Parameters.AddWithValue("@p6", cbKisir.SelectedItem);
            komut3.Parameters.AddWithValue("@p7", int.Parse(txtID.Text));
            komut3.ExecuteNonQuery();
            MessageBox.Show("Müşteri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
            HayvanGoruntule();

        }

        private void cbAdSoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            NpgsqlCommand sorgu2 = new NpgsqlCommand("Select musteri_id from müsteribilgi " +
                "where musteriBilgi=@c1", baglanti);
            sorgu2.Parameters.AddWithValue("@c1", cbAdSoyad.SelectedItem);
            DataTable dt = new DataTable();
            NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sorgu2);
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                labelid.Text = (dr["musteri_id"].ToString());
            }
            baglanti.Close();
        }

        private void cbCins_SelectedIndexChanged(object sender, EventArgs e)
        {
            NpgsqlCommand sorgu2 = new NpgsqlCommand("Select cins_id from cins where cins_ad=@c1", baglanti);
            sorgu2.Parameters.AddWithValue("@c1", cbCins.SelectedItem);
            DataTable dt = new DataTable();
            NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sorgu2);
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                labelCins.Text = (dr["cins_id"].ToString());
            }
            baglanti.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            NpgsqlCommand sorgu1 = new NpgsqlCommand("insert into hayvanlar " +
                "(hayvan_ad,hayvan_yas,tur_id,cins_id,musteri_id,kisirlastirma_durum) " +
                "values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            sorgu1.Parameters.AddWithValue("@p1", txtAd.Text);
            sorgu1.Parameters.AddWithValue("@p2", Convert.ToInt32(txtYas.Text));
            sorgu1.Parameters.AddWithValue("@p3", Convert.ToInt32(labelTur.Text));
            sorgu1.Parameters.AddWithValue("@p4", Convert.ToInt32(labelCins.Text));
            sorgu1.Parameters.AddWithValue("@p5", int.Parse(labelid.Text));
            sorgu1.Parameters.AddWithValue("@p6", cbKisir.SelectedItem);


            //DataTable dt = new DataTable();
            //NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            //baglanti.Open();
            //NpgsqlCommand komut = new NpgsqlCommand("call hayvanekle(p1,p2,p3,p4,p5,p6)", baglanti);
            //komut.CommandType = CommandType.StoredProcedure;
            //komut.Parameters.AddWithValue("admins_username= @p1", txtAd.Text);
            //komut.Parameters.AddWithValue("admins_password= @p2", int.Parse(txtYas.Text));
            //komut.Parameters.AddWithValue("admins_password= @p2", int.Parse(labelTur.Text));
            //komut.Parameters.AddWithValue("admins_password= @p2", int.Parse(labelCins.Text));
            //komut.Parameters.AddWithValue("admins_password= @p2", int.Parse(labelKisir.Text));
            //komut.Parameters.AddWithValue("admins_password= @p2", cbKisir.SelectedItem);
            //komut.ExecuteNonQuery();
            //baglanti.Close();



            baglanti.Open();
            sorgu1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Hayvan başarıyla eklendi.");
            HayvanGoruntule();
        }

        private void cbKisir_SelectedIndexChanged(object sender, EventArgs e)
        {
            NpgsqlCommand sorgu2 = new NpgsqlCommand("Select kisirlastirma_durum from hayvanlar where kisirlastirma_durum=@c1", baglanti);
            sorgu2.Parameters.AddWithValue("@c1", cbKisir.SelectedItem);
            DataTable dt = new DataTable();
            NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sorgu2);
            adp.Fill(dt);

            //foreach (DataRow dr in dt.Rows)
            //{
            //    labelCins.Text = (dr["cins_id"].ToString());
            //}
            baglanti.Close();
        }

        
    }
}
