using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversor_de_temperarura
{
    public partial class Temperatura : Form
    {
        public Temperatura()
        {
            InitializeComponent();
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            double temp = Convert.ToDouble(txt_temp.Text);
            double converted = 0;
            if (rdo_celsius.Checked)
            {
                if (rdo_fahrenheit_r.Checked)
                {
                    converted = temp * 1.8 + 32;
                }
                else if (rdo_kelvin_r.Checked)
                {
                    converted = temp + 273.15;
                }

            }

            if (rdo_fahrenheit.Checked)
            {
                if (rdo_celsius_r.Checked)
                {
                    converted = temp - 32 / 1.8;
                }
                else if (rdo_kelvin_r.Checked)
                {
                    converted = temp + 459.67 * 0.55;
                }
            }

            if (rdo_kelvin.Checked)
            {
                if (rdo_fahrenheit_r.Checked)
                {
                    converted = temp * 1.8 - 459.67;
                }
                else if (rdo_celsius_r.Checked)
                {
                    converted = temp - 273.15;
                }
            }
            txt_convert.Text = string.Format("{0:N3}", converted);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

