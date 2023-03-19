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
    public partial class veterinerAnaForm : Form
    {
        public veterinerAnaForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormMusteriler formMusteriler= new FormMusteriler();   
            formMusteriler.TopLevel= false;
            panel2.Controls.Add(formMusteriler);
            formMusteriler.Show();
        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormHayvanlar formHayvanlar = new FormHayvanlar();
            formHayvanlar.TopLevel = false;
            panel2.Controls.Add(formHayvanlar);
            formHayvanlar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormAsiTakvimi formAsiTakvimi= new FormAsiTakvimi();
            formAsiTakvimi.TopLevel= false;
            panel2.Controls.Add(formAsiTakvimi);
            formAsiTakvimi.Show();
        }

        
        
        private void button8_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormKisirlastirma formKisirlastirma = new FormKisirlastirma();
            formKisirlastirma.TopLevel = false;
            panel2.Controls.Add(formKisirlastirma);
            formKisirlastirma.Show();
        }

       

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormRandevu formRandevu = new FormRandevu();
            formRandevu.TopLevel = false;
            panel2.Controls.Add(formRandevu);
            formRandevu.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormFatura formFatura = new FormFatura();
            formFatura.TopLevel = false;
            panel2.Controls.Add(formFatura);
            formFatura.Show();
        }
    }
}
