using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _75
{
    public partial class Frmistatistik : Form
    {
        public Frmistatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MMJ5V6P;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void Form2_Load(object sender, EventArgs e)
        {
            // Toplam Personel Sayısı
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select count(*) from Tbl_Personel",baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblTplmPrsnl.Text = dr1[0].ToString();
            }
            baglanti.Close();

            //Evli Personel Sayısı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select count(*) from Tbl_Personel where PerDurum=1",baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblEvliPersonel.Text = dr2[0].ToString();
            }
            baglanti.Close();

            //Bekar Personel Sayısı
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select count(*) from Tbl_Personel where PerDurum=0",baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblBkrPrsnl.Text = dr3[0].ToString();
            }
            baglanti.Close();

            //Şehir sayısı (farklı)
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select count(distinct(PerSehir)) from Tbl_Personel", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblShrSys.Text = dr4[0].ToString();
            }
            baglanti.Close();

            //Toplam Maas
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select SUM(PerMaas) from Tbl_Personel", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                LblTplmMaas.Text = dr5[0].ToString();
            }
            baglanti.Close();

            //Ortalama Maas
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select AVG(PerMaas) from Tbl_Personel",baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                LblOrtMaas.Text = dr6[0].ToString();
            }

            baglanti.Close();
        }
    }
}
