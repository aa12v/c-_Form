using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuratYucedagEgitimleri1 {

    public partial class Form22 : Form {

        public Form22() {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e) {

             Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
             pictureBox1.Image = barcode.Draw(textBox2.Text,60);

            string yil = DateTime.Now.Year.ToString();
            string ay = DateTime.Now.Month.ToString();
            string gun = DateTime.Now.Day.ToString();
            string saat = DateTime.Now.Hour.ToString();
            string dakika = DateTime.Now.Minute.ToString();

            if (yil.Length >= 4) {

                string sonIkiKarakter = yil.Substring(yil.Length - 2); 

                if (ay.Length != 2) {

                    ay = 0 + ay;
                }

                if (gun.Length != 2) {

                    gun = 0 + gun;

                }

                if (saat.Length != 2) {

                    saat = 0 + saat;

                }

                if (dakika.Length != 2) {

                    dakika = 0 + dakika;

                }

                label5.Text = gun + ay;

            }
        }

        private void timer1_Tick(object sender, EventArgs e) {

            label6.Text = ((DateTime.Now.Day) + "." + (DateTime.Now.Month) + "." + (DateTime.Now.Year)).ToString();
            label7.Text = ((DateTime.Now.Hour) + "." + (DateTime.Now.Minute) + "." + (DateTime.Now.Second)).ToString();
        
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
