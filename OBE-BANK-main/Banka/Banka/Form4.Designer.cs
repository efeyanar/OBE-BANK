namespace Banka
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.alacakli_iban_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.alacakli_ad_soyad_sor_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.alacakli_ad_dogrula_txt = new System.Windows.Forms.TextBox();
            this.alacakli_soyad_dogrula_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(359, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALACAKLI IBAN :";
            // 
            // alacakli_iban_txt
            // 
            this.alacakli_iban_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alacakli_iban_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.alacakli_iban_txt.Location = new System.Drawing.Point(728, 422);
            this.alacakli_iban_txt.Name = "alacakli_iban_txt";
            this.alacakli_iban_txt.Size = new System.Drawing.Size(475, 53);
            this.alacakli_iban_txt.TabIndex = 1;
            this.alacakli_iban_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.button1.Location = new System.Drawing.Point(746, 754);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(435, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "DOĞRULA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // alacakli_ad_soyad_sor_lbl
            // 
            this.alacakli_ad_soyad_sor_lbl.AutoSize = true;
            this.alacakli_ad_soyad_sor_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alacakli_ad_soyad_sor_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.alacakli_ad_soyad_sor_lbl.Location = new System.Drawing.Point(720, 521);
            this.alacakli_ad_soyad_sor_lbl.Name = "alacakli_ad_soyad_sor_lbl";
            this.alacakli_ad_soyad_sor_lbl.Size = new System.Drawing.Size(158, 46);
            this.alacakli_ad_soyad_sor_lbl.TabIndex = 3;
            this.alacakli_ad_soyad_sor_lbl.Text = "______";
            this.alacakli_ad_soyad_sor_lbl.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(307, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1282, 61);
            this.label2.TabIndex = 4;
            this.label2.Text = "İŞLEME DEVAM ETMEK İÇİN BİLGİLERİ GİRİNİZ !\r\n";
            // 
            // alacakli_ad_dogrula_txt
            // 
            this.alacakli_ad_dogrula_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alacakli_ad_dogrula_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.alacakli_ad_dogrula_txt.Location = new System.Drawing.Point(728, 615);
            this.alacakli_ad_dogrula_txt.Name = "alacakli_ad_dogrula_txt";
            this.alacakli_ad_dogrula_txt.Size = new System.Drawing.Size(475, 53);
            this.alacakli_ad_dogrula_txt.TabIndex = 5;
            // 
            // alacakli_soyad_dogrula_txt
            // 
            this.alacakli_soyad_dogrula_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alacakli_soyad_dogrula_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.alacakli_soyad_dogrula_txt.Location = new System.Drawing.Point(728, 672);
            this.alacakli_soyad_dogrula_txt.Name = "alacakli_soyad_dogrula_txt";
            this.alacakli_soyad_dogrula_txt.Size = new System.Drawing.Size(475, 53);
            this.alacakli_soyad_dogrula_txt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(582, 618);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 46);
            this.label3.TabIndex = 7;
            this.label3.Text = "İSİM :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.label4.Location = new System.Drawing.Point(483, 675);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 46);
            this.label4.TabIndex = 8;
            this.label4.Text = "SOY İSİM :";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.button2.Location = new System.Drawing.Point(746, 843);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(435, 65);
            this.button2.TabIndex = 9;
            this.button2.Text = "ANA MENÜYE DÖN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Banka.Properties.Resources.Adsz_tasarm;
            this.pictureBox1.Location = new System.Drawing.Point(728, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(153)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(1562, 949);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.alacakli_soyad_dogrula_txt);
            this.Controls.Add(this.alacakli_ad_dogrula_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.alacakli_ad_soyad_sor_lbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.alacakli_iban_txt);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.Text = "Para Transferi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox alacakli_iban_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label alacakli_ad_soyad_sor_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox alacakli_ad_dogrula_txt;
        private System.Windows.Forms.TextBox alacakli_soyad_dogrula_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}