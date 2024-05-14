

using Banka.bankaDataSet1TableAdapters;
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
using System.Data.SqlTypes;

namespace Banka
{
    public partial class Form3 : Form
    {

        public string kullanici_tc { get; set; }

        string goster_kullanici_ad;
        string goster_kullanici_soyad;
        string goster_kullanici_iban;
        string goster_kullanici_sube;
      

        public Form3( )
        {
            InitializeComponent();
             

        }
          SqlConnection baglan = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=banka;Integrated Security=True; ");

       
        
        private void Form3_Load(object sender, EventArgs e)
        {
            goster_kullanici_iban = iban_cek();
           
            string goster_kullanici_bakiye;
            double kullanici_bakiye;
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from kullanici_bilgi where TC like '" + kullanici_tc + "'",baglan);
            SqlDataReader read = komut.ExecuteReader();
           if(read.Read())
            {
                goster_kullanici_ad = read["kullanici_adi"].ToString();
                goster_kullanici_soyad = read["kullanici_soyadi"].ToString() ;
                goster_kullanici_sube = read["kullanici_sube"].ToString();
                goster_kullanici_bakiye = read["kullanici_bakiye"].ToString();
                
            kullanici_anamenü_isim_soyisim_lbl.Text = goster_kullanici_ad + " " + goster_kullanici_soyad;
            kullanici_anamenü_iban_lbl.Text = goster_kullanici_iban;
                kullanici_anamenü_sube_lbl.Text = goster_kullanici_sube;
                kullanici_anamenü_bakiye_lbl.Text = goster_kullanici_bakiye;
            kullanici_bakiye = Convert.ToDouble(goster_kullanici_bakiye);
            string bakiye_klon = kullanici_bakiye.ToString();
            Form5 fr5 = new Form5();

            
            }
          
             
            baglan.Close();

           


        }

        private void Form3_Show(object sender, EventArgs e)
        {
            goster_kullanici_iban = iban_cek();
          
            string goster_kullanici_bakiye;
            double kullanici_bakiye;
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from kullanici_bilgi where TC like '" + kullanici_tc + "'", baglan);
            SqlDataReader read = komut.ExecuteReader();
            if (read.Read())
            {
                goster_kullanici_ad = read["kullanici_adi"].ToString();
                goster_kullanici_soyad = read["kullanici_soyadi"].ToString();
                goster_kullanici_sube = read["kullanici_sube"].ToString();
                goster_kullanici_bakiye = read["kullanici_bakiye"].ToString();

                kullanici_anamenü_isim_soyisim_lbl.Text = goster_kullanici_ad + " " + goster_kullanici_soyad;
                kullanici_anamenü_iban_lbl.Text = goster_kullanici_iban;
                kullanici_anamenü_sube_lbl.Text= goster_kullanici_sube;
                kullanici_anamenü_bakiye_lbl.Text = goster_kullanici_bakiye;
                kullanici_bakiye = Convert.ToDouble(goster_kullanici_bakiye);
                string bakiye_klon = kullanici_bakiye.ToString();
                Form5 fr5 = new Form5();

            }
            baglan.Close();
        }

        string iban;
        string iban_cek()
        {
            string iban_olustur = "";
            string iban_uyruk;
            string iban_sube;
            
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from kullanici_bilgi where TC like '"+kullanici_tc+"'  ",baglan);
            SqlDataReader reader = komut.ExecuteReader();

            if (reader.Read())
            {
                iban_uyruk = reader["kullanici_uyruk"].ToString();
                iban_sube = reader["kullanici_sube_no"].ToString();
                iban = reader["IBAN"].ToString() ;
                iban_olustur = iban_uyruk +" " +  iban_sube + " " + iban;
            }
            baglan.Close();

            
            return iban_olustur;
        }
            private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
           
           
        this.Hide();
            
        }

        private void kullanici_anamenü_bakiye_lbl_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4(goster_kullanici_iban, kullanici_tc, iban);
             
            fr4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 fr7 = new Form7();
            fr7.tc_al = kullanici_tc;
            fr7.Show();
            this.Hide();
        }

        string dogrulama_cek()
        {
            string kod;
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from kullanici_bilgi where TC = '" + kullanici_tc + "'  ", baglan);
            SqlDataReader read = komut.ExecuteReader();
            if (read.Read()) {
                
                kod = read["IBAN"].ToString();
                baglan.Close(); 
                return kod;
                
            }
            return "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.kullanici_iban_al = dogrulama_cek();
            form11.kullanici_tc_al = kullanici_tc.ToString();
            form11.Show();

            this.Hide();
        }

        private void kullanici_selamlama_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void kullanici_anamenü_sube_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
