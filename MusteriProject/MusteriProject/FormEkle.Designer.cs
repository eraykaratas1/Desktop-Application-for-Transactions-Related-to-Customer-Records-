
namespace MusteriProject
{
    partial class FormEkle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAramaEkran = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEkleMusteriNo = new System.Windows.Forms.TextBox();
            this.txtEkleAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEkleSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEkleKampanya = new System.Windows.Forms.ComboBox();
            this.txtEkleKaynak = new System.Windows.Forms.TextBox();
            this.maskEkleKayitTarihiBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.maskEkleKayitTarihiBitis = new System.Windows.Forms.MaskedTextBox();
            this.txtEkleGorusmeSonuc = new System.Windows.Forms.TextBox();
            this.txtEkleTelefonNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEkleTemsilci = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.maskEkleAramaTarih = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnAramaEkran);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 85);
            this.panel1.TabIndex = 1;
            // 
            // btnAramaEkran
            // 
            this.btnAramaEkran.Location = new System.Drawing.Point(569, 18);
            this.btnAramaEkran.Name = "btnAramaEkran";
            this.btnAramaEkran.Size = new System.Drawing.Size(256, 55);
            this.btnAramaEkran.TabIndex = 29;
            this.btnAramaEkran.Text = "Arama Ekranına Dön";
            this.btnAramaEkran.UseVisualStyleBackColor = true;
            this.btnAramaEkran.Click += new System.EventHandler(this.btnAramaEkran_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÜŞTERİ EKLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri No:";
            // 
            // txtEkleMusteriNo
            // 
            this.txtEkleMusteriNo.Location = new System.Drawing.Point(309, 117);
            this.txtEkleMusteriNo.Name = "txtEkleMusteriNo";
            this.txtEkleMusteriNo.Size = new System.Drawing.Size(254, 36);
            this.txtEkleMusteriNo.TabIndex = 3;
            // 
            // txtEkleAd
            // 
            this.txtEkleAd.Location = new System.Drawing.Point(309, 168);
            this.txtEkleAd.Name = "txtEkleAd";
            this.txtEkleAd.Size = new System.Drawing.Size(254, 36);
            this.txtEkleAd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adı:";
            // 
            // txtEkleSoyad
            // 
            this.txtEkleSoyad.Location = new System.Drawing.Point(309, 227);
            this.txtEkleSoyad.Name = "txtEkleSoyad";
            this.txtEkleSoyad.Size = new System.Drawing.Size(254, 36);
            this.txtEkleSoyad.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Soyadı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kampanya:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kaynak:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kayıt Tarihi Başlangıcı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "Kayıt Tarihi Bitişi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(102, 506);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 29);
            this.label9.TabIndex = 10;
            this.label9.Text = "Görüşme Sonucu:";
            // 
            // cmbEkleKampanya
            // 
            this.cmbEkleKampanya.FormattingEnabled = true;
            this.cmbEkleKampanya.Location = new System.Drawing.Point(309, 444);
            this.cmbEkleKampanya.Name = "cmbEkleKampanya";
            this.cmbEkleKampanya.Size = new System.Drawing.Size(254, 36);
            this.cmbEkleKampanya.TabIndex = 17;
            // 
            // txtEkleKaynak
            // 
            this.txtEkleKaynak.Location = new System.Drawing.Point(309, 282);
            this.txtEkleKaynak.Name = "txtEkleKaynak";
            this.txtEkleKaynak.Size = new System.Drawing.Size(254, 36);
            this.txtEkleKaynak.TabIndex = 18;
            // 
            // maskEkleKayitTarihiBaslangic
            // 
            this.maskEkleKayitTarihiBaslangic.Location = new System.Drawing.Point(309, 334);
            this.maskEkleKayitTarihiBaslangic.Mask = "0000-00-00";
            this.maskEkleKayitTarihiBaslangic.Name = "maskEkleKayitTarihiBaslangic";
            this.maskEkleKayitTarihiBaslangic.Size = new System.Drawing.Size(178, 36);
            this.maskEkleKayitTarihiBaslangic.TabIndex = 19;
            // 
            // maskEkleKayitTarihiBitis
            // 
            this.maskEkleKayitTarihiBitis.Location = new System.Drawing.Point(309, 389);
            this.maskEkleKayitTarihiBitis.Mask = "0000-00-00";
            this.maskEkleKayitTarihiBitis.Name = "maskEkleKayitTarihiBitis";
            this.maskEkleKayitTarihiBitis.Size = new System.Drawing.Size(178, 36);
            this.maskEkleKayitTarihiBitis.TabIndex = 20;
            // 
            // txtEkleGorusmeSonuc
            // 
            this.txtEkleGorusmeSonuc.Location = new System.Drawing.Point(309, 499);
            this.txtEkleGorusmeSonuc.Name = "txtEkleGorusmeSonuc";
            this.txtEkleGorusmeSonuc.Size = new System.Drawing.Size(254, 36);
            this.txtEkleGorusmeSonuc.TabIndex = 21;
            // 
            // txtEkleTelefonNo
            // 
            this.txtEkleTelefonNo.Location = new System.Drawing.Point(309, 556);
            this.txtEkleTelefonNo.Name = "txtEkleTelefonNo";
            this.txtEkleTelefonNo.Size = new System.Drawing.Size(254, 36);
            this.txtEkleTelefonNo.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(161, 559);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 29);
            this.label10.TabIndex = 22;
            this.label10.Text = "Telefon No:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(145, 614);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 29);
            this.label11.TabIndex = 24;
            this.label11.Text = "Arama Tarihi:";
            // 
            // txtEkleTemsilci
            // 
            this.txtEkleTemsilci.Location = new System.Drawing.Point(309, 665);
            this.txtEkleTemsilci.Name = "txtEkleTemsilci";
            this.txtEkleTemsilci.Size = new System.Drawing.Size(254, 36);
            this.txtEkleTemsilci.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(189, 672);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 29);
            this.label12.TabIndex = 26;
            this.label12.Text = "Temsilci:";
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(340, 724);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(165, 44);
            this.btnMusteriEkle.TabIndex = 28;
            this.btnMusteriEkle.Text = "Kayıt Oluştur";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // maskEkleAramaTarih
            // 
            this.maskEkleAramaTarih.Location = new System.Drawing.Point(309, 614);
            this.maskEkleAramaTarih.Mask = "0000-00-00";
            this.maskEkleAramaTarih.Name = "maskEkleAramaTarih";
            this.maskEkleAramaTarih.Size = new System.Drawing.Size(178, 36);
            this.maskEkleAramaTarih.TabIndex = 29;
            // 
            // FormEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(838, 835);
            this.Controls.Add(this.maskEkleAramaTarih);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.txtEkleTemsilci);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEkleTelefonNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEkleGorusmeSonuc);
            this.Controls.Add(this.maskEkleKayitTarihiBitis);
            this.Controls.Add(this.maskEkleKayitTarihiBaslangic);
            this.Controls.Add(this.txtEkleKaynak);
            this.Controls.Add(this.cmbEkleKampanya);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEkleSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEkleAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEkleMusteriNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormEkle";
            this.Text = "Müşteri Ekleme Ekranı";
            this.Load += new System.EventHandler(this.FormEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEkleMusteriNo;
        private System.Windows.Forms.TextBox txtEkleAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEkleSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbEkleKampanya;
        private System.Windows.Forms.TextBox txtEkleKaynak;
        private System.Windows.Forms.MaskedTextBox maskEkleKayitTarihiBaslangic;
        private System.Windows.Forms.MaskedTextBox maskEkleKayitTarihiBitis;
        private System.Windows.Forms.TextBox txtEkleGorusmeSonuc;
        private System.Windows.Forms.TextBox txtEkleTelefonNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEkleTemsilci;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnAramaEkran;
        private System.Windows.Forms.MaskedTextBox maskEkleAramaTarih;
    }
}