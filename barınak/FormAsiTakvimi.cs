using Npgsql;
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
    public partial class FormAsiTakvimi : Form
    {
        public FormAsiTakvimi()
        {
            InitializeComponent();
            HayvanGetir();
            AsitakvimiGetir();
            AsiturGetir();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; " +
            "Database=dbvet; user Id= postgres; password=cagla12");


        public void HayvanGetir()
        {
            cbHayvan.Items.Clear();
            baglanti.Open();
            NpgsqlCommand sorgu = new NpgsqlCommand("Select hayvan_ad from hayvanlar order by hayvan_id", baglanti);
            sorgu.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sorgu);
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cbHayvan.Items.Add(dr["hayvan_ad"].ToString());
            }
            baglanti.Close();

        }
        public void AsitakvimiGetir()
        {
            string liste = "select * from asitakvimiview order by asi_tarih ";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(liste, baglanti);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
            dataGridView2.Visible = false;
        }

        public void AsiturGetir()
        {
            cbAsiTur.Items.Clear();
            baglanti.Open();
            NpgsqlCommand sorgu = new NpgsqlCommand("Select asi_adi from asilar order by asi_tur_id", baglanti);
            sorgu.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sorgu);
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cbAsiTur.Items.Add(dr["asi_adi"].ToString());
            }
            baglanti.Close();
        }


        private void cbAsiTur_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            NpgsqlCommand sorgu2 = new NpgsqlCommand("Select asi_tur_id from asilar where asi_adi=@c1", baglanti);
            sorgu2.Parameters.AddWithValue("@c1", cbAsiTur.SelectedItem);

            DataTable dt1 = new DataTable();
            NpgsqlDataAdapter adp1 = new NpgsqlDataAdapter(sorgu2);
            adp1.Fill(dt1);

            foreach (DataRow dr in dt1.Rows)
            {
                labelasiturid.Text = (dr["asi_tur_id"].ToString());
            }
            baglanti.Close();

            if (cbAsiTur.SelectedIndex == 0)
            {

                txtUcret.Text = " ";
                baglanti.Open();
                NpgsqlCommand sorgu = new NpgsqlCommand("Select asi_ucret from asilar where asi_tur_id=1", baglanti);
                sorgu.ExecuteNonQuery();

                DataTable dt = new DataTable();
                NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sorgu);
                adp.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txtUcret.Text = (dr["asi_ucret"].ToString());
                }
                baglanti.Close();

            }

            else if (cbAsiTur.SelectedIndex == 1)
            {
                txtUcret.Text = " ";
                baglanti.Open();
                NpgsqlCommand sorgu = new NpgsqlCommand("Select asi_ucret from asilar where asi_tur_id=2", baglanti);
                sorgu.ExecuteNonQuery();

                DataTable dt = new DataTable();
                NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sorgu);
                adp.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txtUcret.Text = (dr["asi_ucret"].ToString());
                }
                baglanti.Close();
            }

            else if (cbAsiTur.SelectedIndex == 2)
            {
                txtUcret.Text = " ";
                baglanti.Open();
                NpgsqlCommand sorgu = new NpgsqlCommand("Select asi_ucret from asilar where asi_tur_id=3", baglanti);
                sorgu.ExecuteNonQuery();

                DataTable dt = new DataTable();
                NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sorgu);
                adp.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txtUcret.Text = (dr["asi_ucret"].ToString());
                }
                baglanti.Close();
            }
            else if (cbAsiTur.SelectedIndex == 3)
            {
                txtUcret.Text = " ";
                baglanti.Open();
                NpgsqlCommand sorgu = new NpgsqlCommand("Select asi_ucret from asilar where asi_tur_id=4", baglanti);
                sorgu.ExecuteNonQuery();

                DataTable dt = new DataTable();
                NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sorgu);
                adp.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txtUcret.Text = (dr["asi_ucret"].ToString());
                }
                baglanti.Close();
            }
            else if (cbAsiTur.SelectedIndex == 4)
            {
                txtUcret.Text = " ";
                baglanti.Open();
                NpgsqlCommand sorgu = new NpgsqlCommand("Select asi_ucret from asilar where asi_tur_id=5", baglanti);
                sorgu.ExecuteNonQuery();

                DataTable dt = new DataTable();
                NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sorgu);
                adp.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txtUcret.Text = (dr["asi_ucret"].ToString());
                }
                baglanti.Close();
            }
            else if (cbAsiTur.SelectedIndex == 5)
            {
                txtUcret.Text = " ";
                baglanti.Open();
                NpgsqlCommand sorgu = new NpgsqlCommand("Select asi_ucret from asilar where asi_tur_id=6", baglanti);
                sorgu.ExecuteNonQuery();

                DataTable dt = new DataTable();
                NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sorgu);
                adp.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txtUcret.Text = (dr["asi_ucret"].ToString());
                }
                baglanti.Close();
            }
            else if (cbAsiTur.SelectedIndex == 6)
            {
                txtUcret.Text = " ";
                baglanti.Open();
                NpgsqlCommand sorgu = new NpgsqlCommand("Select asi_ucret from asilar where asi_tur_id=7", baglanti);
                sorgu.ExecuteNonQuery();

                DataTable dt = new DataTable();
                NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sorgu);
                adp.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txtUcret.Text = (dr["asi_ucret"].ToString());
                }
                baglanti.Close();
            }
            else if (cbAsiTur.SelectedIndex == 7)
            {
                txtUcret.Text = " ";
                baglanti.Open();
                NpgsqlCommand sorgu = new NpgsqlCommand("Select asi_ucret from asilar where asi_tur_id=8", baglanti);
                sorgu.ExecuteNonQuery();

                DataTable dt = new DataTable();
                NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sorgu);
                adp.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txtUcret.Text = (dr["asi_ucret"].ToString());
                }
                baglanti.Close();
            }
            else if (cbAsiTur.SelectedIndex == 8)
            {
                txtUcret.Text = " ";
                baglanti.Open();
                NpgsqlCommand sorgu = new NpgsqlCommand("Select asi_ucret from asilar where asi_tur_id=9", baglanti);
                sorgu.ExecuteNonQuery();

                DataTable dt = new DataTable();
                NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sorgu);
                adp.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txtUcret.Text = (dr["asi_ucret"].ToString());
                }
                baglanti.Close();
            }


        }

        private void cbHayvan_SelectedIndexChanged(object sender, EventArgs e)
        {
            NpgsqlCommand sorgu2 = new NpgsqlCommand("Select hayvan_id from hayvanlar where hayvan_ad=@c1", baglanti);
            sorgu2.Parameters.AddWithValue("@c1", cbHayvan.SelectedItem);
            DataTable dt = new DataTable();
            NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sorgu2);
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                labelhayvanid.Text = (dr["hayvan_id"].ToString());
            }
            baglanti.Close();
        }

        private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            labelid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbHayvan.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cbAsiTur.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtUcret.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand sorgu2 = new NpgsqlCommand("delete from asitakvimi where asi_id=@p1", baglanti);
            sorgu2.Parameters.AddWithValue("@p1", int.Parse(labelid.Text));
            sorgu2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Randevu başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AsitakvimiGetir();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            NpgsqlCommand sorgu1 = new NpgsqlCommand("insert into asitakvimi (asi_tur_id,hayvan_id,asi_tutar,asi_tarih) values (@p1,@p2,@p3,@p4)", baglanti);

            sorgu1.Parameters.AddWithValue("@p1", int.Parse(labelasiturid.Text));
            sorgu1.Parameters.AddWithValue("@p2", int.Parse(labelhayvanid.Text));
            sorgu1.Parameters.AddWithValue("@p3", int.Parse(txtUcret.Text));
            sorgu1.Parameters.AddWithValue("@p4", dateTimePicker1.Value);


            baglanti.Open();
            sorgu1.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Aşı işlemi başarıyla eklendi.");




            AsitakvimiGetir();
        }

        private void FormAsiTakvimi_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Columns["hayvan_id"].Visible = false;
            this.dataGridView1.Columns["asi_tur_id"].Visible = false;
            this.dataGridView1.Columns["asi_id"].Visible = false;
            this.dataGridView1.Columns["asi_tutar"].Visible = false;

        //    this.dataGridView2.Columns["hayvan_id"].Visible = false;
          //  this.dataGridView2.Columns["musteri_id"].Visible = false;


            dateTimePicker1.MinDate = DateTime.Now;   // gizliyoruz çünkü mindate olunca eski tarihleri datetimepickerda gösteremiyo
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("Update asitakvimi set asi_tur_id=@p1,hayvan_id=@p2,asi_tutar=@p3,asi_tarih=@p4 where asi_id=@p5", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(labelasiturid.Text));
            komut3.Parameters.AddWithValue("@p2", Convert.ToInt32(labelhayvanid.Text));
            komut3.Parameters.AddWithValue("@p3", Convert.ToInt32(txtUcret.Text));
            komut3.Parameters.AddWithValue("@p4", dateTimePicker1.Value);
            komut3.Parameters.AddWithValue("@p5", int.Parse(labelid.Text));

            komut3.ExecuteNonQuery();
            MessageBox.Show("Aşı bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
            AsitakvimiGetir();
        }


        bool ikinci = false;
        private void btnAsiYapilmayan_Click(object sender, EventArgs e)
        {
            
                if (!ikinci)
                {
                    ikinci = true;
                    //1.tıklayış
                    dataGridView2.Visible = true;
                    string liste = "select hayvan_id,hayvan_ad,musteriler.musteri_id,musteriler.musteri_ad from hayvanlar join musteriler on musteriler.musteri_id=hayvanlar.musteri_id where hayvan_ad NOT IN (select hayvan_ad from asitakvimiview)";
                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(liste, baglanti);
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    dataGridView2.DataSource = dataset.Tables[0];
                    this.dataGridView2.Columns["musteri_id"].Visible = false;
                    this.dataGridView2.Columns["hayvan_id"].Visible = false;
                }

                else
                {
                    //2.tıklayış
                    string liste = "select * from asitakvimiview order by asi_tarih ";
                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(liste, baglanti);
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    dataGridView1.DataSource = dataset.Tables[0];
                    dataGridView2.Visible = false;

                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlCommand sorgu = new NpgsqlCommand("select hayvan_ad , asi_adi , asi_tutar from asitakvimiview where asi_adi like '%" + textBox1.Text + "%'", baglanti);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu);
            DataSet ds = new DataSet();
            da.Fill(ds);
            baglanti.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
