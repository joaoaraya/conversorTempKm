using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor
{
    public partial class conversor : Form
    {
        public conversor()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void resGraus_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btConvert1_Click(object sender, EventArgs e)
        {
            double valorC = 0, valorF = 0, valorK = 0, visorGraus;
            visorGraus = double.Parse(textboxGraus.Text);
            if (rbC.Checked) //Celsius para...
            {
                valorC = visorGraus;
                valorF = (visorGraus * 9 / 5) + 32;
                valorK = visorGraus + 273.15;
            }
            else if (rbF.Checked) //Fahrenheit para...
            {
                valorC = (visorGraus - 32) * 5 / 9;
                valorF = visorGraus;
                valorK = (visorGraus - 32) *5 / 9 + 273.15;
            }
            else if (rbK.Checked) //Kelvin para...
            {
                valorC = visorGraus - 273.15;
                valorF = (visorGraus - 273.15) * 9 / 5 + 32;
                valorK = visorGraus;
            }
            resC.Text = valorC.ToString("0.0") + " ºC";
            resF.Text = valorF.ToString("0.0") + " ºF";
            resK.Text = valorK.ToString("0.0") + " K";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btM_Click(object sender, EventArgs e)
        {
            double valorMedida = 0, visorMedida;
            visorMedida = double.Parse(textboxMedida.Text);
            if (rbM.Checked) //Metros para Metros
            {
                valorMedida = visorMedida;
            }
            else if (rbCm.Checked) //Centimetros para Metros
            {
                valorMedida = visorMedida / 100;
            }
            else if (rbKm.Checked) //Kilometros para Metros
            {
                valorMedida = visorMedida * 1000;
            }
            resMedida.Text = valorMedida.ToString();
            btM.BackColor = Color.SkyBlue;
            btCm.BackColor = Color.Gainsboro;
            btKm.BackColor = Color.Gainsboro;
        }

        private void btCm_Click(object sender, EventArgs e)
        {
            double valorMedida = 0, visorMedida;
            visorMedida = double.Parse(textboxMedida.Text);
            if (rbM.Checked) //Metros para Cm
            {
                valorMedida = visorMedida * 100;
            }
            else if (rbCm.Checked) //Centimetros para Cm
            {
                valorMedida = visorMedida;
            }
            else if (rbKm.Checked) //Kilometros para Cm
            {
                valorMedida = visorMedida * 100000;
            }
            resMedida.Text = valorMedida.ToString();
            btM.BackColor = Color.Gainsboro;
            btCm.BackColor = Color.SkyBlue;
            btKm.BackColor = Color.Gainsboro;
        }

        private void btKm_Click(object sender, EventArgs e)
        {
            double valorMedida = 0, visorMedida;
            visorMedida = double.Parse(textboxMedida.Text);
            if (rbM.Checked) //Metros para Km
            {
                valorMedida = visorMedida / 1000;
            }
            else if (rbCm.Checked) //Centimetros para Km
            {
                valorMedida = visorMedida / 100000;
            }
            else if (rbKm.Checked) //Kilometros para Km
            {
                valorMedida = visorMedida;
            }
            resMedida.Text = valorMedida.ToString();
            btM.BackColor = Color.Gainsboro;
            btCm.BackColor = Color.Gainsboro;
            btKm.BackColor = Color.SkyBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
