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
        }

        public void kayitlariGetir()
        {
            string getir = "SELECT k.*, u.isim AS kullaniciIsim, u.soyisim AS kullaniciSoyisim " +
                           "FROM kart k " +
                           "INNER JOIN kullanici u ON k.kullaniciId = u.kullaniciId";

            SqlCommand komut = new SqlCommand(getir, connect);
            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

            connect.Close();
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
            kayitlariGetir();
        }

        private void button_personelAra_Click(object sender, EventArgs e)
        {
            string ara = "SELECT * FROM kart k INNER JOIN kullanici u ON k.kullaniciId = u.kullaniciId WHERE k.eylemKart LIKE '%' + @eylemKart + '%' OR k.barcodeKart = @barcodeKart OR u.isim LIKE '%' + @isim + '%' OR u.soyisim LIKE '%' + @soyisim + '%'";
            SqlCommand komut = new SqlCommand(ara, connect);

            komut.Parameters.AddWithValue("@eylemKart", textBox_araKart.Text);
            komut.Parameters.AddWithValue("@barcodeKart", textBox_araKart.Text);
            komut.Parameters.AddWithValue("@isim", textBox_araKart.Text);
            komut.Parameters.AddWithValue("@soyisim", textBox_araKart.Text);

            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

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
                textBox_olusturulacakBarcode.Text = "*" + "(XX)XXXXXXX" + tarihKod + "("  + ")" + "*";

                string kayit = "INSERT INTO kart (eylemKart, kartKodu, kartAdet, kartDurumAciklama, barcodeKart) VALUES (@eylemKart, @kartKodu, @kartAdet, @kartDurumAciklama, @barcodeKart)";
                SqlCommand komut = new SqlCommand(kayit, connect);

                komut.Parameters.AddWithValue("@eylemKart", comboBox_kartEylem.Text);
                komut.Parameters.AddWithValue("@kartKodu", comboBox_alinanKartKodu.Text);
                komut.Parameters.AddWithValue("@kartAdet", textBox_kacAdet.Text);
                
                komut.Parameters.AddWithValue("@kartDurumAciklama", textBox_kartDurum.Text);
                komut.Parameters.AddWithValue("@barcodeKart", textBox_barcode.Text);

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
        }

        private void button_kaydiSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int idd = Convert.ToInt32(drow.Cells[0].Value);
                veriSil(idd);
                kayitlariGetir();
            }
        }

        int i = 0;

        private void button_kaydiGuncelle_Click(object sender, EventArgs e)
        {
            connect.Open();

            string kayitGuncelle = "UPDATE kart SET eylemKart = @eylemKart, kartKodu = @kartKodu, kartAdet = @kartAdet, kartDurumAciklama = @kartDurumAciklama WHERE idKart = @idd";
            SqlCommand komut = new SqlCommand(kayitGuncelle, connect);

            komut.Parameters.AddWithValue("@eylemKart", comboBox_kartEylem.Text);
            komut.Parameters.AddWithValue("@kartKodu", comboBox_alinanKartKodu.Text);
            komut.Parameters.AddWithValue("@kartAdet", textBox_kacAdet.Text);
            komut.Parameters.AddWithValue("@kartDurumAciklama", textBox_kartDurum.Text);

            komut.Parameters.AddWithValue("@idd", dataGridView1.Rows[i].Cells[0].Value);

            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıtlar Başarıyla Güncellendi!");
            connect.Close();
            kayitlariGetir();
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
    }
}
