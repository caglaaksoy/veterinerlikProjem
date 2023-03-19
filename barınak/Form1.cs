using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barınak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbvet; user Id= postgres; password=cagla12");
        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
          //  WindowState = FormWindowState.Maximized;  // !!!! sekmeyi büyütme kodu ama aynı oranda büyümesini sağla
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                baglanti.Open();
                string liste = "Select admin_ad,admin_sifre from admin where admin_ad=@p1 and admin_sifre=@p2";
                NpgsqlParameter prmt1 = new NpgsqlParameter("p1", txtadminad.Text.Trim());
                NpgsqlParameter prmt2 = new NpgsqlParameter("p2", txtadminsifre.Text.Trim());
                NpgsqlCommand komut = new NpgsqlCommand(liste,baglanti);
                komut.Parameters.Add(prmt1);
                komut.Parameters.Add(prmt2);
                DataTable dt = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0 )
                {
                    veterinerAnaForm vaf = new veterinerAnaForm();
                    vaf.Show();
                    this.Hide();
                }
                
                
            }
            catch(Exception)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız");
                baglanti.Close();
            }


        }
    }
}
