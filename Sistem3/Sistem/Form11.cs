using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using ZXing;
using ZXing.Aztec;
using ZXing.Common;
using ZXing.QrCode;

namespace Sistem
{
    public partial class Form11 : Form
    {
        public Form11()
        {

            InitializeComponent();

        }

        static string conString = "Data Source=DESKTOP-6GFGG91\\SQLEXPRESS;Initial Catalog=kontrol;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);

        PrintDialog PRD = new PrintDialog();

        private void Form11_Load(object sender, EventArgs e)
        {

            label_barcodeCode.Visible = false;
            textBox_barcode.Visible = false;

            DoldurComboBox();
            DoldurKimdenAldiKimeVerdi();
            DoldurUrunComboBox();

        }

        private DataTable currentTable = new DataTable();

        public void KayitlariGetir()
        {

            // Kayıtları listelemek için sorgu
            string listeleSorgusu = "SELECT idKart, eylemKart, kartKodu, kartAdet, kartDurumAciklama, barcodeKart, elektronikPersonel, disPersonel FROM kart";
            SqlCommand komut = new SqlCommand(listeleSorgusu, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(komut);

            connect.Open();
            adapter.Fill(currentTable); // Verileri currentTable adlı DataTable'a doldurur
            connect.Close();

            dataGridView1.DataSource = currentTable; // DataGridView'e DataTable'ı bağlar

        }

        public void veriSil(int idd)
        {

            string sil = "DELETE FROM kart WHERE idKart = @idd";

            SqlCommand komut = new SqlCommand(sil, connect);
            connect.Open();
            komut.Parameters.AddWithValue("@idd", idd);
            komut.ExecuteNonQuery();
            connect.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label_günAyYil.Text = DateTime.Now.ToString("dd.MM.yyyy");
            label_saatDakikaSaniye.Text = DateTime.Now.ToString("HH.mm.ss");

        }

        private void button_kayitlariListele_Click(object sender, EventArgs e)
        {

            // KayitlariGetir();

            // Kayıtları listelemek için sorgu
            string listeleSorgusu = "SELECT idKart, eylemKart, kartKodu, kartAdet, kartDurumAciklama, barcodeKart, elektronikPersonel, disPersonel FROM kart";
            SqlCommand komut = new SqlCommand(listeleSorgusu, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(komut);

            connect.Open();
            adapter.Fill(currentTable); // Verileri currentTable adlı DataTable'a doldurur
            connect.Close();

            dataGridView1.DataSource = currentTable; // DataGridView'e DataTable'ı bağlar
        
        }

        private void button_aramaYap_Click(object sender, EventArgs e)
        {

            string arananMetin = textBox_araKart.Text.Trim();

            // Arama sorgusu
            string araSorgusu = @"SELECT idKart, eylemKart, kartKodu, kartAdet, kartDurumAciklama, barcodeKart, elektronikPersonel, disPersonel 
                         FROM kart 
                         WHERE kartKodu LIKE '%' + @arananMetin + '%'
                         OR elektronikPersonel IN (SELECT CONCAT(isim, ' ', soyisim) FROM kullanici WHERE isim LIKE '%' + @arananMetin + '%')
                         OR disPersonel IN (SELECT CONCAT(isimiDis, ' ', soyadiDis) FROM disPersonel WHERE isimiDis LIKE '%' + @arananMetin + '%')
                         OR eylemKart LIKE '%' + @arananMetin + '%'
                         OR barcodeKart LIKE '%' + @arananMetin + '%'
                         OR kartKodu IN (SELECT urunKodu FROM urunBilgi WHERE isim LIKE '%' + @arananMetin + '%')";

            SqlCommand komut = new SqlCommand(araSorgusu, connect);
            komut.Parameters.AddWithValue("@arananMetin", arananMetin);
            SqlDataAdapter adapter = new SqlDataAdapter(komut);

            DataTable filteredTable = new DataTable(); // Boş bir DataTable oluşturur

            connect.Open();
            adapter.Fill(filteredTable); // Filtrelenmiş verileri filteredTable adlı DataTable'a doldurur
            connect.Close();

            dataGridView1.DataSource = filteredTable; // DataGridView'e DataTable'ı bağlar

        }

        private void DoldurUrunComboBox()
        {

            comboBox_alinanKartKodu.Items.Clear();

            // Veritabanı bağlantısını açın
            connect.Open();

            // urunBilgi tablosundan isim ve urunKodu sütunlarını alın
            string sorgu = "SELECT isim, urunKodu FROM urunBilgi";

            SqlCommand komut = new SqlCommand(sorgu, connect);
            SqlDataReader okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                // ComboBox'a ürün kodu + ürün ismini ekleyin
                string urunAdi = okuyucu["isim"].ToString();
                string urunKodu = okuyucu["urunKodu"].ToString();
                string tamUrunAdi = urunKodu + " " + urunAdi;
                comboBox_alinanKartKodu.Items.Add(tamUrunAdi);
            }

            // Veritabanı bağlantısını kapatın
            connect.Close();

        }
        private void DoldurComboBox()
        {

            comboBox_kimAldi_kimVerdi.Items.Clear();
            // Veritabanı bağlantısını açın
            connect.Open();

            // Kullanıcı adı ve soyadı bilgilerini içeren SQL sorgusu
            string sorgu = "SELECT CONCAT(isim, ' ', soyisim) AS TamAd FROM kullanici";

            SqlCommand komut = new SqlCommand(sorgu, connect);
            SqlDataReader okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                // ComboBox'a kullanıcı adı ve soyadını ekleyin
                comboBox_kimAldi_kimVerdi.Items.Add(okuyucu["TamAd"].ToString());
            }

            // Veritabanı bağlantısını kapatın
            connect.Close();

        }

        private void DoldurKimdenAldiKimeVerdi()
        {

            comboBox_kimdenAldiIceri_kimeVerdiDisari.Items.Clear();

            // Veritabanı bağlantısını açın
            connect.Open();

            // disPersonel tablosundan isim ve soyisim sütunlarını birleştirip alın
            string sorgu = "SELECT CONCAT(isimiDis, ' ', soyadiDis) AS TamAd FROM disPersonel";

            SqlCommand komut = new SqlCommand(sorgu, connect);
            SqlDataReader okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                // ComboBox'a isim ve soyisimi ekleyin
                comboBox_kimdenAldiIceri_kimeVerdiDisari.Items.Add(okuyucu["TamAd"].ToString());
            }

            // Veritabanı bağlantısını kapatın
            connect.Close();

        }

        private void button_kaydiBarkodaDonustur_Click(object sender, EventArgs e)
        {

            try
            {
                connect.Open();

                string yil = DateTime.Now.Year.ToString();
                string ay = DateTime.Now.Month.ToString("00");
                string gun = DateTime.Now.Day.ToString("00");
                string saat = DateTime.Now.Hour.ToString("00");
                string dakika = DateTime.Now.Minute.ToString("00");
                string tarihKod = gun + ay;

                textBox_barcode.Text = "*" + "(XX)XXXXXXX" + tarihKod + "(" + ")" + "*";

                string secilenKullanici = comboBox_kimAldi_kimVerdi.SelectedItem.ToString();
                string secilenEylem = comboBox_kartEylem.SelectedItem.ToString();
                string secilenKimdenAldiIceri_kimeVerdiDisari = comboBox_kimdenAldiIceri_kimeVerdiDisari.SelectedItem.ToString();

                string[] adSoyad = secilenKullanici.Split(' ');
                string ad = adSoyad[0];
                string soyad = adSoyad[1];

                string kayit = "INSERT INTO kart (eylemKart, kartKodu, kartAdet, kartDurumAciklama, barcodeKart, elektronikPersonel, disPersonel) VALUES (@eylemKart, @kartKodu, @kartAdet, @kartDurumAciklama, @barcodeKart, @elektronikPersonel, @disPersonel)";
                SqlCommand komut = new SqlCommand(kayit, connect);

                komut.Parameters.AddWithValue("@eylemKart", secilenEylem);
                komut.Parameters.AddWithValue("@kartKodu", comboBox_alinanKartKodu.Text);
                komut.Parameters.AddWithValue("@kartAdet", textBox_kacAdet.Text);
                komut.Parameters.AddWithValue("@kartDurumAciklama", textBox_kartDurum.Text);
                komut.Parameters.AddWithValue("@barcodeKart", textBox_barcode.Text);
                komut.Parameters.AddWithValue("@elektronikPersonel", secilenKullanici);
                komut.Parameters.AddWithValue("@disPersonel", secilenKimdenAldiIceri_kimeVerdiDisari);

                komut.ExecuteNonQuery();

                MessageBox.Show("Kayıt Ekleme Başarılı");

                label_barcodeCode.Visible = true;
                textBox_barcode.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }

            KayitlariGetir();

        }



        private void button_kaydiSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir kayıt seçin.");
                return;
            }

            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int idd = Convert.ToInt32(drow.Cells[0].Value);
                veriSil(idd);
            }

            currentTable.Clear(); // Mevcut verileri temizle
            KayitlariGetir(); // Güncel verileri yükle
        }


        int i = 0;

        private void button_kaydiGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz bir kayıt seçin.");
                return;
            }

            if (comboBox_kartEylem.SelectedItem == null || string.IsNullOrEmpty(comboBox_alinanKartKodu.Text) || string.IsNullOrEmpty(textBox_kacAdet.Text) || string.IsNullOrEmpty(textBox_kartDurum.Text) || comboBox_kimAldi_kimVerdi.SelectedItem == null || comboBox_kimdenAldiIceri_kimeVerdiDisari.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return; // Gerekli alanlar boşsa işlemi iptal et
            }

            connect.Open();

            string kayitGuncelle = "UPDATE kart SET eylemKart = @eylemKart, kartKodu = @kartKodu, kartAdet = @kartAdet, kartDurumAciklama = @kartDurumAciklama, elektronikPersonel = @elektronikPersonel, disPersonel = @disPersonel WHERE idKart = @idd";
            SqlCommand komut = new SqlCommand(kayitGuncelle, connect);

            komut.Parameters.AddWithValue("@eylemKart", comboBox_kartEylem.Text);
            komut.Parameters.AddWithValue("@kartKodu", comboBox_alinanKartKodu.Text);
            komut.Parameters.AddWithValue("@kartAdet", textBox_kacAdet.Text);
            komut.Parameters.AddWithValue("@kartDurumAciklama", textBox_kartDurum.Text);
            komut.Parameters.AddWithValue("@elektronikPersonel", comboBox_kimAldi_kimVerdi.SelectedItem.ToString()); // Elektronik personel adı
            komut.Parameters.AddWithValue("@disPersonel", comboBox_kimdenAldiIceri_kimeVerdiDisari.SelectedItem.ToString()); // Dis personel adı

            komut.Parameters.AddWithValue("@idd", dataGridView1.SelectedRows[0].Cells[0].Value);

            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıtlar Başarıyla Güncellendi!");
            connect.Close();

            // Verileri tekrar çekip DataGridView'i güncelle
            currentTable.Clear(); // Mevcut verileri temizle
            KayitlariGetir(); // Güncel verileri yükle
        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            i = e.RowIndex;

            comboBox_kartEylem.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            comboBox_alinanKartKodu.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox_kacAdet.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBox_kartDurum.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();

        }

        private void button_BarcodeBastir_Click(object sender, EventArgs e)
        {

            PrintDocument kagit = new PrintDocument();
            DialogResult yazdirmaIslemi;
            yazdirmaIslemi = PRD.ShowDialog();
            kagit.PrintPage += Kagit_PrintPage;

            if (yazdirmaIslemi == DialogResult.OK)
            {
                kagit.Print();
            }

        }

        private void Kagit_PrintPage(object sender, PrintPageEventArgs e)
        {

            string neYazilacak = textBox_olusturulacakBarcode.Text;
            Font yaziTipi = new Font("IDAHC39M Code 39 Barcode", 11);
            SolidBrush kalem = new SolidBrush(Color.Black);
            e.Graphics.DrawString(neYazilacak, yaziTipi, kalem, 43, 60);

        }

        private void comboBox_kartEylem_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            string secilenEylem = comboBox_kartEylem.SelectedItem.ToString();

            if (secilenEylem == "Teslim Alındı")
            {
                label1.Text = "Teslim Alan Personel :";
                label_aa.Text = "Teslim Veren Personel :";
            }
            else if (secilenEylem == "Teslim Verildi")
            {
                label1.Text = "Teslim Veren Personel :";
                label_aa.Text = "Teslim Alan Personel :";
            }

        }
    }
}
