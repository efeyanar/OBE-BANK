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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        public string tc_al {  get; set; }

        string kullanici_tc;

        SqlConnection baglan = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=banka;Integrated Security=True; ");

        private void Form10_Load(object sender, EventArgs e)
        {
             kullanici_tc = tc_al;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.kullanici_tc = tc_al;
            form3.Show();
            this.Hide();

        }

        string kullanici_sifre;

        private void button1_Click(object sender, EventArgs e)
        {
            kullanici_sifre = bilgi_cek();

            if(kullanici_hesap_silme_sifre_kontrol_txt.Text == kullanici_sifre)
            {
                hesap_sil();
                MessageBox.Show("Hesabınız Başarıyla Silinmiştir !");
                Form1 fr1 = new Form1();
                fr1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Şifre !");
                kullanici_hesap_silme_sifre_kontrol_txt.Clear();

            }

        }

        void hesap_sil()
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand("delete  from kullanici_bilgi where TC = '"+kullanici_tc+"' ",baglan);
            cmd.ExecuteNonQuery();
            baglan.Close();
        }

        string kullanici_sifre_cek;

        string bilgi_cek()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from kullanici_bilgi where TC = '" + kullanici_tc + "'  ", baglan);
            SqlDataReader read = komut.ExecuteReader();

            if (read.Read())
            {
                kullanici_sifre_cek = read["kullanici_sifre"].ToString();
            }
            baglan.Close();
            return kullanici_sifre_cek;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (kullanici_hesap_silme_sifre_kontrol_txt.PasswordChar == '*')
            {
                kullanici_hesap_silme_sifre_kontrol_txt.PasswordChar = '\0';  
            }
            
            else
            {
                kullanici_hesap_silme_sifre_kontrol_txt.PasswordChar = '*';
            }
        }
    }
}
