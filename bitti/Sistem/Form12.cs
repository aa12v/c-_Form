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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }


        static string conString = "Data Source=DESKTOP-6GFGG91\\SQLEXPRESS;Initial Catalog=kontrol;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);

        PrintDialog PRD = new PrintDialog();


        private void Form12_Load(object sender, EventArgs e)
        {

        }

        public void kayitlariGetir()
        {

            string getir = "Select *From disPersonel";

            SqlCommand komut = new SqlCommand(getir, connect);
            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

            connect.Close();

        }

        public void veriSil(int idd)
        {

            string sil = "Delete From disPersonel where idDis = @idd";

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


        int i = 0;

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;

            textBox_isim.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox_soyisim.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        
        }

        private void dIŞPERSONELDURUMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
        }

        private void pERSONELBİLGİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
        }

        private void kARTBİLGİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
        }


        private void button_kaydiBarkodaDonustur_Click_1(object sender, EventArgs e)
        {
            try
            {
                connect.Open();

                // Veritabanına kaydet
                string kayit = "INSERT INTO disPersonel (isimiDis, soyadiDis) VALUES (@isimiDis, @soyadiDis)";
                SqlCommand komut = new SqlCommand(kayit, connect);

                komut.Parameters.AddWithValue("@isimiDis", textBox_isim.Text);
                komut.Parameters.AddWithValue("@soyadiDis", textBox_soyisim.Text);


                komut.ExecuteNonQuery();

                MessageBox.Show("Kayıt Ekleme Başarılı");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }

            kayitlariGetir();
        }

        private void button_kaydiGuncelle_Click_1(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz bir kayıt seçin.");
                return;
            }

            connect.Open();

            string kayitGuncelle = "UPDATE disPersonel SET isimiDis = @isim, soyadiDis = @soyisim WHERE idDis = @idd";
            SqlCommand komut = new SqlCommand(kayitGuncelle, connect);


            komut.Parameters.AddWithValue("@isim", textBox_isim.Text);
            komut.Parameters.AddWithValue("@soyisim", textBox_soyisim.Text);


            komut.Parameters.AddWithValue("@idd", dataGridView1.Rows[i].Cells[0].Value);

            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıtlar Başarıyla Güncellendi!");
            connect.Close();
            kayitlariGetir();
        }

        private void button_kayitlariListele_Click_1(object sender, EventArgs e)
        {
            kayitlariGetir();
        }

        private void button_kaydiSil_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {

                int idd = Convert.ToInt32(drow.Cells[0].Value);
                veriSil(idd);
                kayitlariGetir();

            }
        }

        private void button_personelAra_Click_1(object sender, EventArgs e)
        {
            string ara = "SELECT * FROM disPersonel WHERE isimiDis LIKE '%' + @isim";
            SqlCommand komut = new SqlCommand(ara, connect);

            komut.Parameters.AddWithValue("@isim", textBox_ara.Text);
            // komut.Parameters.AddWithValue("@barcode", textBox_ara.Text);

            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

            connect.Close();
        }
       
        private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;

            textBox_isim.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox_soyisim.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            
        }
    }
}