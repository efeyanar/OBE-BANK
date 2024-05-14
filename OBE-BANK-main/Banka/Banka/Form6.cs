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
    public partial class Form6 : Form
    {
         
        public Form6()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=banka;Integrated Security=True; ");

        public string gonderen_isim {  get; set; }
        public string alacakli_isim { get; set; }
        public string aciklama { get; set; }
        public string tc_bilgi { get; set; }
        public string tutar {  get; set; }
        public string alacakli_iban { get; set; }
        public string komisyon { get; set; }
        string tc_gonder;
        DateTime islemTarihi = DateTime.Now;

        private void Form6_Load(object sender, EventArgs e)
        {
            tc_gonder = tc_bilgi;
            gonderen_kisi_lbl.Text = gonderen_isim;
            alan_kisi_lbl.Text = alacakli_isim;
            aciklama_txt.Text = aciklama;
            tutar_lbl.Text = tutar;

            gonderen_kisi_islem_kayıt_gonder();
            /*
            alan_kisi_islem_kayıt_gonder();
            */
            banka_islem_kayıt_gonder();
            
             islem_tarihi_lbl.Text = islemTarihi.ToString();

        }

        string  kullanici_iban_cek;
        string kullanici_iban_bilgi_cek()
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select * from kullanici_bilgi where TC = '"+tc_bilgi+"'  ",baglan);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                kullanici_iban_cek = rdr["IBAN"].ToString();
            }
            baglan.Close();
            return kullanici_iban_cek;
        }

        string kullanici_iban;
        void gonderen_kisi_islem_kayıt_gonder()
        {
            int gonderen_iban = Convert.ToInt32(kullanici_iban_bilgi_cek());
            kullanici_iban = kullanici_iban_bilgi_cek();
            baglan.Open();
            string script = "insert into kullanici_hesap_haraketleri (alan_iban,gonderen_kisi,alan_kisi,aciklama,gonderilen_miktar,islem_tarihi,gonder_iban) values (" + alacakli_iban + " , '" + gonderen_isim + "' , '" + alacakli_isim + "' , '" + aciklama + "' ," + tutar + " , '" + islemTarihi.ToString() + "' , " + gonderen_iban + " )";
            SqlCommand komut = new SqlCommand(script, baglan);

            komut.ExecuteNonQuery();
            baglan.Close();
        }



        void alan_kisi_islem_kayıt_gonder()
        {
            
            int gonderen_iban = Convert.ToInt32(kullanici_iban_bilgi_cek());
            baglan.Open();
            string script = "insert into kullanici_hesap_haraketleri (alan_iban,gonderen_kisi,alan_kisi,aciklama,gonderilen_miktar,islem_tarihi,gonder_iban) values (" + alacakli_iban + " , '" + gonderen_isim + "' , '" + alacakli_isim + "' , '" + aciklama + "' ," + tutar + " , '" + islemTarihi.ToString() + "' , " + gonderen_iban + " )";
            SqlCommand komut = new SqlCommand(script, baglan);

            komut.ExecuteNonQuery();
            baglan.Close();
        }

        void banka_islem_kayıt_gonder()
        {
            
            int gonderen_iban = Convert.ToInt32(kullanici_iban_bilgi_cek());
            baglan.Open();
            string script = "insert into kullanici_hesap_haraketleri (alan_iban,gonderen_kisi,alan_kisi,aciklama,gonderilen_miktar,islem_tarihi,gonder_iban) values ( " + 1009 + " , '" + gonderen_isim + "' , '" + "OBE-BANK" + "' , '"+"İşlem Komisyon Kesimi"+"'  ," + komisyon + "  , '" + islemTarihi.ToString() + "' , " + gonderen_iban + " ) ";
            SqlCommand sqlCommand = new SqlCommand(script, baglan);
            sqlCommand.ExecuteNonQuery();
            baglan.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.kullanici_tc = tc_gonder;
            form3.Show();
            this.Hide();
        }
        
    }
}
