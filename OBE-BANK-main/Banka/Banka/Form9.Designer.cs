namespace Banka
{
    partial class Form9
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
            this.yeni_ad_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.yeni_soyad_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(623, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "İSİM GİRİNİZ :";
            // 
            // yeni_ad_txt
            // 
            this.yeni_ad_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeni_ad_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.yeni_ad_txt.Location = new System.Drawing.Point(949, 397);
            this.yeni_ad_txt.Name = "yeni_ad_txt";
            this.yeni_ad_txt.Size = new System.Drawing.Size(397, 53);
            this.yeni_ad_txt.TabIndex = 1;
            this.yeni_ad_txt.TextChanged += new System.EventHandler(this.yeni_ad_txt_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.button1.Location = new System.Drawing.Point(1048, 621);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "ONAYLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yeni_soyad_txt
            // 
            this.yeni_soyad_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeni_soyad_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.yeni_soyad_txt.Location = new System.Drawing.Point(949, 494);
            this.yeni_soyad_txt.Name = "yeni_soyad_txt";
            this.yeni_soyad_txt.Size = new System.Drawing.Size(397, 53);
            this.yeni_soyad_txt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(528, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "SOY İSİM GİRİNİZ :";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.button2.Location = new System.Drawing.Point(536, 621);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(414, 64);
            this.button2.TabIndex = 5;
            this.button2.Text = "ANA MENÜYE DÖN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Banka.Properties.Resources.Adsz_tasarm;
            this.pictureBox1.Location = new System.Drawing.Point(806, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(153)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(1580, 1012);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.yeni_soyad_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yeni_ad_txt);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form9";
            this.Text = "Bilgi Güncelleme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yeni_ad_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox yeni_soyad_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}