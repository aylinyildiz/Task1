using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Clock : Form
    {
        public Clock()
        {
            InitializeComponent();
        }

        private void Clock_Load(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            lblTime.Text = time.ToString();
            lblDay.Text = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[(int)time.DayOfWeek];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
