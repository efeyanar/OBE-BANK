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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        public string tc_al {  get; set; }

        string kullanici_tc;
        string kullanici_mevcut_sifre_bilgi;
        string kullanici_mevcut_sifre;
        string kullanici_yeni_sifre;
        string kullanici_yeni_sifre_dogrula;

        SqlConnection baglan = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=banka;Integrated Security=True; ");

        private void Form8_Load(object sender, EventArgs e)
        {
            kullanici_tc = tc_al;
            kullanici_mevcut_sifre = kullanici_sifre_cek();

        }
        string kullanici_sifre_cek()
        {
            string kullanici_mevcut_sifre_k;
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from kullanici_bilgi where TC = '"+kullanici_tc+"'",baglan);
            SqlDataReader read = komut.ExecuteReader();
            if (read.Read()) {

              kullanici_mevcut_sifre_k =  read["kullanici_sifre"].ToString();
                baglan.Close();
                return kullanici_mevcut_sifre_k;
            }
            baglan.Close();
            return "";
        }

        void kullanici_sifre_bilgi_gonder()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update kullanici_bilgi set kullanici_sifre = '" + kullanici_yeni_sifre_dogrula + "' where TC = '" + kullanici_tc + "' ", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();


        }



        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.kullanici_tc = kullanici_tc;
            fr3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullanici_mevcut_sifre = mevcut_hesap_sifre_txt.Text;
            kullanici_yeni_sifre = yeni_sifre_txt.Text;
            kullanici_yeni_sifre_dogrula = yeni_sifre_dogrula_txt.Text;
            kullanici_mevcut_sifre_bilgi = kullanici_sifre_cek();

            if((kullanici_mevcut_sifre == kullanici_mevcut_sifre_bilgi) && (kullanici_yeni_sifre == kullanici_yeni_sifre_dogrula))
            {
                MessageBox.Show("İşlem Başarılı !");
                kullanici_sifre_bilgi_gonder();
                Form3 fr3 = new Form3();
                fr3.kullanici_tc = kullanici_tc;
                fr3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Bilgi !");
                mevcut_hesap_sifre_txt.Clear();
                yeni_sifre_txt.Clear();
                yeni_sifre_dogrula_txt.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mevcut_hesap_sifre_txt.PasswordChar == '*')
            {
                mevcut_hesap_sifre_txt.PasswordChar = '\0'; // '\0' karakteri karakterleri gösterir.
            }
            // Değilse, karakterleri gizle (şifrele).
            else
            {
                mevcut_hesap_sifre_txt.PasswordChar = '*';
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (yeni_sifre_txt.PasswordChar == '*')
            {
              yeni_sifre_txt.PasswordChar = '\0'; // '\0' karakteri karakterleri gösterir.
            }
            // Değilse, karakterleri gizle (şifrele).
            else
            {
                yeni_sifre_txt.PasswordChar = '*';
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (yeni_sifre_dogrula_txt.PasswordChar == '*')
            {
                yeni_sifre_dogrula_txt.PasswordChar = '\0'; // '\0' karakteri karakterleri gösterir.
            }
            // Değilse, karakterleri gizle (şifrele).
            else
            {
                yeni_sifre_dogrula_txt.PasswordChar = '*';
            }
        }
    }
}
