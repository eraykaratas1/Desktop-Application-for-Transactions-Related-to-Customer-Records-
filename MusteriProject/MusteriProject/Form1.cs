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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-TEHP7C8\\SQLEXPRESS;Initial Catalog=DbMusteri;Integrated Security=True");

        void clear()
        {
            txtMusteriNo.Text = "";
            txtMusteriAd.Text = "";
            txtMusteriSoyad.Text = "";
            cmbKampanya.Text = "";
            txtKaynak.Text = "";
            txtKayitTarihiBaslangic.Text = "";
            txtKayitTarihiBitis.Text = "";
            txtMusteriNo.Focus(); 


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //  this.tbl_MusteriTableAdapter.Fill(this.dbMusteriDataSet.Tbl_Musteri);

            connect.Open();

            SqlCommand komut = new SqlCommand("Select distinct(Kampanya) From Tbl_Musteri", connect); // comboboxa kampanyaları çektik

            SqlDataReader cmb_dr = komut.ExecuteReader();

            while (cmb_dr.Read())
            {

                cmbKampanya.Items.Add(cmb_dr[0]);

            }

            connect.Close();



        }


        private void btnListele_Click(object sender, EventArgs e)
        {


            connect.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Musteri", connect);
            da.Fill(dt);

            dataGridView1.DataSource = dt; // Kayıt datagridview da listelendi

            connect.Close();


        }


        private void btnTemizle_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnSonucSil_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // Datagridview temizlendi


        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            connect.Open();


            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Musteri WHERE MusteriNo='" + txtMusteriNo.Text + "' OR Adı='" + txtMusteriAd.Text + "' OR Soyadı='" + txtMusteriSoyad.Text + "' OR Kampanya='" + cmbKampanya.Text + "' OR  Kaynak='" + txtKaynak.Text + "' OR KayitTarihiBaslangici='" + txtKayitTarihiBaslangic.Text + "' OR KayitTarihiBitisi='" + txtKayitTarihiBitis.Text + "' ", connect); 

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read()) // Kayıt Var mı Yok mu Kontrolü
            {

                connect.Close();

                MessageBox.Show("Kayıt Bulundu", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                connect.Open();

                // Datagridview'da sadece bu sorgudan gelen kayıtları listeleme işlemi

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Musteri WHERE MusteriNo='" + txtMusteriNo.Text + "' OR Adı='" + txtMusteriAd.Text + "' OR Soyadı='" + txtMusteriSoyad.Text + "' OR Kampanya='" + cmbKampanya.Text + "' OR  Kaynak='" + txtKaynak.Text + "' OR KayitTarihiBaslangici='" + txtKayitTarihiBaslangic.Text + "' OR KayitTarihiBitisi='" + txtKayitTarihiBitis.Text + "' ", connect);
                da.Fill(dt);

                dataGridView1.DataSource = dt; // Kayıt datagridview da listelendi

                connect.Close();
            }
            else
            {

                MessageBox.Show("Kayıt Bulunamadı", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




            connect.Close();




        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            FormEkle fe = new FormEkle();

            fe.Show();
            this.Hide();




        }

        private void btnGuncelleSil_Click(object sender, EventArgs e)
        {

            FormGuncelleSil fgs = new FormGuncelleSil();
            fgs.Show();
            this.Hide();



        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {

            FormLogin fl = new FormLogin();
            fl.Show();
            this.Hide();


        }
    }
}
