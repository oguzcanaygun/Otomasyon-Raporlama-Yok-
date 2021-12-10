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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MMJ5V6P;Initial Catalog=PersonelVeriTabani;Integrated Security=True");


        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutgr = new SqlCommand("Select * from Tbl_Yonetici where KullaniciAd=@p1 and Sifre=@p2",baglanti);
            komutgr.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
            komutgr.Parameters.AddWithValue("@p2",TxtSifre.Text);
            SqlDataReader drgr1 = komutgr.ExecuteReader();
            if (drgr1.Read())
            {
                FrmMain fr1 = new FrmMain();
                fr1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız Kullanıcı Adı ve Şifrenizi Kontrol Edin!");
            }

            baglanti.Close();
        }
    }
}
