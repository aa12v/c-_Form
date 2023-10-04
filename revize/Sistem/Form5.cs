﻿using System;
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
        public Form5()
        {
            InitializeComponent();
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
    }
}