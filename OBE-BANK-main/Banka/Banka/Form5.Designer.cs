namespace Banka
{
    partial class Form5
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
            this.gonderilecek_tutar_txt = new System.Windows.Forms.TextBox();
            this.aciklama_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.komisyon_tutar_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(527, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "GÖNDERİLECEK TUTAR :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gonderilecek_tutar_txt
            // 
            this.gonderilecek_tutar_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gonderilecek_tutar_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.gonderilecek_tutar_txt.Location = new System.Drawing.Point(1056, 406);
            this.gonderilecek_tutar_txt.Name = "gonderilecek_tutar_txt";
            this.gonderilecek_tutar_txt.Size = new System.Drawing.Size(330, 53);
            this.gonderilecek_tutar_txt.TabIndex = 1;
            this.gonderilecek_tutar_txt.TextChanged += new System.EventHandler(this.gonderilecek_tutar_txt_TextChanged);
            // 
            // aciklama_txt
            // 
            this.aciklama_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aciklama_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.aciklama_txt.Location = new System.Drawing.Point(818, 484);
            this.aciklama_txt.Multiline = true;
            this.aciklama_txt.Name = "aciklama_txt";
            this.aciklama_txt.Size = new System.Drawing.Size(568, 228);
            this.aciklama_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(527, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "AÇIKLAMA :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.button1.Location = new System.Drawing.Point(1091, 835);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 71);
            this.button1.TabIndex = 4;
            this.button1.Text = "ONAYLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // komisyon_tutar_txt
            // 
            this.komisyon_tutar_txt.BackColor = System.Drawing.Color.Gainsboro;
            this.komisyon_tutar_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.komisyon_tutar_txt.Enabled = false;
            this.komisyon_tutar_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.komisyon_tutar_txt.ForeColor = System.Drawing.Color.Black;
            this.komisyon_tutar_txt.Location = new System.Drawing.Point(1040, 748);
            this.komisyon_tutar_txt.Name = "komisyon_tutar_txt";
            this.komisyon_tutar_txt.Size = new System.Drawing.Size(211, 46);
            this.komisyon_tutar_txt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(527, 748);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(507, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "KESİLECEK KOMİSYON :";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.button2.Location = new System.Drawing.Point(535, 835);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(398, 71);
            this.button2.TabIndex = 8;
            this.button2.Text = "ANA MENÜYE DÖN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Banka.Properties.Resources.Adsz_tasarm;
            this.pictureBox1.Location = new System.Drawing.Point(818, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(153)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(1754, 1061);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.komisyon_tutar_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aciklama_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gonderilecek_tutar_txt);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.Text = "Para Gönder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gonderilecek_tutar_txt;
        private System.Windows.Forms.TextBox aciklama_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox komisyon_tutar_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}