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

    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();

        }
        SqlConnection baglan = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=banka;Integrated Security=True; ");
        string sube;

        private void kullanici_kayit_btn_Click(object sender, EventArgs e)
        {
            
            string tc_no = kullanici_kayit_tc_al_txt.Text;
            string ad = kullanici_kayit_ad_al_txt.Text;
            string soyad = kullanici_kayit_soyad_al_txt.Text;
            string sifre = kullanici_kayit_sifre_al_txt.Text;
            string sifre_kontrol = kullanici_kayit_sifre_al_kontrol_txt.Text;
            sube = comboBox1.Text;
            int sube_no = sube_no_ver();
            

            if (sifre == sifre_kontrol && tc_no != "" && ad != "" && soyad != "" && sifre != "")
            {
      
                try
                {
                    baglan.Open();


                    string komut = "insert into kullanici_bilgi (TC,kullanici_adi,kullanici_soyadi,kullanici_sifre,kullanici_sube,kullanici_sube_no) values ('" + tc_no + "','" + ad + "','" + soyad + "','" + sifre + "' , '"+sube+"' , "+sube_no+"  )";
                    SqlCommand sqlkomut = new SqlCommand(komut, baglan);
 

                    sqlkomut.ExecuteNonQuery();
                    baglan.Close();

                    MessageBox.Show("İşlem başarılı");
                    Form1 fr111 = new Form1();
                    fr111.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata :" + ex);
                }

            }
            else
            {
                MessageBox.Show("Lütfen doğru şifre girdiğinizden emin olun !");
            }

            
        }

        

        int sube_no_ver()
        {
             if (sube == "İstanbul-Sultanbeyli")
            {
                return 1000;
            }
             else if (sube == "İstanbul-Pendik")
            {
                return 1001;
            }
             else if (sube == "İstanbul-Tuzla")
            {
                return 1002;
            }
            else if (sube == "İstanbul-Maltepe")
            {
                return 1003;
            }
            else if (sube == "İstanbul-Kurtköy")
            {
                return 1004;
            }
             else if (sube == "Ankara-Etimesgut")
            {
                return 1005;
            }
         
            else if (sube == "Ankara-Alemdağ")
            {
                return 1007;
            }
            else if (sube == "Ankara-Mamak")
            {
                return 1008;
            }
            else if (sube == "İzmir-Çeşme")
            {
                return 1009;
            }
            else if (sube == "İzmir-Karşıyaka")
            {
                return 1010;
            }
             else if(sube == "İzmir-Bornova")
            {
                return 1011;
            }
            
             else
            {
                return 0;            }
             }

        private void form2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "İstanbul-Sultanbeyli";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kullanici_kayit_sifre_al_txt.PasswordChar == '*')
            {
                kullanici_kayit_sifre_al_txt.PasswordChar = '\0'; // '\0' karakteri karakterleri gösterir.
            }
            // Değilse, karakterleri gizle (şifrele).
            else
            {
                kullanici_kayit_sifre_al_txt.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kullanici_kayit_sifre_al_kontrol_txt.PasswordChar == '*')
            {
                kullanici_kayit_sifre_al_kontrol_txt.PasswordChar = '\0'; // '\0' karakteri karakterleri gösterir.
            }
            // Değilse, karakterleri gizle (şifrele).
            else
            {
                kullanici_kayit_sifre_al_kontrol_txt.PasswordChar = '*';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
