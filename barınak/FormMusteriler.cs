using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barınak
{
    public partial class FormMusteriler : Form
    {
        public FormMusteriler()
        {
            InitializeComponent();
            KullanıcıGörüntüle();
        }


        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; " +
            "port=5432; Database=dbvet; user Id= postgres; password=cagla12");


        public void KullanıcıGörüntüle()
        {
            string liste = "select * from musteriler order by musteri_id";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(liste, baglanti);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
        }



        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtTelno.TextLength < 10)
            {
                MessageBox.Show("Lütfen Telefon Numaranızı Doğru Giriniz");
            }
            else
            {

                NpgsqlCommand sorgu1 = new NpgsqlCommand("insert into musteriler (musteri_ad,musteri_soyad,musteri_telno,musteri_adres) values (@p1,@p2,@p3,@p4)", baglanti);
                sorgu1.Parameters.AddWithValue("@p1", txtAd.Text);
                sorgu1.Parameters.AddWithValue("@p2", txtSoyad.Text);
                sorgu1.Parameters.AddWithValue("@p3", txtTelno.Text);
                sorgu1.Parameters.AddWithValue("@p4", txtAdres.Text);
                baglanti.Open();
                sorgu1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Müşteri başarıyla eklendi.");
                txtAd.Clear();
                txtSoyad.Clear();
                txtTelno.Clear();
                txtAdres.Clear();
                KullanıcıGörüntüle();
            }

        }

        

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtTelno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update musteriler set musteri_ad=@p1,musteri_soyad=@p2,musteri_telno=@p3,musteri_adres=@p4 where musteri_id=@p5", baglanti);
            komut3.Parameters.AddWithValue("@p1", txtAd.Text);
            komut3.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut3.Parameters.AddWithValue("@p3", txtTelno.Text);
            komut3.Parameters.AddWithValue("@p4", txtAdres.Text);
            komut3.Parameters.AddWithValue("@p5", int.Parse(txtID.Text));
            komut3.ExecuteNonQuery();
            MessageBox.Show("Müşteri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
            KullanıcıGörüntüle();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTelno.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }


    }
}