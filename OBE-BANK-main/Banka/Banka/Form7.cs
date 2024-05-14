using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        public string tc_al {  get; set; }

        string kullanici_tc;
        private void Form7_Load(object sender, EventArgs e)
        {
             kullanici_tc = tc_al;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 fr8 = new Form8();
            fr8.tc_al = kullanici_tc;
            fr8.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.kullanici_tc = tc_al;
            fr3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 fr9 = new Form9();
            fr9.tc_al = kullanici_tc;
            fr9.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 fr10 = new Form10();
            fr10.tc_al = tc_al;
            fr10.Show();
            this.Hide();

        }
    }
}
