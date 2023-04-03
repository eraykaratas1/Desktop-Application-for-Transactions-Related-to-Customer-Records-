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

namespace MusteriProject
{
    public partial class FormEkle : Form
    {
        public FormEkle()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-TEHP7C8\\SQLEXPRESS;Initial Catalog=DbMusteri;Integrated Security=True");

        private void btnAramaEkran_Click(object sender, EventArgs e)
        {

            Form1 fr = new Form1();
            fr.Show();
            this.Hide();


        }

        private void FormEkle_Load(object sender, EventArgs e)
        {
            connect.Open();

            SqlCommand komut = new SqlCommand("Select distinct(Kampanya) From Tbl_Musteri", connect); // comboboxa kampanyaları çektik

            SqlDataReader cmb_dr = komut.ExecuteReader();

            while (cmb_dr.Read())
            {

                cmbEkleKampanya.Items.Add(cmb_dr[0]); 

            }

            connect.Close();



        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {

            connect.Open();

            SqlCommand komut = new SqlCommand("insert into Tbl_Musteri(MusteriNo, Adı, Soyadı, Kaynak, KayitTarihiBaslangici, KayitTarihiBitisi, Kampanya, GorusmeSonucu, TelefonNo, AramaTarihi, Temsilci) values(@k1,@k2,@k3,@k4,@k5,@k6,@k7,@k8,@k9,@k10,@k11)", connect);

            komut.Parameters.AddWithValue("@k1", txtEkleMusteriNo.Text);
            komut.Parameters.AddWithValue("@k2", txtEkleAd.Text);
            komut.Parameters.AddWithValue("@k3", txtEkleSoyad.Text);
            komut.Parameters.AddWithValue("@k4", txtEkleKaynak.Text);
            komut.Parameters.AddWithValue("@k5", maskEkleKayitTarihiBaslangic.Text);
            komut.Parameters.AddWithValue("@k6", maskEkleKayitTarihiBitis.Text);
            komut.Parameters.AddWithValue("@k7", cmbEkleKampanya.Text);
            komut.Parameters.AddWithValue("@k8", txtEkleGorusmeSonuc.Text);
            komut.Parameters.AddWithValue("@k9", txtEkleTelefonNo.Text);
            komut.Parameters.AddWithValue("@k10", maskEkleAramaTarih.Text);
            komut.Parameters.AddWithValue("@k11", txtEkleTemsilci.Text);

            komut.ExecuteNonQuery();

            connect.Close();

            MessageBox.Show("Kayıt Oluşturuldu", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }
    }
}
