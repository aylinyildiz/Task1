using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class CountingGame : Form
    {
        public CountingGame()
        {
            InitializeComponent();
        }

        private void CountingGame_Load(object sender, EventArgs e)
        {
          
        }


        public int textboxKontrol()
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbxNumber.Text, "[^0-9]"))
            {
                tbxNumber.Text = tbxNumber.Text.Remove(tbxNumber.Text.Length - 1);
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public int randomSayi()
        {
            Random random = new Random();
            int sayi = random.Next(1, 11);
            return sayi;
        }

        private void btnPrediction_Click(object sender, EventArgs e)
        {
            string text = tbxNumber.Text;

            if (tbxNumber.Text.Length == 0)
            {
                MessageBox.Show("Tahmin boş bırakılamaz...");
            }

            else
            {

                if (textboxKontrol() == 0)
                {
                    MessageBox.Show("Lütfen uygun değer giriniz...");
                }

                else
                {
                    int tahmin = Convert.ToInt32(text);
                    if (tahmin < 1 || tahmin > 10)
                    {
                        MessageBox.Show("Lütfen uygun değer giriniz...");
                    }
                    else
                    {
                        int sonuc = randomSayi();
                        string sonucText = sonuc.ToString();
                        if (sonuc == tahmin)
                        {
                            MessageBox.Show("Tebrikler, doğru tahmin...");
                            lblGuess.Text = "Tahmininiz: " + tahmin;
                            lblAnswer.Text = "Sonuç: " + sonuc;
                            tbxNumber.Clear();
                        }

                        else
                        {
                            MessageBox.Show("Tahmin doğru değil...");
                            lblGuess.Text = "Tahmininiz: " + tahmin;
                            lblAnswer.Text = "Sonuç: " + sonuc;
                            tbxNumber.Clear();

                        }


                    }

                }
            }
        }
    }
}


