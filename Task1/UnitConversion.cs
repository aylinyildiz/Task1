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
    public partial class UnitConversion : Form
    {
        double Celsius, Fahrenheit, Kelvin, Kilo, Liter, Mililiter, Gram,Centimeter, Kilometer, Meter, Inches, Feet;
        string iOperation;

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = "ML";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = "KM";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = "MK";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = "MF";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = "FI";
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = "SM";
        }

     
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = "LM";
        }

      

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = "GK";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = "KG";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = "K";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            iOperation="FC";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            iOperation="CF";
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            switch (iOperation)
            {
                case "KM":
                    Kilometer = Double.Parse(tbxValue.Text);
                    lblConvert.Text = ((1000 * Kilometer).ToString());
                    break;
                case "MK":
                    Meter = Double.Parse(tbxValue.Text);
                    lblConvert.Text = ((Meter/1000).ToString());
                    break;
                case "MF":
                    Inches = Double.Parse(tbxValue.Text);
                    lblConvert.Text = ((3*Inches).ToString());
                    break;
                case "FI":
                    Feet = Double.Parse(tbxValue.Text);
                    lblConvert.Text = ((Feet*12).ToString());
                    break;
                case "KG":
                    Kilo = Double.Parse(tbxValue.Text);
                    lblConvert.Text = ((1000 * Kilo).ToString());
                    break;
                case "GK":
                    Gram = Double.Parse(tbxValue.Text);
                    lblConvert.Text = ((Gram / 1000).ToString());
                    break;
                case "LM":
                    Liter = Double.Parse(tbxValue.Text);
                    lblConvert.Text = (( 1000*Liter).ToString());
                    break;
                case "ML":
                    Mililiter = Double.Parse(tbxValue.Text);
                    lblConvert.Text = ((Mililiter / 1000).ToString());
                    break;
                case "SM":
                    Centimeter = Double.Parse(tbxValue.Text);
                    lblConvert.Text = ((Centimeter / 100).ToString());
                    break;
                case "CF":
                    Celsius = Double.Parse(tbxValue.Text);
                    lblConvert.Text = ((((Celsius*9)/5)+32).ToString());
                    break;
                case "FC":
                    Fahrenheit = Double.Parse(tbxValue.Text);
                    lblConvert.Text = ((((Fahrenheit-32)*5)/9).ToString());
                    break;
                case "K":
                   Kelvin = Double.Parse(tbxValue.Text);
                   lblConvert.Text = (((((Kelvin * 9) / 5) + 32) + 273.15).ToString());
                    break;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbxValue.Clear();
            lblConvert.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false; 
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
        }

        
        public UnitConversion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTemperature_Click(object sender, EventArgs e)
        {

        }

        private void UnitConversion_Load(object sender, EventArgs e)
        {

        }
    }
}
