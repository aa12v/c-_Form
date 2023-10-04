using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using ZXing;
using ZXing.Aztec;
using ZXing.Common;
using System.Drawing.Printing;

namespace Sistem
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        static string conString = "Data Source=DESKTOP-6GFGG91\\SQLEXPRESS;Initial Catalog=kontrol;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);

        PrintDialog PRD = new PrintDialog();

        private void Form10_Load(object sender, EventArgs e)
        {

         //   label_barcodeCode.Visible = false;
          //  textBox_barcode.Visible = false;

        }

        public void kayitlariGetir()
        {

            string getir = "Select *From kullanici";

            SqlCommand komut = new SqlCommand(getir, connect);
            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

            connect.Close();

        }

        public void veriSil(int idd)
        {

            string sil = "Delete From kullanici where id = @idd";

            SqlCommand komut = new SqlCommand(sil, connect);
            connect.Open();
            komut.Parameters.AddWithValue("@idd", idd);
            komut.ExecuteNonQuery();
            connect.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_günAyYil.Text = ((DateTime.Now.Day) + "." + (DateTime.Now.Month) + "." + (DateTime.Now.Year)).ToString();
            label_saatDakikaSaniye.Text = ((DateTime.Now.Hour) + "." + (DateTime.Now.Minute) + "." + (DateTime.Now.Second)).ToString();
        }

        private void button_kayitlariListele_Click(object sender, EventArgs e)
        {
            kayitlariGetir();
        }

        private void button_personelAra_Click(object sender, EventArgs e)
        {
            string ara = "SELECT * FROM kullanici WHERE isim LIKE '%' + @isim";
            SqlCommand komut = new SqlCommand(ara, connect);

            komut.Parameters.AddWithValue("@isim", textBox_ara.Text);
           // komut.Parameters.AddWithValue("@barcode", textBox_ara.Text);

            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

            connect.Close();
        }



        private void button_kaydet_Click(object sender, EventArgs e)
        {

        }


        private void button_kaydiBarkodaDonustur_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();

                // Veritabanına kaydet
                string kayit = "INSERT INTO kullanici (meslekiKimlik, isim, soyisim, telefonNo, eMailAdres, kullaniciAd, parola, rol) VALUES (@meslekiKimlik, @isim, @soyisim, @telefonNo, @eMailAdres, @kullaniciAd, @parola, @rol)";
                SqlCommand komut = new SqlCommand(kayit, connect);
                komut.Parameters.AddWithValue("@meslekiKimlik", textBox_meslekiKimlik.Text);
                komut.Parameters.AddWithValue("@isim", textBox_isim.Text); // Buradaki Text özelliğini eklemeyi unutmuşsunuz.
                komut.Parameters.AddWithValue("@soyisim", textBox_soyisim.Text); // Buradaki Text özelliğini eklemeyi unutmuşsunuz.
                komut.Parameters.AddWithValue("@telefonNo", textBox_telefonNo.Text);
                komut.Parameters.AddWithValue("@eMailAdres", textBox_eMailAdres.Text);
                komut.Parameters.AddWithValue("@kullaniciAd", textBox_kullaniciAd.Text);
                komut.Parameters.AddWithValue("@parola", textBox_parola.Text);
                komut.Parameters.AddWithValue("@rol", textBox_rol.Text);
             //   komut.Parameters.AddWithValue("@barcode", textBox_barcode.Text);
                komut.ExecuteNonQuery();

                MessageBox.Show("Kayıt Ekleme Başarılı");

             //   label_barcodeCode.Visible = true;
               // textBox_barcode.Visible = true;
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



        private bool IsTurkishCharacter(char character)
        {
            char[] turkishCharacters = { 'ç', 'ş', 'ı', 'İ', 'ğ', 'ö', 'ü', 'Ç', 'Ş', 'Ğ', 'Ö', 'Ü' };

            // Karakter Türkçe karakterlerden biri ise true döndür
            return turkishCharacters.Contains(character);
        }

        private void textBox_isim_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_isim.Text))
            {
                if (char.IsLetter(textBox_isim.Text[0]) && IsTurkishCharacter(textBox_isim.Text[0]))
                {
                    MessageBox.Show("İsim Türkçe karakter ile başlayamaz.");
                    textBox_isim.Text = string.Empty;
                }
            }
        }

        private void textBox_soyisim_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_soyisim.Text))
            {
                if (char.IsLetter(textBox_soyisim.Text[0]) && IsTurkishCharacter(textBox_soyisim.Text[0]))
                {
                    MessageBox.Show("Soyisim Türkçe karakter ile başlayamaz.");
                    textBox_soyisim.Text = string.Empty;
                }
            }
        }


        private void textBox_olusturulacakBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_barcode_Click(object sender, EventArgs e)
        {

        }

        public void button_kaydiSil_Click (object sender, EventArgs e)
        {
            foreach(DataGridViewRow drow in dataGridView1.SelectedRows) {

                int idd = Convert.ToInt32(drow.Cells[0].Value);
                veriSil(idd);
                kayitlariGetir();
                     
            }
            
            
        }

        int i = 0;

        private void button_kaydiGuncelle_Click(object sender, EventArgs e)
        {
            connect.Open();

            string kayitGuncelle = "UPDATE kullanici SET meslekiKimlik = @meslekiKimlik, isim = @isim, soyisim = @soyisim, telefonNo = @telefonNo, eMailAdres = @eMailAdres, kullaniciAd = @kullaniciAd, parola = @parola, rol = @rol WHERE id = @idd";
            SqlCommand komut = new SqlCommand(kayitGuncelle, connect);

            komut.Parameters.AddWithValue("@meslekiKimlik", textBox_meslekiKimlik.Text);
            komut.Parameters.AddWithValue("@isim", textBox_isim.Text);
            komut.Parameters.AddWithValue("@soyisim", textBox_soyisim.Text);
            komut.Parameters.AddWithValue("@telefonNo", textBox_telefonNo.Text);
            komut.Parameters.AddWithValue("@eMailAdres", textBox_eMailAdres.Text);
            komut.Parameters.AddWithValue("@kullaniciAd", textBox_kullaniciAd.Text);
            komut.Parameters.AddWithValue("@parola", textBox_parola.Text);
            komut.Parameters.AddWithValue("@rol", textBox_rol.Text);
            komut.Parameters.AddWithValue("@idd", dataGridView1.Rows[i].Cells[0].Value);

            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıtlar Başarıyla Güncellendi!");
            connect.Close();
            kayitlariGetir();
        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;

            textBox_meslekiKimlik.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox_isim.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox_soyisim.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBox_telefonNo.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            textBox_eMailAdres.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            textBox_kullaniciAd.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            textBox_parola.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            textBox_rol.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
        }

        private void dURUMBİLGİToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kARTBİLGİToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dIŞPERSONELDURUMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pERSONELBİLGİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        /* private void button_BarcodeBastir_Click(object sender, EventArgs e)
         {
             PrintDocument kagit = new PrintDocument();
             DialogResult yazdirmaIslemi;
             yazdirmaIslemi = PRD.ShowDialog();
             kagit.PrintPage += Kagit_PrintPage;

             if (yazdirmaIslemi == DialogResult.OK)
             {
                 kagit.Print();
             }

         }*/

        /* private void Kagit_PrintPage(object sender, PrintPageEventArgs e)
         {
             string neYazilacak = textBox_olusturulacakBarcode.Text;
             Font yaziTipi = new Font("IDAHC39M Code 39 Barcode", 11);
             SolidBrush kalem = new SolidBrush(Color.DarkRed);
             e.Graphics.DrawString(neYazilacak, yaziTipi, kalem, 43, 60);

         }*/
    }
}
