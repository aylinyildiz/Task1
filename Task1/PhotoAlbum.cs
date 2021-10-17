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
    public partial class PhotoAlbum : Form
    {
        public PhotoAlbum()
        {
            InitializeComponent();
        }
        public static int siraNo = 1;
        private void PhotoAlbum_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\images\\" + 1 + ".jpg");

            // buttons properties
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.Text = "<";
            button1.Font = new Font("Arial", 18, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Width = 40;
            button1.Height = 40;

            button2.FlatStyle = FlatStyle.Flat;
            button2.BackColor = Color.Black;
            button2.FlatAppearance.BorderSize = 0;
            button2.Text = ">";
            button2.Font = new Font("Arial", 18, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Width = 40;
            button2.Height = 40;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\images\\" + 1 + ".jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (siraNo == 5)
            {
                siraNo = 1;
            }
            siraNo += 1;
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\images\\" + siraNo + ".jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            siraNo -= 1;
            if (siraNo == 0)
            {
                siraNo = 5;
            }
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\images\\" + siraNo + ".jpg");
        }
    }
}