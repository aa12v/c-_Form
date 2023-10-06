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
using System.Data.Sql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Sistem
{
    public partial class Form_KullaniciGiris : Form
    {




        // Bu dictionary kullanıcı rollerini ve ilgili formları eşlemek için kullanılır.
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


        public int GetLoggedInUserId()
        {
            // Kullanıcı oturum açtığında kullanıcı kimliğini döndürün.
            // Bu sadece bir örnektir, gerçek kullanıcı kimliğini nasıl alacağınıza bağlıdır.
            int userId = 1; // Örnek bir kullanıcı kimliği
            return userId;
        }

        public Form_KullaniciGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6GFGG91\\SQLEXPRESS;Initial Catalog=kontrol;Integrated Security=True");

        private void Form_KullaniciGiris_Load(object sender, EventArgs e)
        {

            pictureBox_gizliAcik.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_gizliAcik.Image = Image.FromFile("C:\\Users\\provent_yazilim\\Desktop\\ProjeResimler\\kapali.png");

            textBox_kullaniciParola.UseSystemPasswordChar = true;

        }


        private void button_GirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM kullanici WHERE kullaniciAd = @kullaniciAd AND parola = @parola", baglanti);
                komut.Parameters.AddWithValue("@kullaniciAd", textBox_kullaniciAd.Text);
                komut.Parameters.AddWithValue("@parola", textBox_kullaniciParola.Text);

                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    string kullaniciAd = dr["kullaniciAd"].ToString();
                    string kullaniciRol = dr["rol"].ToString().Trim();
                    int kullaniciId = GetLoggedInUserId(); // Bu, oturum açmış kullanıcının kimliğini alır.

                    if (rollerVeFormlar.ContainsKey(kullaniciRol))
                    {
                        Type formTipi = rollerVeFormlar[kullaniciRol];
                        Form hedefForm = (Form)Activator.CreateInstance(formTipi);

                        // Oluşturduğumuz Form1.FormKullanici örneğini kullanarak kullanıcı bilgilerini taşıyoruz.
                        Form1.FormKullanici kullanici = new Form1.FormKullanici(kullaniciAd, kullaniciRol, kullaniciId);
                        hedefForm.Tag = kullanici; // Form'a kullanıcı bilgilerini ekliyoruz.

                        hedefForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz kullanıcı rolü.");
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya parola yanlış.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı hatası oluştu: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }



        int gizliAcik = 0;



        private void pictureBox_gizliAcik_Click(object sender, EventArgs e)
        {
            if (gizliAcik == 0)
            {
                pictureBox_gizliAcik.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox_gizliAcik.Image = Image.FromFile("C:\\Users\\provent_yazilim\\Desktop\\ProjeResimler\\kapali.png");
                textBox_kullaniciParola.UseSystemPasswordChar = true;
                gizliAcik = 1;

            }
            else if (gizliAcik == 1)
            {
                pictureBox_gizliAcik.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox_gizliAcik.Image = Image.FromFile("C:\\Users\\provent_yazilim\\Desktop\\ProjeResimler\\acik.png");
                textBox_kullaniciParola.UseSystemPasswordChar = false;
                gizliAcik = 0;


            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label_günAyYil.Text = ((DateTime.Now.Day) + "." + (DateTime.Now.Month) + "." + (DateTime.Now.Year)).ToString();
            label_saatDakikaSaniye.Text = ((DateTime.Now.Hour) + "." + (DateTime.Now.Minute) + "." + (DateTime.Now.Second)).ToString();
        }
    }
}