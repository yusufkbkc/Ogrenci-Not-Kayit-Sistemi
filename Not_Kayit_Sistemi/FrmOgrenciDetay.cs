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
using System.Data.SqlTypes;

namespace Not_Kayit_Sistemi
{
    public partial class FrmOgrenciDetay : Form
    {
        public FrmOgrenciDetay()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public string numara;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-TV970SR\SQLEXPRESS;Initial Catalog=DbNotKayıt;Integrated Security=True;TrustServerCertificate=True");
        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
           LblNumara.Text = numara;
           baglanti.Open();
           SqlCommand komut= new SqlCommand("Select * From TBLDERS where OGRNUMARA=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                LblAdSoyad.Text = dr[2].ToString()+" "+dr[3].ToString();
                LblSınav1.Text = dr[4].ToString();
                LblSınav2.Text = dr[5].ToString();
                LblSınav3.Text = dr[6].ToString();
                LblOrtalama.Text = dr[7].ToString();
                LblDurum.Text = dr[8].ToString();

                bool durum = Convert.ToBoolean(dr[8]); // Veritabanından gelen değeri bool'a çeviriyoruz.
                if (durum) // Eğer durum true ise
                {
                    LblDurum.Text = "Geçti";
                }
                else // Eğer durum false ise
                {
                    LblDurum.Text = "Kaldı";
                }
            }
            baglanti.Close();
        }
    }
}
