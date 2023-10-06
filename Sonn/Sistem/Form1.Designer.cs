namespace Sistem
{
    partial class Form_KullaniciGiris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_KullaniciGiris));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_kullaniciAd = new System.Windows.Forms.TextBox();
            this.textBox_kullaniciParola = new System.Windows.Forms.TextBox();
            this.pictureBox_gizliAcik = new System.Windows.Forms.PictureBox();
            this.button_GirisYap = new System.Windows.Forms.Button();
            this.label_saatDakikaSaniye = new System.Windows.Forms.Label();
            this.label_günAyYil = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gizliAcik)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(122, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(157, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 33);
            this.label4.TabIndex = 46;
            this.label4.Text = "PERSONEL GİRİŞ PANELİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(93, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 27);
            this.label1.TabIndex = 47;
            this.label1.Text = "Kullanıcı Ad : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(93, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 27);
            this.label2.TabIndex = 48;
            this.label2.Text = "Kullanıcı Parola :";
            // 
            // textBox_kullaniciAd
            // 
            this.textBox_kullaniciAd.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_kullaniciAd.Location = new System.Drawing.Point(301, 244);
            this.textBox_kullaniciAd.Name = "textBox_kullaniciAd";
            this.textBox_kullaniciAd.Size = new System.Drawing.Size(229, 26);
            this.textBox_kullaniciAd.TabIndex = 49;
            // 
            // textBox_kullaniciParola
            // 
            this.textBox_kullaniciParola.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_kullaniciParola.Location = new System.Drawing.Point(301, 288);
            this.textBox_kullaniciParola.Name = "textBox_kullaniciParola";
            this.textBox_kullaniciParola.Size = new System.Drawing.Size(229, 26);
            this.textBox_kullaniciParola.TabIndex = 50;
            // 
            // pictureBox_gizliAcik
            // 
            this.pictureBox_gizliAcik.Location = new System.Drawing.Point(536, 285);
            this.pictureBox_gizliAcik.Name = "pictureBox_gizliAcik";
            this.pictureBox_gizliAcik.Size = new System.Drawing.Size(65, 30);
            this.pictureBox_gizliAcik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gizliAcik.TabIndex = 52;
            this.pictureBox_gizliAcik.TabStop = false;
            this.pictureBox_gizliAcik.Click += new System.EventHandler(this.pictureBox_gizliAcik_Click);
            // 
            // button_GirisYap
            // 
            this.button_GirisYap.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_GirisYap.Location = new System.Drawing.Point(409, 325);
            this.button_GirisYap.Name = "button_GirisYap";
            this.button_GirisYap.Size = new System.Drawing.Size(121, 42);
            this.button_GirisYap.TabIndex = 53;
            this.button_GirisYap.Text = "GİRİŞ YAP";
            this.button_GirisYap.UseVisualStyleBackColor = true;
            this.button_GirisYap.Click += new System.EventHandler(this.button_GirisYap_Click);
            // 
            // label_saatDakikaSaniye
            // 
            this.label_saatDakikaSaniye.AutoSize = true;
            this.label_saatDakikaSaniye.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_saatDakikaSaniye.Location = new System.Drawing.Point(531, 149);
            this.label_saatDakikaSaniye.Name = "label_saatDakikaSaniye";
            this.label_saatDakikaSaniye.Size = new System.Drawing.Size(14, 16);
            this.label_saatDakikaSaniye.TabIndex = 55;
            this.label_saatDakikaSaniye.Text = "0";
            // 
            // label_günAyYil
            // 
            this.label_günAyYil.AutoSize = true;
            this.label_günAyYil.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_günAyYil.Location = new System.Drawing.Point(597, 149);
            this.label_günAyYil.Name = "label_günAyYil";
            this.label_günAyYil.Size = new System.Drawing.Size(14, 16);
            this.label_günAyYil.TabIndex = 56;
            this.label_günAyYil.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_KullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(681, 402);
            this.Controls.Add(this.label_günAyYil);
            this.Controls.Add(this.label_saatDakikaSaniye);
            this.Controls.Add(this.button_GirisYap);
            this.Controls.Add(this.pictureBox_gizliAcik);
            this.Controls.Add(this.textBox_kullaniciParola);
            this.Controls.Add(this.textBox_kullaniciAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_KullaniciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROVENT";
            this.Load += new System.EventHandler(this.Form_KullaniciGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gizliAcik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_kullaniciAd;
        private System.Windows.Forms.TextBox textBox_kullaniciParola;
        private System.Windows.Forms.PictureBox pictureBox_gizliAcik;
        private System.Windows.Forms.Button button_GirisYap;
        private System.Windows.Forms.Label label_saatDakikaSaniye;
        private System.Windows.Forms.Label label_günAyYil;
        private System.Windows.Forms.Timer timer1;
    }
}

