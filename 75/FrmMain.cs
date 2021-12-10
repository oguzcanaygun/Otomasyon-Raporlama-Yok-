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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        
        void temizle()
        {
            TxtPrID.Text = "";
            TxtPrAd.Text ="";
            TxtPrSyd.Text ="";
            TxtPrMslk.Text ="";
            MskdTxtBxMaas.Text = "";
            CmbBxShr.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        
        
        
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MMJ5V6P;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void BtnLstle_Click(object sender, EventArgs e)
        {
            
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }

        private void BtnKydt_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1",TxtPrAd.Text);
            komut.Parameters.AddWithValue("@p2",TxtPrSyd.Text);
            komut.Parameters.AddWithValue("@p3",CmbBxShr.Text);
            komut.Parameters.AddWithValue("@p4",MskdTxtBxMaas.Text);
            komut.Parameters.AddWithValue("@p5",TxtPrMslk.Text);
            komut.Parameters.AddWithValue("@p6",label1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Kaydı Başarıyla Eklendi");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label1.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label1.Text = "False";
            }
        }

        private void BtnTmzlk_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            TxtPrID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtPrAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtPrSyd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtPrMslk.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            MskdTxtBxMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            CmbBxShr.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            label1.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            if (label1.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (label1.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("delete from Tbl_Personel where Perid=@k1",baglanti);
            komutsil.Parameters.AddWithValue("@k1",TxtPrID.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayit Başarıyla Silindi");
        }

        private void BtnGnclle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("update Tbl_Personel set PerAd=@p1,PerSoyad=@p2,PerSehir=@p3,PerMaas=@p4,PerDurum=@p5,PerMeslek=@p6 where Perid=@p7",baglanti);
            komutguncelle.Parameters.AddWithValue("@p1",TxtPrAd.Text);
            komutguncelle.Parameters.AddWithValue("@p2",TxtPrSyd.Text);
            komutguncelle.Parameters.AddWithValue("@p3",CmbBxShr.Text);
            komutguncelle.Parameters.AddWithValue("@p4",MskdTxtBxMaas.Text);
            komutguncelle.Parameters.AddWithValue("@p5",label1.Text);
            komutguncelle.Parameters.AddWithValue("@p6",TxtPrMslk.Text);
            komutguncelle.Parameters.AddWithValue("@p7",TxtPrID.Text);
            komutguncelle.ExecuteNonQuery();
            MessageBox.Show("Personel Bilgi Güncellendi");

            baglanti.Close();
        }

        private void BtnIsttsk_Click(object sender, EventArgs e)
        {
            Frmistatistik fr2 = new Frmistatistik();
            fr2.Show();
        }

        private void BtnGrfk_Click(object sender, EventArgs e)
        {
            FrmGrafikler frmgraf = new FrmGrafikler();
            frmgraf.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
