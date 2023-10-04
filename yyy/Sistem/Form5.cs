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
    public partial class Form5 : Form
    {

        private Dictionary<string, Type> rollerVeFormlar = new Dictionary<string, Type>
        {
            { "form2", typeof(Form2) },
            { "form3", typeof(Form3) },
            { "form4", typeof(Form4) },
            { "form5", typeof(Form5) },
            { "form6", typeof(Form6) },
            { "form7", typeof(Form7) },
            { "form8", typeof(Form8) },
            { "form9", typeof(Form9) }
        };

        private string kullaniciRol;


        public Form5(string kullaniciRol)
        {
            InitializeComponent();
            this.kullaniciRol = kullaniciRol;
        }

        static string conString = "Data Source=DESKTOP-6GFGG91\\SQLEXPRESS;Initial Catalog=kontrol;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);


        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                connect.Open();

                // Veritabanından verileri çekmek için SQL sorgusu
                string sorgu = "SELECT meslekiKimlik, isim, soyisim, telefonNo, eMailAdres, kullaniciAd FROM kullanici WHERE id = @id";
                SqlCommand komut = new SqlCommand(sorgu, connect);
                komut.Parameters.AddWithValue("@id", 4); // Verileri hangi ID'ye sahip kayıttan çekecekseniz ona göre ayarlayın.

                SqlDataReader reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    // Veritabanından gelen verileri etiketlere atama
                    label_meslekiKimlik.Text = reader["meslekiKimlik"].ToString();
                    label_isim.Text = reader["isim"].ToString();
                    label_soyisim.Text = reader["soyisim"].ToString();
                    label_telefonNo.Text = reader["telefonNo"].ToString();
                    label_eMailAdres.Text = reader["eMailAdres"].ToString();
                    label_kullaniciAd.Text = reader["kullaniciAd"].ToString();
                }

                reader.Close();
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

        private void kARTBİLGİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ortasayfa seçildiğinde Form2'yi açın ve bu formu gizleyin.
            Form11 form11 = new Form11("form5");
            form11.Show();
            this.Hide();
        }

        private void pERSONELBİLGİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ortasayfa seçildiğinde Form2'yi açın ve bu formu gizleyin.
            Form10 form10 = new Form10("form5");
            form10.Show();
            this.Hide();
        }

        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dIŞPERSONELDURUMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ortasayfa seçildiğinde Form2'yi açın ve bu formu gizleyin.
            Form12 form12 = new Form12("form5");
            form12.Show();
            this.Hide();
        }
    }
}
