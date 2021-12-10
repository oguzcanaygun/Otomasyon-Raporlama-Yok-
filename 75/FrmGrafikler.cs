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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MMJ5V6P;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutg1 = new SqlCommand("SELECT PerSehir,COUNT(*) from Tbl_Personel GROUP BY PerSehir ORDER BY COUNT(*) DESC", baglanti);
            SqlDataReader dr1 = komutg1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0],dr1[1]);
            }
            baglanti.Close();

            //Grafik 2
            baglanti.Open();
            SqlCommand komutg2 = new SqlCommand("SELECT PerMeslek,AVG(PerMaas) AS 'Ortalama Maas' from Tbl_Personel GROUP BY PerMeslek ORDER BY [Ortalama Maas] DESC",baglanti);
            SqlDataReader dr2 = komutg2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Meslek - Maas"].Points.AddXY(dr2[0],dr2[1]);
            }

            baglanti.Close();
        }
    }
}
