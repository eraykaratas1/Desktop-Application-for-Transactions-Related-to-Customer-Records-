
namespace MusteriProject
{
    partial class FormGuncelleSil
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
            this.btnAramaEkranDon = new System.Windows.Forms.Button();
            this.cmbGuncelleSilKampanya = new System.Windows.Forms.ComboBox();
            this.txtGuncelleSilSoyad = new System.Windows.Forms.TextBox();
            this.txtGuncelleSilAd = new System.Windows.Forms.TextBox();
            this.txtGuncelleSilMusteriNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGuncelleSilKaynak = new System.Windows.Forms.TextBox();
            this.maskGuncelleSilKayitTarihiBitis = new System.Windows.Forms.MaskedTextBox();
            this.maskGuncelleSilKayitTarihiBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGuncelleSilTemsilci = new System.Windows.Forms.TextBox();
            this.txtGuncelleSilTelefonNo = new System.Windows.Forms.TextBox();
            this.txtGuncelleSilGorusmeSonuc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
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
            this.dbMusteriDataSet1 = new MusteriProject.DbMusteriDataSet1();
            this.tbl_MusteriTableAdapter = new MusteriProject.DbMusteriDataSet1TableAdapters.Tbl_MusteriTableAdapter();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelleSilListele = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGuncelleSilCustKey = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.maskGuncelleSilAramaTarih = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMusteriDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAramaEkranDon);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1566, 85);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÜŞTERİ GÜNCELLE SİL";
            // 
            // btnAramaEkranDon
            // 
            this.btnAramaEkranDon.Location = new System.Drawing.Point(1211, 11);
            this.btnAramaEkranDon.Name = "btnAramaEkranDon";
            this.btnAramaEkranDon.Size = new System.Drawing.Size(245, 60);
            this.btnAramaEkranDon.TabIndex = 30;
            this.btnAramaEkranDon.Text = "Arama Ekranına Dön";
            this.btnAramaEkranDon.UseVisualStyleBackColor = true;
            this.btnAramaEkranDon.Click += new System.EventHandler(this.btnAramaEkranDon_Click);
            // 
            // cmbGuncelleSilKampanya
            // 
            this.cmbGuncelleSilKampanya.FormattingEnabled = true;
            this.cmbGuncelleSilKampanya.Location = new System.Drawing.Point(845, 163);
            this.cmbGuncelleSilKampanya.Name = "cmbGuncelleSilKampanya";
            this.cmbGuncelleSilKampanya.Size = new System.Drawing.Size(244, 36);
            this.cmbGuncelleSilKampanya.TabIndex = 38;
            // 
            // txtGuncelleSilSoyad
            // 
            this.txtGuncelleSilSoyad.Location = new System.Drawing.Point(314, 289);
            this.txtGuncelleSilSoyad.Name = "txtGuncelleSilSoyad";
            this.txtGuncelleSilSoyad.Size = new System.Drawing.Size(244, 36);
            this.txtGuncelleSilSoyad.TabIndex = 37;
            // 
            // txtGuncelleSilAd
            // 
            this.txtGuncelleSilAd.Location = new System.Drawing.Point(314, 227);
            this.txtGuncelleSilAd.Name = "txtGuncelleSilAd";
            this.txtGuncelleSilAd.Size = new System.Drawing.Size(244, 36);
            this.txtGuncelleSilAd.TabIndex = 36;
            // 
            // txtGuncelleSilMusteriNo
            // 
            this.txtGuncelleSilMusteriNo.Location = new System.Drawing.Point(314, 167);
            this.txtGuncelleSilMusteriNo.Name = "txtGuncelleSilMusteriNo";
            this.txtGuncelleSilMusteriNo.Size = new System.Drawing.Size(244, 36);
            this.txtGuncelleSilMusteriNo.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 29);
            this.label4.TabIndex = 34;
            this.label4.Text = "Soyadı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(652, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 29);
            this.label5.TabIndex = 33;
            this.label5.Text = "Kampanya:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 29);
            this.label3.TabIndex = 32;
            this.label3.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "Müşteri No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 29);
            this.label6.TabIndex = 40;
            this.label6.Text = "Kaynak:";
            // 
            // txtGuncelleSilKaynak
            // 
            this.txtGuncelleSilKaynak.Location = new System.Drawing.Point(314, 348);
            this.txtGuncelleSilKaynak.Name = "txtGuncelleSilKaynak";
            this.txtGuncelleSilKaynak.Size = new System.Drawing.Size(250, 36);
            this.txtGuncelleSilKaynak.TabIndex = 39;
            // 
            // maskGuncelleSilKayitTarihiBitis
            // 
            this.maskGuncelleSilKayitTarihiBitis.Location = new System.Drawing.Point(845, 107);
            this.maskGuncelleSilKayitTarihiBitis.Mask = "0000-00-00";
            this.maskGuncelleSilKayitTarihiBitis.Name = "maskGuncelleSilKayitTarihiBitis";
            this.maskGuncelleSilKayitTarihiBitis.Size = new System.Drawing.Size(133, 36);
            this.maskGuncelleSilKayitTarihiBitis.TabIndex = 44;
            // 
            // maskGuncelleSilKayitTarihiBaslangic
            // 
            this.maskGuncelleSilKayitTarihiBaslangic.Location = new System.Drawing.Point(314, 407);
            this.maskGuncelleSilKayitTarihiBaslangic.Mask = "0000-00-00";
            this.maskGuncelleSilKayitTarihiBaslangic.Name = "maskGuncelleSilKayitTarihiBaslangic";
            this.maskGuncelleSilKayitTarihiBaslangic.Size = new System.Drawing.Size(133, 36);
            this.maskGuncelleSilKayitTarihiBaslangic.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(594, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 29);
            this.label8.TabIndex = 42;
            this.label8.Text = "Kayıt Tarihi Bitişi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 29);
            this.label7.TabIndex = 41;
            this.label7.Text = "Kayıt Tarihi Başlangıcı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(679, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 29);
            this.label9.TabIndex = 52;
            this.label9.Text = "Temsilci:";
            // 
            // txtGuncelleSilTemsilci
            // 
            this.txtGuncelleSilTemsilci.Location = new System.Drawing.Point(845, 406);
            this.txtGuncelleSilTemsilci.Name = "txtGuncelleSilTemsilci";
            this.txtGuncelleSilTemsilci.Size = new System.Drawing.Size(244, 36);
            this.txtGuncelleSilTemsilci.TabIndex = 51;
            // 
            // txtGuncelleSilTelefonNo
            // 
            this.txtGuncelleSilTelefonNo.Location = new System.Drawing.Point(845, 288);
            this.txtGuncelleSilTelefonNo.Name = "txtGuncelleSilTelefonNo";
            this.txtGuncelleSilTelefonNo.Size = new System.Drawing.Size(244, 36);
            this.txtGuncelleSilTelefonNo.TabIndex = 49;
            // 
            // txtGuncelleSilGorusmeSonuc
            // 
            this.txtGuncelleSilGorusmeSonuc.Location = new System.Drawing.Point(845, 229);
            this.txtGuncelleSilGorusmeSonuc.Name = "txtGuncelleSilGorusmeSonuc";
            this.txtGuncelleSilGorusmeSonuc.Size = new System.Drawing.Size(244, 36);
            this.txtGuncelleSilGorusmeSonuc.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(636, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 29);
            this.label10.TabIndex = 47;
            this.label10.Text = "Arama Tarihi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(594, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 29);
            this.label12.TabIndex = 45;
            this.label12.Text = "Görüşme Sonucu:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label13.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(525, 449);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(306, 40);
            this.label13.TabIndex = 55;
            this.label13.Text = "MÜŞTERİ BİLGİLERİ";
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 494);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1566, 113);
            this.dataGridView1.TabIndex = 56;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            this.tblMusteriBindingSource.DataSource = this.dbMusteriDataSet1;
            // 
            // dbMusteriDataSet1
            // 
            this.dbMusteriDataSet1.DataSetName = "DbMusteriDataSet1";
            this.dbMusteriDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_MusteriTableAdapter
            // 
            this.tbl_MusteriTableAdapter.ClearBeforeFill = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(1134, 240);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(364, 63);
            this.btnGuncelle.TabIndex = 57;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(1134, 348);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(364, 63);
            this.btnSil.TabIndex = 58;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelleSilListele
            // 
            this.btnGuncelleSilListele.Location = new System.Drawing.Point(1134, 133);
            this.btnGuncelleSilListele.Name = "btnGuncelleSilListele";
            this.btnGuncelleSilListele.Size = new System.Drawing.Size(364, 63);
            this.btnGuncelleSilListele.TabIndex = 59;
            this.btnGuncelleSilListele.Text = "Tüm Kayıtları Listele";
            this.btnGuncelleSilListele.UseVisualStyleBackColor = true;
            this.btnGuncelleSilListele.Click += new System.EventHandler(this.btnGuncelleSilListele_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(651, 291);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 29);
            this.label11.TabIndex = 60;
            this.label11.Text = "Telefon No:";
            // 
            // txtGuncelleSilCustKey
            // 
            this.txtGuncelleSilCustKey.Location = new System.Drawing.Point(314, 110);
            this.txtGuncelleSilCustKey.Name = "txtGuncelleSilCustKey";
            this.txtGuncelleSilCustKey.Size = new System.Drawing.Size(244, 36);
            this.txtGuncelleSilCustKey.TabIndex = 62;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(139, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 29);
            this.label14.TabIndex = 61;
            this.label14.Text = "CustKey:";
            // 
            // maskGuncelleSilAramaTarih
            // 
            this.maskGuncelleSilAramaTarih.Location = new System.Drawing.Point(845, 345);
            this.maskGuncelleSilAramaTarih.Mask = "0000-00-00";
            this.maskGuncelleSilAramaTarih.Name = "maskGuncelleSilAramaTarih";
            this.maskGuncelleSilAramaTarih.Size = new System.Drawing.Size(133, 36);
            this.maskGuncelleSilAramaTarih.TabIndex = 63;
            // 
            // FormGuncelleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1566, 608);
            this.Controls.Add(this.maskGuncelleSilAramaTarih);
            this.Controls.Add(this.txtGuncelleSilCustKey);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnGuncelleSilListele);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtGuncelleSilTemsilci);
            this.Controls.Add(this.txtGuncelleSilTelefonNo);
            this.Controls.Add(this.txtGuncelleSilGorusmeSonuc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.maskGuncelleSilKayitTarihiBitis);
            this.Controls.Add(this.maskGuncelleSilKayitTarihiBaslangic);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGuncelleSilKaynak);
            this.Controls.Add(this.cmbGuncelleSilKampanya);
            this.Controls.Add(this.txtGuncelleSilSoyad);
            this.Controls.Add(this.txtGuncelleSilAd);
            this.Controls.Add(this.txtGuncelleSilMusteriNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormGuncelleSil";
            this.Text = "Müşteri Güncelle-Sil Ekranı";
            this.Load += new System.EventHandler(this.FormGuncelleSil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMusteriDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAramaEkranDon;
        private System.Windows.Forms.ComboBox cmbGuncelleSilKampanya;
        private System.Windows.Forms.TextBox txtGuncelleSilSoyad;
        private System.Windows.Forms.TextBox txtGuncelleSilAd;
        private System.Windows.Forms.TextBox txtGuncelleSilMusteriNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGuncelleSilKaynak;
        private System.Windows.Forms.MaskedTextBox maskGuncelleSilKayitTarihiBitis;
        private System.Windows.Forms.MaskedTextBox maskGuncelleSilKayitTarihiBaslangic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGuncelleSilTemsilci;
        private System.Windows.Forms.TextBox txtGuncelleSilTelefonNo;
        private System.Windows.Forms.TextBox txtGuncelleSilGorusmeSonuc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbMusteriDataSet1 dbMusteriDataSet1;
        private System.Windows.Forms.BindingSource tblMusteriBindingSource;
        private DbMusteriDataSet1TableAdapters.Tbl_MusteriTableAdapter tbl_MusteriTableAdapter;
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
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelleSilListele;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGuncelleSilCustKey;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox maskGuncelleSilAramaTarih;
    }
}