namespace barınak
{
    partial class FormAsiTakvimi
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
            this.cbAsiTur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbHayvan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.labelasiturid = new System.Windows.Forms.Label();
            this.labelhayvanid = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.btnAsiYapilmayan = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick_1);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(638, 414);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(638, 443);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(638, 472);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cbAsiTur
            // 
            this.cbAsiTur.FormattingEnabled = true;
            this.cbAsiTur.Location = new System.Drawing.Point(145, 422);
            this.cbAsiTur.Name = "cbAsiTur";
            this.cbAsiTur.Size = new System.Drawing.Size(121, 24);
            this.cbAsiTur.TabIndex = 15;
            this.cbAsiTur.SelectedIndexChanged += new System.EventHandler(this.cbAsiTur_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(77, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Aşı Türü :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(70, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Aşı Tarihi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 468);
            this.dateTimePicker1.MinDate = new System.DateTime(2021, 2, 27, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.Value = new System.DateTime(2022, 12, 20, 14, 2, 32, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(364, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Hayvan Ad:";
            // 
            // cbHayvan
            // 
            this.cbHayvan.FormattingEnabled = true;
            this.cbHayvan.Location = new System.Drawing.Point(447, 422);
            this.cbHayvan.Name = "cbHayvan";
            this.cbHayvan.Size = new System.Drawing.Size(121, 24);
            this.cbHayvan.TabIndex = 23;
            this.cbHayvan.SelectedIndexChanged += new System.EventHandler(this.cbHayvan_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(364, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "İşlem Ücreti";
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(447, 467);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(121, 22);
            this.txtUcret.TabIndex = 24;
            // 
            // labelasiturid
            // 
            this.labelasiturid.AutoSize = true;
            this.labelasiturid.ForeColor = System.Drawing.Color.Black;
            this.labelasiturid.Location = new System.Drawing.Point(167, 404);
            this.labelasiturid.Name = "labelasiturid";
            this.labelasiturid.Size = new System.Drawing.Size(44, 16);
            this.labelasiturid.TabIndex = 26;
            this.labelasiturid.Text = "label3";
            this.labelasiturid.Visible = false;
            // 
            // labelhayvanid
            // 
            this.labelhayvanid.AutoSize = true;
            this.labelhayvanid.ForeColor = System.Drawing.Color.Black;
            this.labelhayvanid.Location = new System.Drawing.Point(484, 403);
            this.labelhayvanid.Name = "labelhayvanid";
            this.labelhayvanid.Size = new System.Drawing.Size(44, 16);
            this.labelhayvanid.TabIndex = 27;
            this.labelhayvanid.Text = "label3";
            this.labelhayvanid.Visible = false;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.ForeColor = System.Drawing.Color.Black;
            this.labelid.Location = new System.Drawing.Point(273, 492);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(44, 16);
            this.labelid.TabIndex = 28;
            this.labelid.Text = "label3";
            this.labelid.Visible = false;
            // 
            // btnAsiYapilmayan
            // 
            this.btnAsiYapilmayan.Location = new System.Drawing.Point(544, 12);
            this.btnAsiYapilmayan.Name = "btnAsiYapilmayan";
            this.btnAsiYapilmayan.Size = new System.Drawing.Size(177, 34);
            this.btnAsiYapilmayan.TabIndex = 30;
            this.btnAsiYapilmayan.Text = "Aşılanmamış Hayvanlar";
            this.btnAsiYapilmayan.UseVisualStyleBackColor = true;
            this.btnAsiYapilmayan.Click += new System.EventHandler(this.btnAsiYapilmayan_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(59, 47);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(662, 332);
            this.dataGridView2.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 33;
            // 
            // FormAsiTakvimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(81)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(782, 517);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnAsiYapilmayan);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.labelhayvanid);
            this.Controls.Add(this.labelasiturid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.cbHayvan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAsiTur);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAsiTakvimi";
            this.Text = "FormAsiTakvimi";
            this.Load += new System.EventHandler(this.FormAsiTakvimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cbAsiTur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbHayvan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Label labelasiturid;
        private System.Windows.Forms.Label labelhayvanid;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Button btnAsiYapilmayan;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}