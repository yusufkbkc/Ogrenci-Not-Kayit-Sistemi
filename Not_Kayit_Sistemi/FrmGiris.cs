using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Not_Kayit_Sistemi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-TV970SR\SQLEXPRESS;Initial Catalog=DbNotKayýt;Integrated Security=True;TrustServerCertificate=True");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLDERS WHERE OGRNUMARA=@p1 AND OgrenciSifresi=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmOgrenciDetay frm = new FrmOgrenciDetay();
                frm.numara = maskedTextBox1.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalý öðrenci numarasý veya þifre!");
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Ogretmenler WHERE OgretmenSifresi=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtOgretmenSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmOgretmenDetay fr = new FrmOgretmenDetay();
                fr.ogretmenAdSoyad = dr["OgretmenAdSoyad"].ToString();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalý öðretmen þifresi!");
            }
            baglanti.Close();
        }
    }
}
