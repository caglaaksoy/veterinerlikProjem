namespace barınak
{
    partial class FormHayvanlar
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
            this.cbTur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCins = new System.Windows.Forms.ComboBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.cbAdSoyad = new System.Windows.Forms.ComboBox();
            this.labelTur = new System.Windows.Forms.Label();
            this.labelCins = new System.Windows.Forms.Label();
            this.labelKisir = new System.Windows.Forms.Label();
            this.cbKisir = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(662, 332);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(568, 482);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(387, 482);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(203, 482);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cbTur
            // 
            this.cbTur.FormattingEnabled = true;
            this.cbTur.Location = new System.Drawing.Point(323, 406);
            this.cbTur.Name = "cbTur";
            this.cbTur.Size = new System.Drawing.Size(121, 24);
            this.cbTur.TabIndex = 10;
            this.cbTur.SelectedIndexChanged += new System.EventHandler(this.cbTur_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(67, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hayvan Yaş:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(292, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tür:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(286, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cins:";
            // 
            // cbCins
            // 
            this.cbCins.FormattingEnabled = true;
            this.cbCins.Location = new System.Drawing.Point(323, 446);
            this.cbCins.Name = "cbCins";
            this.cbCins.Size = new System.Drawing.Size(121, 24);
            this.cbCins.TabIndex = 15;
            this.cbCins.SelectedIndexChanged += new System.EventHandler(this.cbCins_SelectedIndexChanged);
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(154, 422);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(100, 22);
            this.txtYas.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(530, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Müşteri :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(75, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Hayvan Ad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(154, 392);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 21;
            // 
            // cbAdSoyad
            // 
            this.cbAdSoyad.FormattingEnabled = true;
            this.cbAdSoyad.Location = new System.Drawing.Point(606, 392);
            this.cbAdSoyad.Name = "cbAdSoyad";
            this.cbAdSoyad.Size = new System.Drawing.Size(100, 24);
            this.cbAdSoyad.TabIndex = 27;
            this.cbAdSoyad.SelectedIndexChanged += new System.EventHandler(this.cbAdSoyad_SelectedIndexChanged);
            // 
            // labelTur
            // 
            this.labelTur.AutoSize = true;
            this.labelTur.ForeColor = System.Drawing.Color.Black;
            this.labelTur.Location = new System.Drawing.Point(365, 387);
            this.labelTur.Name = "labelTur";
            this.labelTur.Size = new System.Drawing.Size(44, 16);
            this.labelTur.TabIndex = 30;
            this.labelTur.Text = "label1";
            // 
            // labelCins
            // 
            this.labelCins.AutoSize = true;
            this.labelCins.ForeColor = System.Drawing.Color.Black;
            this.labelCins.Location = new System.Drawing.Point(365, 431);
            this.labelCins.Name = "labelCins";
            this.labelCins.Size = new System.Drawing.Size(44, 16);
            this.labelCins.TabIndex = 31;
            this.labelCins.Text = "label7";
            // 
            // labelKisir
            // 
            this.labelKisir.AutoSize = true;
            this.labelKisir.ForeColor = System.Drawing.Color.Black;
            this.labelKisir.Location = new System.Drawing.Point(712, 398);
            this.labelKisir.Name = "labelKisir";
            this.labelKisir.Size = new System.Drawing.Size(44, 16);
            this.labelKisir.TabIndex = 32;
            this.labelKisir.Text = "label7";
            // 
            // cbKisir
            // 
            this.cbKisir.FormattingEnabled = true;
            this.cbKisir.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cbKisir.Location = new System.Drawing.Point(606, 422);
            this.cbKisir.Name = "cbKisir";
            this.cbKisir.Size = new System.Drawing.Size(100, 24);
            this.cbKisir.TabIndex = 33;
            this.cbKisir.SelectedIndexChanged += new System.EventHandler(this.cbKisir_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(472, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Kısırlaştırma Durumu";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.ForeColor = System.Drawing.Color.Black;
            this.labelid.Location = new System.Drawing.Point(333, 463);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(0, 16);
            this.labelid.TabIndex = 35;
            this.labelid.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(154, 451);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 36;
            this.txtID.Visible = false;
            // 
            // FormHayvanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(81)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(782, 517);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKisir);
            this.Controls.Add(this.labelKisir);
            this.Controls.Add(this.labelCins);
            this.Controls.Add(this.labelTur);
            this.Controls.Add(this.cbAdSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.cbCins);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTur);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHayvanlar";
            this.Text = "FormHayvanlar";
            this.Load += new System.EventHandler(this.FormHayvanlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cbTur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCins;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.ComboBox cbAdSoyad;
        private System.Windows.Forms.Label labelTur;
        private System.Windows.Forms.Label labelCins;
        private System.Windows.Forms.Label labelKisir;
        private System.Windows.Forms.ComboBox cbKisir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.TextBox txtID;
    }
}