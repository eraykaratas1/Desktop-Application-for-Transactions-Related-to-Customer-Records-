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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-TEHP7C8\\SQLEXPRESS;Initial Catalog=DbMusteri;Integrated Security=True");

        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            connect.Open();

            SqlCommand komut = new SqlCommand("Select * From Tbl_Musteri_Login where KullanıcıAdı=@t1 and Sifre=@t2", connect);

            komut.Parameters.AddWithValue("@t1", txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@t2", txtSifre.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read()) // sorguyla çekilen tüm verileri okuma işlemi, veritabanında eşleşme var mı yok mu kontrolü
            {

                MessageBox.Show("Giriş Başarılı", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form1 frm = new Form1();
                frm.Show();
                this.Hide();



            }
            else
            {

                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



            connect.Close();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
