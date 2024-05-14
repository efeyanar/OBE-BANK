using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Banka
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        public string tc_al {  get; set; }

        string kullanici_tc;
        string yeni_ad;
        string yeni_soyad;

        SqlConnection baglan = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=banka;Integrated Security=True; ");

        private void Form9_Load(object sender, EventArgs e)
        {
            kullanici_tc = tc_al;
        }

        void kullanici_ad_bilgi_gonder()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update kullanici_bilgi set kullanici_adi = '"+yeni_ad+"' where TC = '"+kullanici_tc+"' ",baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
        }

        void kullanici_soyad_bilgi_gonder()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update kullanici_bilgi set kullanici_soyadi = '" + yeni_soyad + "' where TC = '" + kullanici_tc + "' ", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                Form3 form3 = new Form3();
            form3.kullanici_tc = kullanici_tc;
            form3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            yeni_ad = yeni_ad_txt.Text;
            yeni_soyad = yeni_soyad_txt.Text;
             
            if (yeni_ad == "" || yeni_soyad == "")
            {
                MessageBox.Show("Lütfen ilgili alanları doldurun !");
            }
            else
            {

            MessageBox.Show("İşlem Başarılı !");
            kullanici_ad_bilgi_gonder();
            kullanici_soyad_bilgi_gonder();
            Form3 fr3 = new Form3();
            fr3.kullanici_tc = kullanici_tc;
            fr3.Show();
            this.Hide();
            }

        }

        private void yeni_ad_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
