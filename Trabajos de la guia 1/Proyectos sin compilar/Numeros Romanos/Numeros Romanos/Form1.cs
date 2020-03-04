using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Numeros_Romanos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txt_number.Text);
            switch (num)
            {
                case 1:
                    lab_converted.Text = string.Format("Es I");
                    break;
                case 2:
                    lab_converted.Text = string.Format("Es II");
                    break;
                case 3:
                    lab_converted.Text = string.Format("Es III");
                    break;
                case 4:
                    lab_converted.Text = string.Format("Es IV");
                    break;
                case 5:
                    lab_converted.Text = string.Format("Es V");
                    break;
                case 6:
                    lab_converted.Text = string.Format("Es VI");
                    break;
                case 7:
                    lab_converted.Text = string.Format("Es VII");
                    break;
                case 8:
                    lab_converted.Text = string.Format("Es VIII");
                    break;
                case 9:
                    lab_converted.Text = string.Format("Es IX");
                    break;
                case 10:
                    lab_converted.Text = string.Format("Es X");
                    break;
                default:
                    lab_converted.Text = string.Format("Ha salido fuera del rango de numeros");
                    break;
            }
            txt_number.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
