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
using System.Data.Sql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Sistem
{
    public partial class Form_KullaniciGiris : Form
    {
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
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM kullanici WHERE kullaniciAd = @kullaniciAd AND parola = @parola", baglanti);
            komut.Parameters.AddWithValue("@kullaniciAd", textBox_kullaniciAd.Text);
            komut.Parameters.AddWithValue("@parola", textBox_kullaniciParola.Text);

            SqlDataReader dr = komut.ExecuteReader();

            try
            {
                if (dr.Read())
                {
                    string kullaniciRol = dr["rol"].ToString().Trim();

                    switch (kullaniciRol)
                    {
                        case "form2":
                            Form11 form2 = new Form11();
                            form2.Show();
                            this.Hide();
                            break;
                        case "form3":
                            Form3 form3 = new Form3();
                            form3.Show();
                            this.Hide();
                            break;
                        case "form4":
                            Form4 form4 = new Form4();
                            form4.Show();
                            this.Hide();
                            break;
                        case "form5":
                            Form5 form5 = new Form5();
                            form5.Show();
                            this.Hide();
                            break;
                        case "form6":
                            Form6 form6 = new Form6();
                            form6.Show();
                            this.Hide();
                            break;
                        case "form7":
                            Form7 form7 = new Form7();
                            form7.Show();
                            this.Hide();
                            break;
                        case "form8":
                            Form8 form8 = new Form8();
                            form8.Show();
                            this.Hide();
                            break;
                        case "form9":
                            Form9 form9 = new Form9();
                            form9.Show();
                            this.Hide();
                            break;
                        default:
                            MessageBox.Show("Geçersiz kullanıcı rolü.");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya parola yanlış.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        int  gizliAcik = 0;

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
