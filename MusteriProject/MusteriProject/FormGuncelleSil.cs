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
    public partial class FormGuncelleSil : Form
    {
        public FormGuncelleSil()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-TEHP7C8\\SQLEXPRESS;Initial Catalog=DbMusteri;Integrated Security=True");


        private void btnAramaEkranDon_Click(object sender, EventArgs e)
        {

            Form1 fr = new Form1();
            fr.Show();
            this.Hide();

        }


        private void FormGuncelleSil_Load(object sender, EventArgs e)
        {
           
            this.tbl_MusteriTableAdapter.Fill(this.dbMusteriDataSet1.Tbl_Musteri);

            connect.Open();

            SqlCommand komut = new SqlCommand("Select distinct(Kampanya) From Tbl_Musteri", connect); // comboboxa kampanyaları çektik

            SqlDataReader cmb_dr = komut.ExecuteReader();

            while (cmb_dr.Read())
            {

                cmbGuncelleSilKampanya.Items.Add(cmb_dr[0]);

            }

            connect.Close();




        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int value = dataGridView1.SelectedCells[0].RowIndex;  // secilen satirin indexi tutuldu

            txtGuncelleSilCustKey.Text = dataGridView1.Rows[value].Cells[0].Value.ToString();
            txtGuncelleSilMusteriNo.Text = dataGridView1.Rows[value].Cells[1].Value.ToString(); 
            txtGuncelleSilAd.Text = dataGridView1.Rows[value].Cells[2].Value.ToString();
            txtGuncelleSilSoyad.Text = dataGridView1.Rows[value].Cells[3].Value.ToString();
            txtGuncelleSilKaynak.Text = dataGridView1.Rows[value].Cells[4].Value.ToString();
            maskGuncelleSilKayitTarihiBaslangic.Text = dataGridView1.Rows[value].Cells[5].Value.ToString();
            maskGuncelleSilKayitTarihiBitis.Text = dataGridView1.Rows[value].Cells[6].Value.ToString();
            cmbGuncelleSilKampanya.Text = dataGridView1.Rows[value].Cells[7].Value.ToString();           // satirin 8.sütunundaki değer txtye yazdirildi
            txtGuncelleSilGorusmeSonuc.Text = dataGridView1.Rows[value].Cells[8].Value.ToString(); 
            txtGuncelleSilTelefonNo.Text = dataGridView1.Rows[value].Cells[9].Value.ToString();
            maskGuncelleSilAramaTarih.Text = dataGridView1.Rows[value].Cells[10].Value.ToString();
            txtGuncelleSilTemsilci.Text = dataGridView1.Rows[value].Cells[11].Value.ToString();




        }

        private void btnGuncelleSilListele_Click(object sender, EventArgs e)
        {

            connect.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Musteri", connect);
            da.Fill(dt);

            dataGridView1.DataSource = dt; // Kayıt datagridview da listelendi

            connect.Close();



        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            connect.Open();

            SqlCommand komut = new SqlCommand("Update Tbl_Musteri Set MusteriNo=@b1,Adı=@b2,Soyadı=@b3,Kaynak=@b4,KayitTarihiBaslangici=@b5,KayitTarihiBitisi=@b6,Kampanya=@b7,GorusmeSonucu=@b8,TelefonNo=@b9,AramaTarihi=@b10,Temsilci=@b11 where CustKey=@b12", connect);

            komut.Parameters.AddWithValue("@b1", txtGuncelleSilMusteriNo.Text);
            komut.Parameters.AddWithValue("@b2", txtGuncelleSilAd.Text);
            komut.Parameters.AddWithValue("@b3", txtGuncelleSilSoyad.Text);
            komut.Parameters.AddWithValue("@b4", txtGuncelleSilKaynak.Text);
            komut.Parameters.AddWithValue("@b5", maskGuncelleSilKayitTarihiBaslangic.Text);
            komut.Parameters.AddWithValue("@b6", maskGuncelleSilKayitTarihiBitis.Text);
            komut.Parameters.AddWithValue("@b7", cmbGuncelleSilKampanya.Text);
            komut.Parameters.AddWithValue("@b8", txtGuncelleSilGorusmeSonuc.Text);
            komut.Parameters.AddWithValue("@b9", txtGuncelleSilTelefonNo.Text);
            komut.Parameters.AddWithValue("@b10", maskGuncelleSilAramaTarih.Text);
            komut.Parameters.AddWithValue("@b11", txtGuncelleSilTemsilci.Text);
            komut.Parameters.AddWithValue("@b12", txtGuncelleSilCustKey.Text);

            komut.ExecuteNonQuery();


            connect.Close();

            MessageBox.Show("Kayıt Güncellendi", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            connect.Open();

            SqlCommand komut = new SqlCommand("Delete From Tbl_Musteri Where CustKey=@k1", connect);

            komut.Parameters.AddWithValue("@k1", txtGuncelleSilCustKey.Text);

            komut.ExecuteNonQuery();

            connect.Close();

            MessageBox.Show("Kayıt Silindi", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
