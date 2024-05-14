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
 
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }
         
        SqlConnection baglan = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=banka;Integrated Security=True; ");

        private void Form1_Load(object sender, EventArgs e)
        {

        }
         
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
           string kullanici_giris_tc = kullanici_giris_tc_al_txt.Text;

            string kullanici_giris_sifre = kullanici_giris_sifre_al_txt.Text;

            baglan.Open();
            SqlCommand kontrol = new SqlCommand("select * from kullanici_bilgi where TC = '" + kullanici_giris_tc + "' and kullanici_sifre = '" + kullanici_giris_sifre + "' ",baglan );

            SqlDataReader dr = kontrol.ExecuteReader();
             
            if (dr.Read())
            {
                baglan.Close();
                Form1 fr11 = new Form1();
            
                Form3 fr = new Form3();
                fr.kullanici_tc = kullanici_giris_tc;
                
                

                fr.Show();
           

                this.Hide();
            }
            else

            {

                MessageBox.Show("Hatalı TC. Kimlik No veya şifre !");
                kullanici_giris_sifre_al_txt.Clear();
                kullanici_giris_tc_al_txt.Clear();

            }
            baglan.Close();
        }
      
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            form2 frm = new form2();

            frm.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void kullanici_giris_tc_al_txt_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (kullanici_giris_sifre_al_txt.PasswordChar == '*')
            {
                kullanici_giris_sifre_al_txt.PasswordChar = '\0'; // '\0' karakteri karakterleri gösterir.
            }
            // Değilse, karakterleri gizle (şifrele).
            else
            {
                kullanici_giris_sifre_al_txt.PasswordChar = '*';
            }
        }
    }
}
