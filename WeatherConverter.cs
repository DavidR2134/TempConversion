using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConversion
{
    public partial class WeatherConverter : Form
    {
        public WeatherConverter()
        {
            InitializeComponent();
        }

        private void btn_fahrenheitGo_Click(object sender, EventArgs e)
        {
            convertFromFahrenheit();
        }

        private void btn_celsiusGo_Click(object sender, EventArgs e)
        {
            convertFromCelsius();

        }

        private void btn_kelvinGo_Click(object sender, EventArgs e)
        {
            convertFromKelvin();
        }


        private void convertFromFahrenheit()
        {
            float f = 0;

            //Check for only numbers
            try
            {
                f = float.Parse(txtBox_fahrenheit.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Try only numbers.");
            }

            //Convert from fahrenheit to celsius
            float c = 5f / 9 * (f - 32);
            txtBox_celsius.Text = c.ToString();

            //Convert from fahrenheit to kelvin
            float k = c + 273;
            txtBox_kelvin.Text = k.ToString();
        }

        private void convertFromCelsius()
        {
            float c = 0;

            //Check for only numbers
            try
            {
                c = float.Parse(txtBox_celsius.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Try only numbers.");
            }

            //Convert from celisus to fahrenheit
            float f = 9f / 5 * (c) + 32;
            txtBox_fahrenheit.Text = f.ToString();

            //Convert from celisus to kelvin
            float k = c + 273f;
            txtBox_kelvin.Text = k.ToString();
        }

        private void convertFromKelvin()
        {
            float k = 0;

            //Check for only numbers
            try
            {
                k = float.Parse(txtBox_kelvin.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Try only numbers.");
            }

            //Convert from Kelvin to Fahrenheit
            float f = 9f / 5f * (k - 273f) + 32f;
            txtBox_fahrenheit.Text = f.ToString();

            //Convert from Kelvin to Celisus
            float c = k - 273f;
            txtBox_celsius.Text = c.ToString();
        }


        private void onTextChangeCelsius(object sender, EventArgs e)
        {
            convertFromCelsius();
        }

        private void onTextChangeKelvin(object sender, EventArgs e)
        {
            convertFromKelvin();
        }

        private void onTextChangeFahrenheit(object sender, EventArgs e)
        {
            convertFromFahrenheit();
        }
    }
}
