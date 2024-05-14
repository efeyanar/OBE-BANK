namespace Banka
{
    partial class Form10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kullanici_hesap_silme_sifre_kontrol_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kullanici_hesap_silme_sifre_kontrol_txt
            // 
            this.kullanici_hesap_silme_sifre_kontrol_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanici_hesap_silme_sifre_kontrol_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.kullanici_hesap_silme_sifre_kontrol_txt.Location = new System.Drawing.Point(998, 355);
            this.kullanici_hesap_silme_sifre_kontrol_txt.Multiline = true;
            this.kullanici_hesap_silme_sifre_kontrol_txt.Name = "kullanici_hesap_silme_sifre_kontrol_txt";
            this.kullanici_hesap_silme_sifre_kontrol_txt.PasswordChar = '*';
            this.kullanici_hesap_silme_sifre_kontrol_txt.Size = new System.Drawing.Size(515, 46);
            this.kullanici_hesap_silme_sifre_kontrol_txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(218, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(752, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "HESABI SİLMEK İÇİN ŞİFREYİ GİRİNİZ :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.button1.Location = new System.Drawing.Point(1029, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 85);
            this.button1.TabIndex = 2;
            this.button1.Text = "ONAYLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.button2.Location = new System.Drawing.Point(562, 539);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(398, 85);
            this.button2.TabIndex = 3;
            this.button2.Text = "ANA MENÜYE DÖN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Banka.Properties.Resources.png_transparent_eye_password_see_view_minimalisticons_icon;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.button3.Location = new System.Drawing.Point(1531, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 46);
            this.button3.TabIndex = 4;
            this.button3.Text = " ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Banka.Properties.Resources.Adsz_tasarm;
            this.pictureBox1.Location = new System.Drawing.Point(829, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(153)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(1662, 1007);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kullanici_hesap_silme_sifre_kontrol_txt);
            this.MaximizeBox = false;
            this.Name = "Form10";
            this.Text = "Hesabı Sil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kullanici_hesap_silme_sifre_kontrol_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}