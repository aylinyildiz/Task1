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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clock_Click(object sender, EventArgs e)
        {
            Clock clock = new Clock();
            clock.ShowDialog();
        }

        private void countingGame_Click(object sender, EventArgs e)
        {
            CountingGame countingGame = new CountingGame();
            countingGame.ShowDialog();
        }

        private void unitConversion_Click(object sender, EventArgs e)
        {
            UnitConversion unitConversion = new UnitConversion();
            unitConversion.ShowDialog();
        }

        private void photoAlbum_Click(object sender, EventArgs e)
        {
            PhotoAlbum photoAlbum = new PhotoAlbum();
            photoAlbum.ShowDialog();
        }
    }
}


