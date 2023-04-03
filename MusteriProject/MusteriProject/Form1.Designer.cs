
namespace MusteriProject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.txtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.txtKaynak = new System.Windows.Forms.TextBox();
            this.cmbKampanya = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.custKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kaynakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitTarihiBaslangiciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitTarihiBitisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kampanyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorusmeSonucuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aramaTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temsilciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMusteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbMusteriDataSet = new MusteriProject.DbMusteriDataSet();
            this.tbl_MusteriTableAdapter = new MusteriProject.DbMusteriDataSetTableAdapters.Tbl_MusteriTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtKayitTarihiBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.txtKayitTarihiBitis = new System.Windows.Forms.MaskedTextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSonucSil = new System.Windows.Forms.Button();
            this.btnArama = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelleSil = new System.Windows.Forms.Button();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMusteriDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnCikisYap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1868, 85);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÜŞTERİ ARAMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Müşteri No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Soyadı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kampanya:";
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.Location = new System.Drawing.Point(231, 115);
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.Size = new System.Drawing.Size(244, 36);
            this.txtMusteriNo.TabIndex = 5;
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Location = new System.Drawing.Point(231, 193);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(244, 36);
            this.txtMusteriAd.TabIndex = 6;
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.Location = new System.Drawing.Point(231, 268);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(244, 36);
            this.txtMusteriSoyad.TabIndex = 7;
            // 
            // txtKaynak
            // 
            this.txtKaynak.Location = new System.Drawing.Point(784, 121);
            this.txtKaynak.Name = "txtKaynak";
            this.txtKaynak.Size = new System.Drawing.Size(250, 36);
            this.txtKaynak.TabIndex = 8;
            // 
            // cmbKampanya
            // 
            this.cmbKampanya.FormattingEnabled = true;
            this.cmbKampanya.Location = new System.Drawing.Point(231, 352);
            this.cmbKampanya.Name = "cmbKampanya";
            this.cmbKampanya.Size = new System.Drawing.Size(244, 36);
            this.cmbKampanya.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(664, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kaynak:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(520, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "Kayıt Tarihi Başlangıcı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(573, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "Kayıt Tarihi Bitişi:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custKeyDataGridViewTextBoxColumn,
            this.musteriNoDataGridViewTextBoxColumn,
            this.adıDataGridViewTextBoxColumn,
            this.soyadıDataGridViewTextBoxColumn,
            this.kaynakDataGridViewTextBoxColumn,
            this.kayitTarihiBaslangiciDataGridViewTextBoxColumn,
            this.kayitTarihiBitisiDataGridViewTextBoxColumn,
            this.kampanyaDataGridViewTextBoxColumn,
            this.gorusmeSonucuDataGridViewTextBoxColumn,
            this.telefonNoDataGridViewTextBoxColumn,
            this.aramaTarihiDataGridViewTextBoxColumn,
            this.temsilciDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblMusteriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 467);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1556, 152);
            this.dataGridView1.TabIndex = 15;
            // 
            // custKeyDataGridViewTextBoxColumn
            // 
            this.custKeyDataGridViewTextBoxColumn.DataPropertyName = "CustKey";
            this.custKeyDataGridViewTextBoxColumn.HeaderText = "CustKey";
            this.custKeyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custKeyDataGridViewTextBoxColumn.Name = "custKeyDataGridViewTextBoxColumn";
            this.custKeyDataGridViewTextBoxColumn.ReadOnly = true;
            this.custKeyDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriNoDataGridViewTextBoxColumn
            // 
            this.musteriNoDataGridViewTextBoxColumn.DataPropertyName = "MusteriNo";
            this.musteriNoDataGridViewTextBoxColumn.HeaderText = "MusteriNo";
            this.musteriNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriNoDataGridViewTextBoxColumn.Name = "musteriNoDataGridViewTextBoxColumn";
            this.musteriNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // adıDataGridViewTextBoxColumn
            // 
            this.adıDataGridViewTextBoxColumn.DataPropertyName = "Adı";
            this.adıDataGridViewTextBoxColumn.HeaderText = "Adı";
            this.adıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adıDataGridViewTextBoxColumn.Name = "adıDataGridViewTextBoxColumn";
            this.adıDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadıDataGridViewTextBoxColumn
            // 
            this.soyadıDataGridViewTextBoxColumn.DataPropertyName = "Soyadı";
            this.soyadıDataGridViewTextBoxColumn.HeaderText = "Soyadı";
            this.soyadıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadıDataGridViewTextBoxColumn.Name = "soyadıDataGridViewTextBoxColumn";
            this.soyadıDataGridViewTextBoxColumn.Width = 125;
            // 
            // kaynakDataGridViewTextBoxColumn
            // 
            this.kaynakDataGridViewTextBoxColumn.DataPropertyName = "Kaynak";
            this.kaynakDataGridViewTextBoxColumn.HeaderText = "Kaynak";
            this.kaynakDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kaynakDataGridViewTextBoxColumn.Name = "kaynakDataGridViewTextBoxColumn";
            this.kaynakDataGridViewTextBoxColumn.Width = 125;
            // 
            // kayitTarihiBaslangiciDataGridViewTextBoxColumn
            // 
            this.kayitTarihiBaslangiciDataGridViewTextBoxColumn.DataPropertyName = "KayitTarihiBaslangici";
            this.kayitTarihiBaslangiciDataGridViewTextBoxColumn.HeaderText = "KayitTarihiBaslangici";
            this.kayitTarihiBaslangiciDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kayitTarihiBaslangiciDataGridViewTextBoxColumn.Name = "kayitTarihiBaslangiciDataGridViewTextBoxColumn";
            this.kayitTarihiBaslangiciDataGridViewTextBoxColumn.Width = 125;
            // 
            // kayitTarihiBitisiDataGridViewTextBoxColumn
            // 
            this.kayitTarihiBitisiDataGridViewTextBoxColumn.DataPropertyName = "KayitTarihiBitisi";
            this.kayitTarihiBitisiDataGridViewTextBoxColumn.HeaderText = "KayitTarihiBitisi";
            this.kayitTarihiBitisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kayitTarihiBitisiDataGridViewTextBoxColumn.Name = "kayitTarihiBitisiDataGridViewTextBoxColumn";
            this.kayitTarihiBitisiDataGridViewTextBoxColumn.Width = 125;
            // 
            // kampanyaDataGridViewTextBoxColumn
            // 
            this.kampanyaDataGridViewTextBoxColumn.DataPropertyName = "Kampanya";
            this.kampanyaDataGridViewTextBoxColumn.HeaderText = "Kampanya";
            this.kampanyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kampanyaDataGridViewTextBoxColumn.Name = "kampanyaDataGridViewTextBoxColumn";
            this.kampanyaDataGridViewTextBoxColumn.Width = 125;
            // 
            // gorusmeSonucuDataGridViewTextBoxColumn
            // 
            this.gorusmeSonucuDataGridViewTextBoxColumn.DataPropertyName = "GorusmeSonucu";
            this.gorusmeSonucuDataGridViewTextBoxColumn.HeaderText = "GorusmeSonucu";
            this.gorusmeSonucuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gorusmeSonucuDataGridViewTextBoxColumn.Name = "gorusmeSonucuDataGridViewTextBoxColumn";
            this.gorusmeSonucuDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonNoDataGridViewTextBoxColumn
            // 
            this.telefonNoDataGridViewTextBoxColumn.DataPropertyName = "TelefonNo";
            this.telefonNoDataGridViewTextBoxColumn.HeaderText = "TelefonNo";
            this.telefonNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonNoDataGridViewTextBoxColumn.Name = "telefonNoDataGridViewTextBoxColumn";
            this.telefonNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // aramaTarihiDataGridViewTextBoxColumn
            // 
            this.aramaTarihiDataGridViewTextBoxColumn.DataPropertyName = "AramaTarihi";
            this.aramaTarihiDataGridViewTextBoxColumn.HeaderText = "AramaTarihi";
            this.aramaTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aramaTarihiDataGridViewTextBoxColumn.Name = "aramaTarihiDataGridViewTextBoxColumn";
            this.aramaTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // temsilciDataGridViewTextBoxColumn
            // 
            this.temsilciDataGridViewTextBoxColumn.DataPropertyName = "Temsilci";
            this.temsilciDataGridViewTextBoxColumn.HeaderText = "Temsilci";
            this.temsilciDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.temsilciDataGridViewTextBoxColumn.Name = "temsilciDataGridViewTextBoxColumn";
            this.temsilciDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblMusteriBindingSource
            // 
            this.tblMusteriBindingSource.DataMember = "Tbl_Musteri";
            this.tblMusteriBindingSource.DataSource = this.dbMusteriDataSet;
            // 
            // dbMusteriDataSet
            // 
            this.dbMusteriDataSet.DataSetName = "DbMusteriDataSet";
            this.dbMusteriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_MusteriTableAdapter
            // 
            this.tbl_MusteriTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label9.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(651, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(306, 40);
            this.label9.TabIndex = 16;
            this.label9.Text = "MÜŞTERİ BİLGİLERİ";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(1124, 115);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(399, 53);
            this.btnListele.TabIndex = 18;
            this.btnListele.Text = "Tüm Kayıtları Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtKayitTarihiBaslangic
            // 
            this.txtKayitTarihiBaslangic.Location = new System.Drawing.Point(784, 207);
            this.txtKayitTarihiBaslangic.Mask = "0000-00-00";
            this.txtKayitTarihiBaslangic.Name = "txtKayitTarihiBaslangic";
            this.txtKayitTarihiBaslangic.Size = new System.Drawing.Size(133, 36);
            this.txtKayitTarihiBaslangic.TabIndex = 20;
            // 
            // txtKayitTarihiBitis
            // 
            this.txtKayitTarihiBitis.Location = new System.Drawing.Point(784, 289);
            this.txtKayitTarihiBitis.Mask = "0000-00-00";
            this.txtKayitTarihiBitis.Name = "txtKayitTarihiBitis";
            this.txtKayitTarihiBitis.Size = new System.Drawing.Size(133, 36);
            this.txtKayitTarihiBitis.TabIndex = 21;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(824, 339);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(241, 68);
            this.btnTemizle.TabIndex = 22;
            this.btnTemizle.Text = "Alanları Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSonucSil
            // 
            this.btnSonucSil.Location = new System.Drawing.Point(1124, 389);
            this.btnSonucSil.Name = "btnSonucSil";
            this.btnSonucSil.Size = new System.Drawing.Size(399, 59);
            this.btnSonucSil.TabIndex = 23;
            this.btnSonucSil.Text = "Arama Sonuçlarını Temizle";
            this.btnSonucSil.UseVisualStyleBackColor = true;
            this.btnSonucSil.Click += new System.EventHandler(this.btnSonucSil_Click);
            // 
            // btnArama
            // 
            this.btnArama.Location = new System.Drawing.Point(535, 339);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(246, 68);
            this.btnArama.TabIndex = 24;
            this.btnArama.Text = "Girilen Kayıdı Listele";
            this.btnArama.UseVisualStyleBackColor = true;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(1124, 210);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(399, 53);
            this.btnEkle.TabIndex = 25;
            this.btnEkle.Text = "Kayıt Oluştur";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelleSil
            // 
            this.btnGuncelleSil.Location = new System.Drawing.Point(1124, 301);
            this.btnGuncelleSil.Name = "btnGuncelleSil";
            this.btnGuncelleSil.Size = new System.Drawing.Size(399, 53);
            this.btnGuncelleSil.TabIndex = 26;
            this.btnGuncelleSil.Text = "Kayıt Güncelle - Sil";
            this.btnGuncelleSil.UseVisualStyleBackColor = true;
            this.btnGuncelleSil.Click += new System.EventHandler(this.btnGuncelleSil_Click);
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.Location = new System.Drawing.Point(1281, 20);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(207, 50);
            this.btnCikisYap.TabIndex = 27;
            this.btnCikisYap.Text = "Çıkış Yap";
            this.btnCikisYap.UseVisualStyleBackColor = true;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1559, 620);
            this.Controls.Add(this.btnGuncelleSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.btnSonucSil);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txtKayitTarihiBitis);
            this.Controls.Add(this.txtKayitTarihiBaslangic);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbKampanya);
            this.Controls.Add(this.txtKaynak);
            this.Controls.Add(this.txtMusteriSoyad);
            this.Controls.Add(this.txtMusteriAd);
            this.Controls.Add(this.txtMusteriNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Müşteri Arama Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMusteriDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.TextBox txtMusteriSoyad;
        private System.Windows.Forms.TextBox txtKaynak;
        private System.Windows.Forms.ComboBox cmbKampanya;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbMusteriDataSet dbMusteriDataSet;
        private System.Windows.Forms.BindingSource tblMusteriBindingSource;
        private DbMusteriDataSetTableAdapters.Tbl_MusteriTableAdapter tbl_MusteriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn custKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kaynakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitTarihiBaslangiciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitTarihiBitisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kampanyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorusmeSonucuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aramaTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temsilciDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.MaskedTextBox txtKayitTarihiBaslangic;
        private System.Windows.Forms.MaskedTextBox txtKayitTarihiBitis;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSonucSil;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelleSil;
        private System.Windows.Forms.Button btnCikisYap;
    }
}

