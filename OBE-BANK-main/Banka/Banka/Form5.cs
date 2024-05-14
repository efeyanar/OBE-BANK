using Banka;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka
{
    public partial class Form5 : Form
    {
      
        public Form5()
        {
            InitializeComponent();
             
        }
        public string kullanici_tc_kontrol { get; set; }

        string tc_gonder;

        public string alacakli_iban_yansit {  get; set; }

        public string kullanici_iban_yansit {get; set; }

        int kullanici_iban_bilgi;

        private void Form5_Load(object sender, EventArgs e)
        {
            tc_gonder = kullanici_tc_kontrol;
            kullanici_iban_bilgi = Convert.ToInt32(kullanici_iban_yansit);
        }

        double banka_bakiye_cek;
        public double banka_bakiye;
        double kullanici_bakiye;
        double alacakli_bakiye;
        double alacakli_bakiye_cek;
        double kullanici_bakiye_cek;
        double gonderilecek_tutar;
        double banka_komisyon = 10.0;
        double komisyon_goster;
     
        

        SqlConnection baglan = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=banka;Integrated Security=True; ");

        private void gonderilecek_tutar_txt_TextChanged(object sender, EventArgs e)
        {
                komisyon_tutar_txt.Text = Convert.ToString(banka_komisyon);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
              gonderilecek_tutar = Convert.ToDouble(gonderilecek_tutar_txt.Text);
               
                kullanici_bakiye = kullanici_bakiye_bilgi_cek();
                alacakli_bakiye = alacakli_bakiye_bilgi_cek();
                banka_bakiye = banka_bakiye_bilgi_cek();

                if (kullanici_bakiye >= (gonderilecek_tutar + banka_komisyon) && gonderilecek_tutar > 0.0)
                {
                    kullanici_bakiye -= (gonderilecek_tutar + banka_komisyon);
                    alacakli_bakiye += gonderilecek_tutar;
                    banka_bakiye += banka_komisyon;

                    kullanici_bakiye_bilgi_gonder(kullanici_bakiye);
                    alacakli_bakiye_bilgi_gonder(alacakli_bakiye);
                    banka_bakiye_bilgi_gonder(banka_bakiye);
                    MessageBox.Show("İşlem başarılı.");

                    Form6 form6 = new Form6();
                    form6.gonderen_isim = gonderen_kisi();
                    form6.alacakli_isim = alacakli_ad_bilgi();
                    form6.aciklama = aciklama_txt.Text;
                    form6.tc_bilgi = tc_gonder;
                    form6.tutar = gonderilecek_tutar.ToString();
                    form6.alacakli_iban = alacakli_iban_yansit;
                    form6.komisyon  = banka_komisyon.ToString();
                    form6.Show();

                    this.Hide();
                }
                else if (gonderilecek_tutar == 0.0)
                {
                    MessageBox.Show("Hatalı işlem !");
                    gonderilecek_tutar_txt.Clear();
                    komisyon_tutar_txt.Clear();
                }

                else
                {
                    MessageBox.Show("Yetersiz bakiye !");
                    gonderilecek_tutar_txt.Clear();
                    komisyon_tutar_txt.Clear();

                }

            }
            catch
            {
                MessageBox.Show("Hatalı bakiye bilgisi");
                gonderilecek_tutar_txt.Clear();
                komisyon_tutar_txt.Clear();
            }

             
             
        }

        double banka_bakiye_bilgi_cek()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from kullanici_bilgi where IBAN = " + 1009 + "  ", baglan);
            SqlDataReader rdr = komut.ExecuteReader();
            if (rdr.Read())
            {
                banka_bakiye_cek = Convert.ToDouble(rdr["kullanici_bakiye"]);
            }
            baglan.Close();
            return banka_bakiye_cek;
        }

        void banka_bakiye_bilgi_gonder(double komisyon)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update kullanici_bilgi set kullanici_bakiye = '" + komisyon + "' where IBAN = " + 1009 + " ", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
        }

        double kullanici_bakiye_bilgi_cek()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM kullanici_bilgi WHERE TC LIKE '" + kullanici_tc_kontrol + "'", baglan);
            SqlDataReader read = komut.ExecuteReader();
            if (read.Read())
            {

                kullanici_bakiye_cek = Convert.ToDouble(read["kullanici_bakiye"]);
            }
            baglan.Close();
            return kullanici_bakiye_cek;
        }


        double alacakli_bakiye_bilgi_cek()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from kullanici_bilgi where IBAN like " + alacakli_iban_yansit + "",baglan);
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                alacakli_bakiye_cek = Convert.ToDouble(reader["kullanici_bakiye"]);
            }

            baglan.Close();
            return alacakli_bakiye_cek;
        }

        void kullanici_bakiye_bilgi_gonder(double kalan_bakiye)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update kullanici_bilgi set kullanici_bakiye = '" + kalan_bakiye + "' where IBAN = '"+ kullanici_iban_bilgi + "' ", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
        }
        void alacakli_bakiye_bilgi_gonder(double gonderilen_bakiye )
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update kullanici_bilgi set kullanici_bakiye = '"+gonderilen_bakiye +"' where IBAN = '"+alacakli_iban_yansit+"'",baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
        }
        string gonderen_ad_bilgi;
        string gonderen_kisi()
        {
            baglan.Open() ;
            SqlCommand komut = new SqlCommand("select * from kullanici_bilgi where IBAN = '"+kullanici_iban_bilgi +"'",baglan) ;
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                gonderen_ad_bilgi = reader["kullanici_adi"].ToString() +" " + reader["kullanici_soyadi"];
            }
            baglan.Close() ;
            return gonderen_ad_bilgi ;
        }

        string alacakli_kisi;
        string alacakli_ad_bilgi()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from kullanici_bilgi where IBAN = '"+alacakli_iban_yansit+"' ",baglan) ;
            SqlDataReader r = komut.ExecuteReader();
            if (r.Read())
            {
                alacakli_kisi = r["kullanici_adi"].ToString() + " " + r["kullanici_soyadi"].ToString();
            }
            baglan.Close() ;
            return alacakli_kisi ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.kullanici_tc = tc_gonder;
            form3.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
