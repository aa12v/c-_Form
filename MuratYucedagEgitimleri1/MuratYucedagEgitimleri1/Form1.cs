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

namespace MuratYucedagEgitimleri1 {

    public partial class Form1 : Form {

        public Form1() {

            InitializeComponent();
            
            button2.BackgroundImage = button2.BackgroundImage = Image.FromFile("C:\\Users\\provent_yazilim\\Desktop\\ProjeResimler\\kapali.png");

            textBox2.UseSystemPasswordChar = true;

        }

        static string conString = "Data Source = DESKTOP-6GFGG91\\SQLEXPRESS;Initial Catalog=elektronikProje1;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);

        private void Form1_Load(object sender, EventArgs e) {

             this.Size = new System.Drawing.Size(619, 392);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) {

            if (textBox1.Text == "mehmet" && textBox2.Text == "mehmet123") {

                Form23 formMA = new Form23();
                formMA.Show();
                this.Hide();

            /*    Form2 formMA = new Form2();
                  formMA.Show();
                  this.Hide();*/

            } else if (textBox1.Text == "gizem" && textBox2.Text == "gizem123") {

                Form3 formGSKD = new Form3();
                formGSKD.Show();
                this.Hide();

            } else if (textBox1.Text == "hilal" && textBox2.Text == "hilal123") {

                Form4 formHC = new Form4();
                formHC.Show();
                this.Hide();

            } else if (textBox1.Text == "murat" && textBox2.Text == "murat123") {

                Form5 formMU = new Form5();
                formMU.Show();
                this.Hide();

            } else if (textBox1.Text == "ibrahim" && textBox2.Text == "ibrahim123") {

                Form6 formIY = new Form6();
                formIY.Show();
                this.Hide();

            } else if (textBox1.Text == "mucahit" && textBox2.Text == "mucahit123") {

                Form7 formMS = new Form7();
                formMS.Show();
                this.Hide();

            } else if (textBox1.Text == "enes" && textBox2.Text == "enes123") {

                Form8 formEO = new Form8();
                formEO.Show();
                this.Hide();

            } else if (textBox1.Text == "batuhan" && textBox2.Text == "batuhan123") {

                Form9 formMBI = new Form9();
                formMBI.Show();
                this.Hide();

            } else {

                try
                {
                    if (connect.State == ConnectionState.Closed)
                        connect.Open();

                    string kayit = "insert into personelGirisEkrani (personelKullaniciIsim, personekKullaniciParola) values (@personelKullaniciIsim, @personekKullaniciParola)";
                    SqlCommand komut = new SqlCommand(kayit, connect);


                    komut.Parameters.AddWithValue("@personelKullaniciIsim", textBox1.Text);
                    komut.Parameters.AddWithValue("@personekKullaniciParola", textBox2.Text);


                    komut.ExecuteNonQuery();
                    connect.Close();

                    this.Size = new System.Drawing.Size(619, 554);

                    MessageBox.Show("Hatalı Giriş Yapıldı!");
                    textBox1.Clear();
                    textBox2.Clear();
                }

                catch (Exception hata)
                {
                    MessageBox.Show("Hata Meydana Geldi! " + hata.Message);
                }

                





                //---------------



               /* String personelAd = textBox1.Text;
                String personParola = textBox2.Text;

                listBox1.Items.Add("Personel Ad:" + " " + personelAd + "      " + "Personel Parola:" + " " + personParola + "       " + " Giriş Yapılan Tarih:" + "  " + label5.Text + "   ||   " + label3.Text);

                this.Size = new System.Drawing.Size(619, 554);

                MessageBox.Show("Hatalı Giriş Yapıldı!");
                textBox1.Clear();
                textBox2.Clear();*/
               
            }
        }

        int button2_KapaliAcik = 0;

        private void button2_Click(object sender, EventArgs e) {

            if (button2_KapaliAcik == 0) {
                
                button2.BackgroundImage = button2.BackgroundImage = Image.FromFile("C:\\Users\\provent_yazilim\\Desktop\\ProjeResimler\\acik.png");
                button2_KapaliAcik = 1;
                textBox2.UseSystemPasswordChar = false;
 

            } else if (button2_KapaliAcik == 1 ) {

                button2.BackgroundImage = button2.BackgroundImage = Image.FromFile("C:\\Users\\provent_yazilim\\Desktop\\ProjeResimler\\kapali.png");
                button2_KapaliAcik = 0;
                textBox2.UseSystemPasswordChar = true;

            }
        }

        private void timer1_Tick(object sender, EventArgs e) {

            label3.Text = ((DateTime.Now.Day) + "." + (DateTime.Now.Month) + "." + (DateTime.Now.Year)).ToString();
            label5.Text = ((DateTime.Now.Hour) + "." + (DateTime.Now.Minute) + "." + (DateTime.Now.Second)).ToString();

        }
    }
}
