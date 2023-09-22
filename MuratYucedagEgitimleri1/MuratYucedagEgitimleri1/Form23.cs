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

namespace MuratYucedagEgitimleri1
{
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        static string conString = "Data Source = DESKTOP-6GFGG91\\SQLEXPRESS;Initial Catalog=elektronikProje1;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string kayit = "insert into personelBilgi (meslekiKimlik, isim, soyisim, telefonNo, eMailAdres) values (@meslekiKimlik, @isim, @soyisim, @telefonNo, @eMailAdres)";
                SqlCommand komut = new SqlCommand(kayit, connect);

                komut.Parameters.AddWithValue("@meslekiKimlik", textBox1.Text);
                komut.Parameters.AddWithValue("@isim", textBox2.Text);
                komut.Parameters.AddWithValue("@soyisim", textBox3.Text);
                komut.Parameters.AddWithValue("@telefonNo", textBox4.Text);
                komut.Parameters.AddWithValue("@eMailAdres", textBox5.Text);

                komut.ExecuteNonQuery();
                connect.Close();

                MessageBox.Show("Kayıt Ekleme Başarılı");
            }

            catch (Exception hata)
            {
                MessageBox.Show("Hata Meydana Geldi! " + hata.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
