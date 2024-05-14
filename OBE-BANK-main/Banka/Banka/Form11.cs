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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        public string kullanici_iban_al { get; set; }
        string kullanici_iban;
        public string kullanici_tc_al { get; set; }
        string kullanici_tc;

        SqlConnection baglan = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=banka;Integrated Security=True; ");
        DataTable table = new DataTable();
        private void Form11_Load(object sender, EventArgs e)
        {
            kullanici_iban = kullanici_iban_al;
            kullanici_tc = kullanici_tc_al;


           

            table.Columns.Add("Gönderen Kişi" , typeof(string));
            table.Columns.Add("Alan Kişi",typeof(string));
            table.Columns.Add("Gönderilen Miktar",typeof (string));
            table.Columns.Add("Açıklama" ,typeof (string));
            table.Columns.Add("İşlem Tarihi", typeof(string));
            tablo_olustur();


            dataGridView1.DataSource = table;   
        }

        void tablo_olustur()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from kullanici_hesap_haraketleri where alan_iban = '" + kullanici_iban + "' or gonder_iban = '" + kullanici_iban + "'  ", baglan);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                table.Rows.Add(reader["gonderen_kisi"].ToString() , reader["alan_kisi"].ToString() , reader["gonderilen_miktar"].ToString(), reader["aciklama"].ToString() , reader["islem_tarihi"].ToString() );
               
            }
            baglan.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.kullanici_tc = kullanici_tc;
            form3.Show();
            this.Hide();
        }
    }
}
