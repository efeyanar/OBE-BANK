namespace Banka
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.Şifre = new System.Windows.Forms.Label();
            this.giris_yap_btn = new System.Windows.Forms.Button();
            this.kullanici_giris_tc_al_txt = new System.Windows.Forms.TextBox();
            this.kullanici_giris_sifre_al_txt = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(591, 591);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 46);
            this.label3.TabIndex = 1;
            this.label3.Text = "TC. NO :";
            // 
            // Şifre
            // 
            this.Şifre.AutoSize = true;
            this.Şifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Şifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.Şifre.Location = new System.Drawing.Point(610, 659);
            this.Şifre.Name = "Şifre";
            this.Şifre.Size = new System.Drawing.Size(166, 46);
            this.Şifre.TabIndex = 1;
            this.Şifre.Text = "ŞİFRE :";
            // 
            // giris_yap_btn
            // 
            this.giris_yap_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_yap_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.giris_yap_btn.Location = new System.Drawing.Point(826, 741);
            this.giris_yap_btn.Name = "giris_yap_btn";
            this.giris_yap_btn.Size = new System.Drawing.Size(333, 73);
            this.giris_yap_btn.TabIndex = 2;
            this.giris_yap_btn.Text = "GİRİŞ YAP";
            this.giris_yap_btn.UseVisualStyleBackColor = true;
            this.giris_yap_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // kullanici_giris_tc_al_txt
            // 
            this.kullanici_giris_tc_al_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanici_giris_tc_al_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.kullanici_giris_tc_al_txt.Location = new System.Drawing.Point(782, 588);
            this.kullanici_giris_tc_al_txt.Name = "kullanici_giris_tc_al_txt";
            this.kullanici_giris_tc_al_txt.Size = new System.Drawing.Size(463, 53);
            this.kullanici_giris_tc_al_txt.TabIndex = 3;
            this.kullanici_giris_tc_al_txt.TextChanged += new System.EventHandler(this.kullanici_giris_tc_al_txt_TextChanged);
            // 
            // kullanici_giris_sifre_al_txt
            // 
            this.kullanici_giris_sifre_al_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanici_giris_sifre_al_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.kullanici_giris_sifre_al_txt.Location = new System.Drawing.Point(782, 656);
            this.kullanici_giris_sifre_al_txt.Name = "kullanici_giris_sifre_al_txt";
            this.kullanici_giris_sifre_al_txt.PasswordChar = '*';
            this.kullanici_giris_sifre_al_txt.Size = new System.Drawing.Size(463, 53);
            this.kullanici_giris_sifre_al_txt.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.linkLabel1.Location = new System.Drawing.Point(186, 919);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(144, 31);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "KAYIT OL";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.label4.Location = new System.Drawing.Point(27, 878);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(517, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "HENÜZ BANKA HESABINIZ YOK MU?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Banka.Properties.Resources.Adsz_tasarm;
            this.pictureBox1.Location = new System.Drawing.Point(742, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 454);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Banka.Properties.Resources.png_transparent_eye_password_see_view_minimalisticons_icon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.button2.Location = new System.Drawing.Point(1251, 656);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 53);
            this.button2.TabIndex = 6;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(153)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(1698, 1012);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.kullanici_giris_sifre_al_txt);
            this.Controls.Add(this.kullanici_giris_tc_al_txt);
            this.Controls.Add(this.giris_yap_btn);
            this.Controls.Add(this.Şifre);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Giriş";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label kullanici_tc_al_lbl;
        private System.Windows.Forms.TextBox kullanici_tc_al_txt;
        private System.Windows.Forms.TextBox kullanici_ad_al_txt;
        private System.Windows.Forms.TextBox kullanici_soyad_al_txt;
        private System.Windows.Forms.Label kullanici_isim_al_lbl;
        private System.Windows.Forms.Label kullanici_soyisim_al_lbl;
        private System.Windows.Forms.TextBox kullanici_sifre_al_txt;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kullanici_sifre_al_txt_kontrol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Şifre;
        private System.Windows.Forms.Button giris_yap_btn;
        private System.Windows.Forms.TextBox kullanici_giris_tc_al_txt;
        private System.Windows.Forms.TextBox kullanici_giris_sifre_al_txt;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

