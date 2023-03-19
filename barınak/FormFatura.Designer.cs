namespace barınak
{
    partial class FormFatura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cbHayvan = new System.Windows.Forms.ComboBox();
            this.cbMusteri = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbAsi = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTutar = new System.Windows.Forms.TextBox();
            this.labelhayvanid = new System.Windows.Forms.Label();
            this.labelmusid = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbKisirlastirma = new System.Windows.Forms.RadioButton();
            this.labelasitutar = new System.Windows.Forms.Label();
            this.labelkisirtutar = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.labelkisirid = new System.Windows.Forms.Label();
            this.labelasiid = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(662, 332);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(701, 449);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(620, 449);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(539, 449);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cbHayvan
            // 
            this.cbHayvan.FormattingEnabled = true;
            this.cbHayvan.Location = new System.Drawing.Point(126, 440);
            this.cbHayvan.Name = "cbHayvan";
            this.cbHayvan.Size = new System.Drawing.Size(121, 24);
            this.cbHayvan.TabIndex = 10;
            this.cbHayvan.SelectedIndexChanged += new System.EventHandler(this.cbHayvan_SelectedIndexChanged);
            // 
            // cbMusteri
            // 
            this.cbMusteri.FormattingEnabled = true;
            this.cbMusteri.Location = new System.Drawing.Point(126, 385);
            this.cbMusteri.Name = "cbMusteri";
            this.cbMusteri.Size = new System.Drawing.Size(121, 24);
            this.cbMusteri.TabIndex = 11;
            this.cbMusteri.SelectedIndexChanged += new System.EventHandler(this.cbMusteri_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(55, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hayvan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(59, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Müşteri";
            // 
            // rbAsi
            // 
            this.rbAsi.AutoSize = true;
            this.rbAsi.ForeColor = System.Drawing.Color.Black;
            this.rbAsi.Location = new System.Drawing.Point(9, 9);
            this.rbAsi.Name = "rbAsi";
            this.rbAsi.Size = new System.Drawing.Size(100, 20);
            this.rbAsi.TabIndex = 14;
            this.rbAsi.Text = "Aşı İşlemleri";
            this.rbAsi.UseVisualStyleBackColor = true;
            this.rbAsi.CheckedChanged += new System.EventHandler(this.rbAsi_CheckedChanged);
            this.rbAsi.Click += new System.EventHandler(this.rbAsi_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(333, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Yapılan İşlemler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(520, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Toplam Tutar";
            // 
            // tbTutar
            // 
            this.tbTutar.Location = new System.Drawing.Point(614, 385);
            this.tbTutar.Name = "tbTutar";
            this.tbTutar.Size = new System.Drawing.Size(100, 22);
            this.tbTutar.TabIndex = 18;
            // 
            // labelhayvanid
            // 
            this.labelhayvanid.AutoSize = true;
            this.labelhayvanid.ForeColor = System.Drawing.Color.Black;
            this.labelhayvanid.Location = new System.Drawing.Point(253, 449);
            this.labelhayvanid.Name = "labelhayvanid";
            this.labelhayvanid.Size = new System.Drawing.Size(44, 16);
            this.labelhayvanid.TabIndex = 19;
            this.labelhayvanid.Text = "label5";
            // 
            // labelmusid
            // 
            this.labelmusid.AutoSize = true;
            this.labelmusid.ForeColor = System.Drawing.Color.Black;
            this.labelmusid.Location = new System.Drawing.Point(253, 391);
            this.labelmusid.Name = "labelmusid";
            this.labelmusid.Size = new System.Drawing.Size(44, 16);
            this.labelmusid.TabIndex = 20;
            this.labelmusid.Text = "label6";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAsi);
            this.groupBox1.Location = new System.Drawing.Point(312, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 32);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbKisirlastirma);
            this.groupBox2.Location = new System.Drawing.Point(312, 444);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 32);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // rbKisirlastirma
            // 
            this.rbKisirlastirma.AutoSize = true;
            this.rbKisirlastirma.ForeColor = System.Drawing.Color.Black;
            this.rbKisirlastirma.Location = new System.Drawing.Point(5, 9);
            this.rbKisirlastirma.Name = "rbKisirlastirma";
            this.rbKisirlastirma.Size = new System.Drawing.Size(153, 20);
            this.rbKisirlastirma.TabIndex = 16;
            this.rbKisirlastirma.Text = "Kısırlaştırma İşlemleri";
            this.rbKisirlastirma.UseVisualStyleBackColor = true;
            this.rbKisirlastirma.CheckedChanged += new System.EventHandler(this.rbKisirlastirma_CheckedChanged);
            this.rbKisirlastirma.Click += new System.EventHandler(this.rbKisirlastirma_Click);
            // 
            // labelasitutar
            // 
            this.labelasitutar.AutoSize = true;
            this.labelasitutar.ForeColor = System.Drawing.Color.Black;
            this.labelasitutar.Location = new System.Drawing.Point(564, 419);
            this.labelasitutar.Name = "labelasitutar";
            this.labelasitutar.Size = new System.Drawing.Size(44, 16);
            this.labelasitutar.TabIndex = 23;
            this.labelasitutar.Text = "label6";
            // 
            // labelkisirtutar
            // 
            this.labelkisirtutar.AutoSize = true;
            this.labelkisirtutar.ForeColor = System.Drawing.Color.Black;
            this.labelkisirtutar.Location = new System.Drawing.Point(631, 418);
            this.labelkisirtutar.Name = "labelkisirtutar";
            this.labelkisirtutar.Size = new System.Drawing.Size(44, 16);
            this.labelkisirtutar.TabIndex = 24;
            this.labelkisirtutar.Text = "label6";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(346, 482);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 25;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // labelkisirid
            // 
            this.labelkisirid.AutoSize = true;
            this.labelkisirid.ForeColor = System.Drawing.Color.Black;
            this.labelkisirid.Location = new System.Drawing.Point(489, 452);
            this.labelkisirid.Name = "labelkisirid";
            this.labelkisirid.Size = new System.Drawing.Size(44, 16);
            this.labelkisirid.TabIndex = 26;
            this.labelkisirid.Text = "label6";
            // 
            // labelasiid
            // 
            this.labelasiid.AutoSize = true;
            this.labelasiid.ForeColor = System.Drawing.Color.Black;
            this.labelasiid.Location = new System.Drawing.Point(489, 409);
            this.labelasiid.Name = "labelasiid";
            this.labelasiid.Size = new System.Drawing.Size(44, 16);
            this.labelasiid.TabIndex = 27;
            this.labelasiid.Text = "label6";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.ForeColor = System.Drawing.Color.Black;
            this.labelid.Location = new System.Drawing.Point(56, 28);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(14, 16);
            this.labelid.TabIndex = 28;
            this.labelid.Text = "0";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(47, 480);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // FormFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(81)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(782, 517);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.labelasiid);
            this.Controls.Add(this.labelkisirid);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.labelkisirtutar);
            this.Controls.Add(this.labelasitutar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelmusid);
            this.Controls.Add(this.labelhayvanid);
            this.Controls.Add(this.tbTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMusteri);
            this.Controls.Add(this.cbHayvan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFatura";
            this.Load += new System.EventHandler(this.FormFatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cbHayvan;
        private System.Windows.Forms.ComboBox cbMusteri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbAsi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTutar;
        private System.Windows.Forms.Label labelhayvanid;
        private System.Windows.Forms.Label labelmusid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbKisirlastirma;
        private System.Windows.Forms.Label labelasitutar;
        private System.Windows.Forms.Label labelkisirtutar;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label labelkisirid;
        private System.Windows.Forms.Label labelasiid;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}