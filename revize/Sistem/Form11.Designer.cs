namespace Sistem
{
    partial class Form11
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.textBox_olusturulacakBarcode = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_BarcodeBastir = new System.Windows.Forms.Button();
            this.button_kayitlariListele = new System.Windows.Forms.Button();
            this.button_kaydiSil = new System.Windows.Forms.Button();
            this.button_personelAra = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_kartDurum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_kacAdet = new System.Windows.Forms.TextBox();
            this.comboBox_alinanKartKodu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_kimdenAldiIceri_kimeVerdiDisari = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_kimAldi_kimVerdi = new System.Windows.Forms.ComboBox();
            this.comboBox_kartEylem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_barcode = new System.Windows.Forms.TextBox();
            this.button_kaydiBarkodaDonustur = new System.Windows.Forms.Button();
            this.label_aa = new System.Windows.Forms.Label();
            this.label_barcodeCode = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_saatDakikaSaniye = new System.Windows.Forms.Label();
            this.label_günAyYil = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_araKart = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_kaydiGuncelle = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.aNASAYFAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROFİLAYARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şİFREDEĞİŞTİRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dURUMBİLGİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pERSONELBİLGİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kARTBİLGİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dIŞPERSONELDURUMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gÜVENLİÇIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_olusturulacakBarcode
            // 
            this.textBox_olusturulacakBarcode.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_olusturulacakBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_olusturulacakBarcode.Font = new System.Drawing.Font("IDAHC39M Code 39 Barcode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.textBox_olusturulacakBarcode.Location = new System.Drawing.Point(22, 31);
            this.textBox_olusturulacakBarcode.Multiline = true;
            this.textBox_olusturulacakBarcode.Name = "textBox_olusturulacakBarcode";
            this.textBox_olusturulacakBarcode.Size = new System.Drawing.Size(431, 91);
            this.textBox_olusturulacakBarcode.TabIndex = 27;
            this.textBox_olusturulacakBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_BarcodeBastir
            // 
            this.button_BarcodeBastir.Font = new System.Drawing.Font("Arial Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_BarcodeBastir.Location = new System.Drawing.Point(324, 128);
            this.button_BarcodeBastir.Name = "button_BarcodeBastir";
            this.button_BarcodeBastir.Size = new System.Drawing.Size(142, 47);
            this.button_BarcodeBastir.TabIndex = 13;
            this.button_BarcodeBastir.Text = "ETİKET OLUŞTUR VE BASTIR";
            this.button_BarcodeBastir.UseVisualStyleBackColor = true;
            this.button_BarcodeBastir.Click += new System.EventHandler(this.button_BarcodeBastir_Click);
            // 
            // button_kayitlariListele
            // 
            this.button_kayitlariListele.Font = new System.Drawing.Font("Arial Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kayitlariListele.Location = new System.Drawing.Point(376, 535);
            this.button_kayitlariListele.Name = "button_kayitlariListele";
            this.button_kayitlariListele.Size = new System.Drawing.Size(97, 47);
            this.button_kayitlariListele.TabIndex = 91;
            this.button_kayitlariListele.Text = "KAYITLARI\r\nLİSTELE";
            this.button_kayitlariListele.UseVisualStyleBackColor = true;
            this.button_kayitlariListele.Click += new System.EventHandler(this.button_kayitlariListele_Click);
            // 
            // button_kaydiSil
            // 
            this.button_kaydiSil.Font = new System.Drawing.Font("Arial Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kaydiSil.Location = new System.Drawing.Point(273, 535);
            this.button_kaydiSil.Name = "button_kaydiSil";
            this.button_kaydiSil.Size = new System.Drawing.Size(97, 47);
            this.button_kaydiSil.TabIndex = 90;
            this.button_kaydiSil.Text = "KAYDI\r\nSİL";
            this.button_kaydiSil.UseVisualStyleBackColor = true;
            this.button_kaydiSil.Click += new System.EventHandler(this.button_kaydiSil_Click);
            // 
            // button_personelAra
            // 
            this.button_personelAra.Font = new System.Drawing.Font("Arial Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_personelAra.Location = new System.Drawing.Point(888, 192);
            this.button_personelAra.Name = "button_personelAra";
            this.button_personelAra.Size = new System.Drawing.Size(97, 47);
            this.button_personelAra.TabIndex = 89;
            this.button_personelAra.Text = "PERSONEL\r\nARA";
            this.button_personelAra.UseVisualStyleBackColor = true;
            this.button_personelAra.Click += new System.EventHandler(this.button_aramaYap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_kartDurum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_kacAdet);
            this.groupBox1.Controls.Add(this.comboBox_alinanKartKodu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox_kimdenAldiIceri_kimeVerdiDisari);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_kimAldi_kimVerdi);
            this.groupBox1.Controls.Add(this.comboBox_kartEylem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_barcode);
            this.groupBox1.Controls.Add(this.button_kaydiBarkodaDonustur);
            this.groupBox1.Controls.Add(this.label_aa);
            this.groupBox1.Controls.Add(this.label_barcodeCode);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(1, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 394);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KART BARCODE OLUŞTURMA FORM";
            // 
            // textBox_kartDurum
            // 
            this.textBox_kartDurum.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_kartDurum.Location = new System.Drawing.Point(225, 203);
            this.textBox_kartDurum.Multiline = true;
            this.textBox_kartDurum.Name = "textBox_kartDurum";
            this.textBox_kartDurum.Size = new System.Drawing.Size(241, 83);
            this.textBox_kartDurum.TabIndex = 110;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(19, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 18);
            this.label6.TabIndex = 109;
            this.label6.Text = "Kart Durum Açıklama :";
            // 
            // textBox_kacAdet
            // 
            this.textBox_kacAdet.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_kacAdet.Location = new System.Drawing.Point(375, 167);
            this.textBox_kacAdet.Name = "textBox_kacAdet";
            this.textBox_kacAdet.Size = new System.Drawing.Size(91, 26);
            this.textBox_kacAdet.TabIndex = 108;
            // 
            // comboBox_alinanKartKodu
            // 
            this.comboBox_alinanKartKodu.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_alinanKartKodu.FormattingEnabled = true;
            this.comboBox_alinanKartKodu.Location = new System.Drawing.Point(225, 137);
            this.comboBox_alinanKartKodu.Name = "comboBox_alinanKartKodu";
            this.comboBox_alinanKartKodu.Size = new System.Drawing.Size(241, 26);
            this.comboBox_alinanKartKodu.TabIndex = 107;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(19, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 106;
            this.label5.Text = "Kaç Adet :";
            // 
            // comboBox_kimdenAldiIceri_kimeVerdiDisari
            // 
            this.comboBox_kimdenAldiIceri_kimeVerdiDisari.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_kimdenAldiIceri_kimeVerdiDisari.FormattingEnabled = true;
            this.comboBox_kimdenAldiIceri_kimeVerdiDisari.Location = new System.Drawing.Point(225, 107);
            this.comboBox_kimdenAldiIceri_kimeVerdiDisari.Name = "comboBox_kimdenAldiIceri_kimeVerdiDisari";
            this.comboBox_kimdenAldiIceri_kimeVerdiDisari.Size = new System.Drawing.Size(239, 26);
            this.comboBox_kimdenAldiIceri_kimeVerdiDisari.TabIndex = 105;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 18);
            this.label3.TabIndex = 104;
            this.label3.Text = "Alınan Kart Kodu :";
            // 
            // comboBox_kimAldi_kimVerdi
            // 
            this.comboBox_kimAldi_kimVerdi.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_kimAldi_kimVerdi.FormattingEnabled = true;
            this.comboBox_kimAldi_kimVerdi.Location = new System.Drawing.Point(225, 77);
            this.comboBox_kimAldi_kimVerdi.Name = "comboBox_kimAldi_kimVerdi";
            this.comboBox_kimAldi_kimVerdi.Size = new System.Drawing.Size(241, 26);
            this.comboBox_kimAldi_kimVerdi.TabIndex = 102;
            // 
            // comboBox_kartEylem
            // 
            this.comboBox_kartEylem.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_kartEylem.FormattingEnabled = true;
            this.comboBox_kartEylem.Items.AddRange(new object[] {
            "Teslim Alındı",
            "Teslim Verildi"});
            this.comboBox_kartEylem.Location = new System.Drawing.Point(225, 47);
            this.comboBox_kartEylem.Name = "comboBox_kartEylem";
            this.comboBox_kartEylem.Size = new System.Drawing.Size(241, 26);
            this.comboBox_kartEylem.TabIndex = 101;
            this.comboBox_kartEylem.SelectedIndexChanged += new System.EventHandler(this.comboBox_kartEylem_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 79;
            this.label1.Text = "xxx";
            // 
            // textBox_barcode
            // 
            this.textBox_barcode.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_barcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_barcode.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_barcode.Location = new System.Drawing.Point(225, 302);
            this.textBox_barcode.Name = "textBox_barcode";
            this.textBox_barcode.Size = new System.Drawing.Size(240, 15);
            this.textBox_barcode.TabIndex = 44;
            this.textBox_barcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_kaydiBarkodaDonustur
            // 
            this.button_kaydiBarkodaDonustur.Font = new System.Drawing.Font("Arial Black", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kaydiBarkodaDonustur.Location = new System.Drawing.Point(269, 335);
            this.button_kaydiBarkodaDonustur.Name = "button_kaydiBarkodaDonustur";
            this.button_kaydiBarkodaDonustur.Size = new System.Drawing.Size(195, 47);
            this.button_kaydiBarkodaDonustur.TabIndex = 77;
            this.button_kaydiBarkodaDonustur.Text = "KAYDI BARKODA DÖNÜŞTÜR\r\nVE FORMU KAYDET";
            this.button_kaydiBarkodaDonustur.UseVisualStyleBackColor = true;
            this.button_kaydiBarkodaDonustur.Click += new System.EventHandler(this.button_kaydiBarkodaDonustur_Click);
            // 
            // label_aa
            // 
            this.label_aa.AutoSize = true;
            this.label_aa.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_aa.Location = new System.Drawing.Point(19, 115);
            this.label_aa.Name = "label_aa";
            this.label_aa.Size = new System.Drawing.Size(35, 18);
            this.label_aa.TabIndex = 41;
            this.label_aa.Text = "xxx";
            // 
            // label_barcodeCode
            // 
            this.label_barcodeCode.AutoSize = true;
            this.label_barcodeCode.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_barcodeCode.Location = new System.Drawing.Point(19, 299);
            this.label_barcodeCode.Name = "label_barcodeCode";
            this.label_barcodeCode.Size = new System.Drawing.Size(79, 18);
            this.label_barcodeCode.TabIndex = 43;
            this.label_barcodeCode.Text = "Barcode :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(19, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Kart Eylem :";
            // 
            // label_saatDakikaSaniye
            // 
            this.label_saatDakikaSaniye.AutoSize = true;
            this.label_saatDakikaSaniye.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_saatDakikaSaniye.Location = new System.Drawing.Point(1190, 111);
            this.label_saatDakikaSaniye.Name = "label_saatDakikaSaniye";
            this.label_saatDakikaSaniye.Size = new System.Drawing.Size(17, 18);
            this.label_saatDakikaSaniye.TabIndex = 87;
            this.label_saatDakikaSaniye.Text = "0";
            // 
            // label_günAyYil
            // 
            this.label_günAyYil.AutoSize = true;
            this.label_günAyYil.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_günAyYil.Location = new System.Drawing.Point(1291, 111);
            this.label_günAyYil.Name = "label_günAyYil";
            this.label_günAyYil.Size = new System.Drawing.Size(17, 18);
            this.label_günAyYil.TabIndex = 86;
            this.label_günAyYil.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(365, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_olusturulacakBarcode);
            this.groupBox2.Controls.Add(this.button_BarcodeBastir);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(1, 579);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 181);
            this.groupBox2.TabIndex = 98;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Barcode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(536, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 40);
            this.label4.TabIndex = 95;
            this.label4.Text = "Personel Ara : \r\n(Personel İsim ya da Barcode ile)";
            // 
            // textBox_araKart
            // 
            this.textBox_araKart.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_araKart.Location = new System.Drawing.Point(826, 168);
            this.textBox_araKart.Name = "textBox_araKart";
            this.textBox_araKart.Size = new System.Drawing.Size(159, 22);
            this.textBox_araKart.TabIndex = 94;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(479, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(930, 495);
            this.dataGridView1.TabIndex = 93;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // button_kaydiGuncelle
            // 
            this.button_kaydiGuncelle.Font = new System.Drawing.Font("Arial Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kaydiGuncelle.Location = new System.Drawing.Point(170, 535);
            this.button_kaydiGuncelle.Name = "button_kaydiGuncelle";
            this.button_kaydiGuncelle.Size = new System.Drawing.Size(97, 47);
            this.button_kaydiGuncelle.TabIndex = 92;
            this.button_kaydiGuncelle.Text = "KAYDI\r\nGÜNCELLE";
            this.button_kaydiGuncelle.UseVisualStyleBackColor = true;
            this.button_kaydiGuncelle.Click += new System.EventHandler(this.button_kaydiGuncelle_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menuStrip2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aNASAYFAToolStripMenuItem,
            this.pROFİLAYARToolStripMenuItem,
            this.dURUMBİLGİToolStripMenuItem,
            this.gÜVENLİÇIKIŞToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1420, 24);
            this.menuStrip2.TabIndex = 99;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // aNASAYFAToolStripMenuItem
            // 
            this.aNASAYFAToolStripMenuItem.Name = "aNASAYFAToolStripMenuItem";
            this.aNASAYFAToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.aNASAYFAToolStripMenuItem.Text = "ANASAYFA";
            // 
            // pROFİLAYARToolStripMenuItem
            // 
            this.pROFİLAYARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şİFREDEĞİŞTİRToolStripMenuItem});
            this.pROFİLAYARToolStripMenuItem.Name = "pROFİLAYARToolStripMenuItem";
            this.pROFİLAYARToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.pROFİLAYARToolStripMenuItem.Text = "GÜVENLİK AYAR";
            // 
            // şİFREDEĞİŞTİRToolStripMenuItem
            // 
            this.şİFREDEĞİŞTİRToolStripMenuItem.Name = "şİFREDEĞİŞTİRToolStripMenuItem";
            this.şİFREDEĞİŞTİRToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.şİFREDEĞİŞTİRToolStripMenuItem.Text = "ŞİFRE DEĞİŞTİR";
            // 
            // dURUMBİLGİToolStripMenuItem
            // 
            this.dURUMBİLGİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pERSONELBİLGİToolStripMenuItem,
            this.kARTBİLGİToolStripMenuItem,
            this.dIŞPERSONELDURUMToolStripMenuItem});
            this.dURUMBİLGİToolStripMenuItem.Name = "dURUMBİLGİToolStripMenuItem";
            this.dURUMBİLGİToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.dURUMBİLGİToolStripMenuItem.Text = "DURUM BİLGİ";
            // 
            // pERSONELBİLGİToolStripMenuItem
            // 
            this.pERSONELBİLGİToolStripMenuItem.Name = "pERSONELBİLGİToolStripMenuItem";
            this.pERSONELBİLGİToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.pERSONELBİLGİToolStripMenuItem.Text = "ELEKTRONİK PERSONEL DURUM";
            // 
            // kARTBİLGİToolStripMenuItem
            // 
            this.kARTBİLGİToolStripMenuItem.Name = "kARTBİLGİToolStripMenuItem";
            this.kARTBİLGİToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.kARTBİLGİToolStripMenuItem.Text = "KART DURUM";
            this.kARTBİLGİToolStripMenuItem.Click += new System.EventHandler(this.kARTBİLGİToolStripMenuItem_Click);
            // 
            // dIŞPERSONELDURUMToolStripMenuItem
            // 
            this.dIŞPERSONELDURUMToolStripMenuItem.Name = "dIŞPERSONELDURUMToolStripMenuItem";
            this.dIŞPERSONELDURUMToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.dIŞPERSONELDURUMToolStripMenuItem.Text = "DIŞ PERSONEL DURUM";
            // 
            // gÜVENLİÇIKIŞToolStripMenuItem
            // 
            this.gÜVENLİÇIKIŞToolStripMenuItem.Name = "gÜVENLİÇIKIŞToolStripMenuItem";
            this.gÜVENLİÇIKIŞToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.gÜVENLİÇIKIŞToolStripMenuItem.Text = "GÜVENLİ ÇIKIŞ";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1420, 763);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.button_kayitlariListele);
            this.Controls.Add(this.button_kaydiSil);
            this.Controls.Add(this.button_personelAra);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_saatDakikaSaniye);
            this.Controls.Add(this.label_günAyYil);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_araKart);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_kaydiGuncelle);
            this.Name = "Form11";
            this.Text = "Form11";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form11_FormClosed);
            this.Load += new System.EventHandler(this.Form11_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_olusturulacakBarcode;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_BarcodeBastir;
        private System.Windows.Forms.Button button_kayitlariListele;
        private System.Windows.Forms.Button button_kaydiSil;
        private System.Windows.Forms.Button button_personelAra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_barcode;
        private System.Windows.Forms.Label label_barcodeCode;
        private System.Windows.Forms.Label label_aa;
        private System.Windows.Forms.Button button_kaydiBarkodaDonustur;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_saatDakikaSaniye;
        private System.Windows.Forms.Label label_günAyYil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_araKart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_kaydiGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_kimdenAldiIceri_kimeVerdiDisari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_kimAldi_kimVerdi;
        private System.Windows.Forms.ComboBox comboBox_kartEylem;
        private System.Windows.Forms.ComboBox comboBox_alinanKartKodu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_kacAdet;
        private System.Windows.Forms.TextBox textBox_kartDurum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem aNASAYFAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROFİLAYARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şİFREDEĞİŞTİRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dURUMBİLGİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pERSONELBİLGİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kARTBİLGİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dIŞPERSONELDURUMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gÜVENLİÇIKIŞToolStripMenuItem;
    }
}