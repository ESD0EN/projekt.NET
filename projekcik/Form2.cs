using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekcik
{
    public partial class Form2 : Form
    {
        WordOperation wordOperation;
      
        public Form2()
        {
            InitializeComponent();
            StartGierka();
        }
        private void StartGierka()
        {
            wordOperation = new WordOperation();
            this.haslo.Text = wordOperation.haslo;
            this.wpisywanie.Text = "";
            this.label1.Text = "Pozostałe szanse: " + (wordOperation.errMax - wordOperation.errCount).ToString();
            this.pictureBox1.ImageLocation = "images\\start.png";
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.wynik.Text = "";
            sprawdz.Enabled = true;
            //wpisywanie.Enabled = false;
        }

        private void sprawdz_Click(object sender, EventArgs e)
        {
            string zgadywanie = wpisywanie.Text;
            char zgad = zgadywanie[0];
            wpisywanie.Text = "";

            if (wordOperation.word.Contains(zgad))
            {
                StringBuilder sb = new StringBuilder(haslo.Text);
                for (int i = 0; i < sb.Length; i++)
                {
                    if (zgad == wordOperation.word.ElementAt(i))
                    {
                        sb[i] = zgad;
                        haslo.Text = sb.ToString();
                    }

                }

                if (haslo.Text == wordOperation.word)
                {
                    wordOperation.win = true;
                }
            }
            else
            {
                if (wynik.Text.Contains(zgad))
                {
                    MessageBox.Show("To już było!");
                }
                else
                {
                    wynik.Text += zgad + ", ";
                    wordOperation.errCount++;
                    pictureBox1.ImageLocation = "images\\" + wordOperation.errCount + ".png";
                    this.label1.Text = "Pozostałe szanse: " + (wordOperation.errMax - wordOperation.errCount).ToString();
                }
            }
            if (wordOperation.errMax == wordOperation.errCount)
            {
                MessageBox.Show("Przegrałeś");
                wynik.Text = "Twoje hasło to: " + wordOperation.word;
                wordOperation.game = false;
                sprawdz.Enabled = false;
            }
            if (wordOperation.win == true)
            {
                MessageBox.Show("Wygrałeś");
                pictureBox1.ImageLocation = "images\\wygrana.png";
                wordOperation.game = false;
                sprawdz.Enabled = false;
            }
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            StartGierka();
        }

        private void qbutton_Click(object sender, EventArgs e)
        {
            wpisywanie.Text = "q";
            //qbutton.Enabled = false;
        }

        private void wbutton_Click(object sender, EventArgs e)
        {
            wpisywanie.Text = "w";
            //wbutton.Enabled = false;
        }

        private void ebutton_Click(object sender, EventArgs e)
        {
            wpisywanie.Text = "e";
        }

        private void rbutton_Click(object sender, EventArgs e)
        {
            wpisywanie.Text = "r";
        }

        private void tbutton_Click(object sender, EventArgs e)
        {
            wpisywanie.Text = "t";
        }

        private void ybutton_Click(object sender, EventArgs e)
        {
            wpisywanie.Text = "y";
        }

        private void ubutton_Click(object sender, EventArgs e)
        {
            wpisywanie.Text = "u";
        }

        private void ibutton_Click(object sender, EventArgs e)
        {
            wpisywanie.Text = "i";
        }

        private void obutton_Click(object sender, EventArgs e)
        {
            wpisywanie.Text = "o";
        }

        private void pbutton_Click(object sender, EventArgs e)
        {
            wpisywanie.Text = "p";
        }

        private void abutton_Click(object sender, EventArgs e)
        {
            wpisywanie.Text = "a";
        }

        private void sbutton_Click(object sender, EventArgs e)
        {
            wpisywanie.Text = "s";
        }

        private void dbutton_Click(object sender, EventArgs e)
        {
            wpisywanie.Text = "d";
        }

        private void fbutton_Click(object sender, EventArgs e)
        {
            wpisywanie.Text = "f";
        }

        private void gbutton_Click(object sender, EventArgs e)
        {
            wpisywanie.Text = "g";
        }

        private void hbutton_Click(object sender, EventArgs e)
        {
            wpisywanie.Text = "h";
        }

        private void jbutton_Click(object sender, EventArgs e)
        {
            wpisywanie.Text = "j";
        }

        private void kbutton_Click(object sender, EventArgs e)
        {
            wpisywanie.Text = "k";
        }

        private void lbutton_Click(object sender, EventArgs e)
        {
            wpisywanie.Text = "l";
        }

        private void zbutton_Click(object sender, EventArgs e)
        {
            wpisywanie.Text = "z";
        }

        private void xbutton_Click(object sender, EventArgs e)
        {
            wpisywanie.Text = "x";
        }

        private void cbutton_Click(object sender, EventArgs e)
        {
            wpisywanie.Text = "c";
        }

        private void vbutton_Click(object sender, EventArgs e)
        {
            wpisywanie.Text = "v";
        }

        private void bbutton_Click(object sender, EventArgs e)
        {
            wpisywanie.Text = "b";
        }

        private void nbutton_Click(object sender, EventArgs e)
        {
            wpisywanie.Text = "n";
        }

        private void mbutton_Click(object sender, EventArgs e)
        {
            wpisywanie.Text = "m";
        }
    }
}
