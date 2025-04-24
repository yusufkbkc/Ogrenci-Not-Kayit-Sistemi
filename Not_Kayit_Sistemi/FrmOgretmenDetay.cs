using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Not_Kayit_Sistemi
{
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-TV970SR\SQLEXPRESS;Initial Catalog=DbNotKayıt;Integrated Security=True;TrustServerCertificate=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-TV970SR\\SQLEXPRESS;Database=DbNotKayıt;Trusted_Connection=True;TrustServerCertificate=True;";
            string query = "SELECT * FROM TBLDERS";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        public string ogretmenSifre;

        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            VerileriListele(); // varsa önce verileri getiriyoruz

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT OgretmenAd, OgretmenSoyad FROM Ogretmenler WHERE OgretmenSifresi = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", ogretmenSifre);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                OgretmenAdSoyad.Text = dr["OgretmenAd"].ToString() + " " + dr["OgretmenSoyad"].ToString();
            }
            else
            {
                OgretmenAdSoyad.Text = "Bilinmeyen Öğretmen";
            }
            baglanti.Close();
        }

        private void VerileriListele()
        {
            string connectionString = "Server=DESKTOP-TV970SR\\SQLEXPRESS;Database=DbNotKayıt;Trusted_Connection=True;TrustServerCertificate=True;";
            string query = "SELECT * FROM TBLDERS";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                // Geçen ve kalan sayısını hesapla
                int gecen = 0;
                int kalan = 0;

                foreach (DataRow row in dt.Rows)
                {
                    if (row["DURUM"] != DBNull.Value)
                    {
                        bool durum = Convert.ToBoolean(row["DURUM"]);
                        if (durum)
                            gecen++;
                        else
                            kalan++;
                    }
                }

                LblGecenSayisi.Text = gecen.ToString();
                LblKalanSayisi.Text = kalan.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLDERS (OGRNUMARA,OGRAD,OGRSOYAD) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", MskNumara.Text);
            komut.Parameters.AddWithValue("@p2", TxtAd.Text);
            komut.Parameters.AddWithValue("@p3", TxtSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            VerileriListele();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            MskNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            Txt_Sinav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            Txt_Sinav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            Txt_Sinav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            string durum;
            s1 = Convert.ToDouble(Txt_Sinav1.Text);
            s2 = Convert.ToDouble(Txt_Sinav2.Text);
            s3 = Convert.ToDouble(Txt_Sinav3.Text);

            ortalama = (s1 + s2 + s3) / 3;
            LblOrtalama.Text = ortalama.ToString();

            if (ortalama >= 50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLDERS set OGRS1=@P1,OGRS2=@P2,OGRS3=@P3,ORTALAMA=@P4,DURUM=@P5 WHERE OGRNUMARA=@P6", baglanti);
            komut.Parameters.AddWithValue("@P1", Txt_Sinav1.Text);
            komut.Parameters.AddWithValue("@P2", Txt_Sinav2.Text);
            komut.Parameters.AddWithValue("@P3", Txt_Sinav3.Text);
            komut.Parameters.AddWithValue("@P4", decimal.Parse(LblOrtalama.Text));
            komut.Parameters.AddWithValue("@P5", durum);
            komut.Parameters.AddWithValue("@P6", MskNumara.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Not Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            VerileriListele();

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "DURUM" &&
        e.Value != null && e.Value != DBNull.Value)
            {
                bool durum = Convert.ToBoolean(e.Value);

                if (durum)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightGreen;
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightCoral;
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Seçili öğrenciyi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int ogrID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["OGRID"].Value);
                    string connectionString = "Server=DESKTOP-TV970SR\\SQLEXPRESS;Database=DbNotKayıt;Trusted_Connection=True;TrustServerCertificate=True;";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand komut = new SqlCommand("DELETE FROM TBLDERS WHERE OGRID = @p1", connection);
                        komut.Parameters.AddWithValue("@p1", ogrID);
                        komut.ExecuteNonQuery();
                        connection.Close();
                    }

                    MessageBox.Show("Öğrenci silindi.");
                    VerileriListele(); // Grid güncelle
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek öğrenciyi seçin.");
            }
        }
    }
}
