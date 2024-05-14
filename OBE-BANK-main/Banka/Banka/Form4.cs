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
using System.Runtime.InteropServices;

namespace Banka
{
    public partial class Form4 : Form
    {

        string kullanici_iban;
        string kullanici_tc_yansıt;
        string tc_gonder;
        string kullanici_iban_gonder;
        string kullanici_iban_kontrol_et;
         

        public Form4(string kullanici_iban_al,string kullanici_tc_al ,string kullanici_iban_kontrol)
        {
            InitializeComponent();
            kullanici_iban = kullanici_iban_al;
            kullanici_iban_gonder = kullanici_iban_oluştur();
            kullanici_tc_yansıt = kullanici_tc_al;
            tc_gonder = kullanici_tc_al;
            kullanici_iban_kontrol_et = kullanici_iban_kontrol;
             

        }

        string kullanici_iban_oluştur()
        {
            string a_iban = kullanici_iban;
            int uzunluk = a_iban.Length - 1;
            string oluştur_iban = "";

            for (int i = uzunluk - 3; i <= uzunluk; i++)
            {
                oluştur_iban += a_iban[i];
            }
            return oluştur_iban;

        }


        SqlConnection baglan = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=banka;Integrated Security=True; ");

        

        int para_gonder_iban;
        string alacakli_ad;
        string alacakli_ad_cpy;
        string alacakli_soyad;
        string alacakli_soyad_cpy;
        string goster_alacakli_ad;
        string goster_alacakli_soyad;
        int iban_uzunluk;

       
        Boolean bulundu_mu = false;
        Boolean tikla = false;
        Boolean kayitlimi = true;
        private bool _isUpdating = false;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

       
            if (!_isUpdating)
            {
                 
                _isUpdating = true;

                
                int cursorPosition = alacakli_iban_txt.SelectionStart;

                
                string textWithoutSpaces = alacakli_iban_txt.Text.Replace(" ", "");
 
                string formattedText = "";
                for (int i = 0; i < textWithoutSpaces.Length; i++)
                {
                    formattedText += textWithoutSpaces[i];
                    if (i == 1 && i + 1 != textWithoutSpaces.Length)
                    {
                        formattedText += " ";
                    }
                    else if ((i - 1) % 4 == 0 && i + 1 != textWithoutSpaces.Length)
                    {
                        formattedText += " ";
                    }
                }

             
                alacakli_iban_txt.Text = formattedText;
 
                alacakli_iban_txt.SelectionStart = cursorPosition + (formattedText.Length - textWithoutSpaces.Length);

                
                _isUpdating = false;
            }
       

            if (alacakli_iban_txt.Text.Length == 12)
            {

                
                try
                {

                    
                    string uzunluk_kontrol;

                    para_gonder_iban = alacakli_iban();
                    string uyruk_kontrol = iban_uyruk_cek();
                    int sube_no = sube_no_cek();


                    uzunluk_kontrol = Convert.ToString(alacakli_iban());

                    iban_uzunluk = uzunluk_kontrol.Length;

                    if (kullanici_iban_kontrol_et  == para_gonder_iban.ToString())
                    {
                        MessageBox.Show("Kendi kendinize para gönderemezsiniz !");
                        alacakli_iban_txt.Clear();

                    }


                    else
                    {
                        if (iban_uzunluk == 4)
                        {
                            baglan.Open();
                            SqlCommand cmd = new SqlCommand("select * from kullanici_bilgi where IBAN = " + para_gonder_iban + " and kullanici_sube_no = "+sube_no+" and kullanici_uyruk = '"+uyruk_kontrol+"'  ", baglan);
                            SqlDataReader read = cmd.ExecuteReader();
                            if (read.Read())

                            {

                                goster_alacakli_ad = read["kullanici_adi"].ToString();
                                goster_alacakli_soyad = read["kullanici_soyadi"].ToString();
                                bulundu_mu = true;
                                kayitlimi = true;
                            }

                            baglan.Close();


                            alacakli_ad = goster_alacakli_ad;
                            alacakli_soyad = goster_alacakli_soyad;
                            alacakli_ad_cpy = alacakli_ad;
                            alacakli_soyad_cpy = alacakli_soyad;



                            if (bulundu_mu == true)
                            {
                                alacakli_ad_soyad_sor_lbl.Visible = true;
                                tikla = true;
                                alacakli_ad_soyad_sor_lbl.Text = alacakli_ad_gizle() + " " + alacakli_soyad_gizle();
                            }
                        }
                        else
                        {

                            alacakli_ad = "";
                            alacakli_soyad = "";
                            goster_alacakli_ad = "";
                            goster_alacakli_soyad = "";
                            alacakli_ad = "";
                            alacakli_soyad = "";

                            tikla = false;
                            kayitlimi = false;
                            alacakli_ad_soyad_sor_lbl.Visible = false;

                        }
                        if (tikla == true && kayitlimi == true)
                        {
                            button1.Enabled = true;
                        }
                        else
                        {
                            button1.Enabled = false;
                        }


                    }



                }

                catch
                {
                    if (alacakli_iban_txt.Text != "")
                    {
                        
                        MessageBox.Show("Hatalı iban giriyorsunuz lütfen doğru değeri giriniz");
                        alacakli_iban_txt.Clear();



                    }


                }

            }
            else
            {
                alacakli_ad = "";
                alacakli_soyad = "";
                goster_alacakli_ad = "";
                goster_alacakli_soyad = "";
                alacakli_ad = "";
                alacakli_soyad = "";
                button1.Enabled = false;
                tikla = false;
                kayitlimi = false;
                alacakli_ad_soyad_sor_lbl.Visible = false;
            }
          
        }

       

        string iban_uyruk_cek()
        {
            string uyruk="";
            
            
            for(int i = 0 ; i <=1;i++)
            {
                uyruk += alacakli_iban_txt.Text[i];
            }

            return uyruk.ToUpper();
        }

        int sube_no_cek()
        {
            string sube_no_str = "";
            
            for(int i = 3 ; i<= 6; i++)
            {
                sube_no_str += alacakli_iban_txt.Text[i];
            }

            int sube_no_cevir = Convert.ToInt32(sube_no_str);

            return sube_no_cevir;
        }


        int alacakli_iban()
        {
            string a_iban =  alacakli_iban_txt.Text;
            int uzunluk = a_iban.Length - 1;
            string oluştur_iban = "";

            for (int i = uzunluk - 3; i <= uzunluk; i++)
            {
                oluştur_iban += a_iban[i];
            }
            return Convert.ToInt32(oluştur_iban);

        }

    
        private void button1_Click(object sender, EventArgs e)
        {
         
            if(alacakli_ad_dogrula_txt.Text.ToUpper() == alacakli_ad.ToUpper() && alacakli_soyad_dogrula_txt.Text.ToUpper() == alacakli_soyad.ToUpper())
            {
                Form5 fr5 = new Form5();
                fr5.kullanici_tc_kontrol = kullanici_tc_yansıt;
                fr5.alacakli_iban_yansit = para_gonder_iban.ToString();
                fr5.kullanici_iban_yansit = kullanici_iban_gonder;
                fr5.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bilgiler yanlış");
                alacakli_ad_dogrula_txt.Clear();
                alacakli_soyad_dogrula_txt.Clear();

            }
        }
        string alacakli_ad_gizle()
        {

            for (int i = alacakli_ad_cpy.Length - 1; i > 0; i--)
            {
                char c = '*';
                StringBuilder sb = new StringBuilder(alacakli_ad_cpy);
                sb[i] = c;

                alacakli_ad_cpy = sb.ToString();
            }

            return alacakli_ad_cpy;
        }

        string alacakli_soyad_gizle()
        {

            for (int j = alacakli_soyad_cpy.Length - 1; j > 0; j--)
            {
                char c = '*';
                StringBuilder sb = new StringBuilder(alacakli_soyad_cpy);
                sb[j] = c;

                alacakli_soyad_cpy = sb.ToString();

            }
            return alacakli_soyad_cpy;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.kullanici_tc = tc_gonder;
            fr3.Show();
            this.Hide();
        }

       
    }
}
