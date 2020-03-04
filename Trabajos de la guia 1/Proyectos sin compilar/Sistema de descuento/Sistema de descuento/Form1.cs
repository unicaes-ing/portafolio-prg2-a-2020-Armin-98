using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_descuento
{
    public partial class discount_system : Form
    {
        public discount_system()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(txt_count.Text);
            double precio = Convert.ToDouble(txt_price.Text);
            double sub, tax, total;
            if (rad_0.Checked)
            {
                sub = precio * cantidad;
                tax = sub * 0.00;
                total = sub - tax;
                txt_discount.Text = string.Format("{0:N2}",tax);
                txt_total.Text = string.Format("{0:N2}","$" + total);
            }
            else if (rad_5.Checked)
            {
                sub = precio * cantidad;
                tax = sub * 0.05;
                total = sub - tax;
                txt_discount.Text = string.Format("{0:N2}", tax);
                txt_total.Text = string.Format("{0:N2}", "$" + total);
            }
            else if (rad_10.Checked)
            {
                sub = precio * cantidad;
                tax = sub * 0.10;
                total = sub - tax;
                txt_discount.Text = string.Format("{0:N2}", tax);
                txt_total.Text = string.Format("{0:N2}", "$" + total);
            }
            else if (rad_15.Checked)
            {
                sub = precio * cantidad;
                tax = sub * 0.15;
                total = sub - tax;
                txt_discount.Text = string.Format("{0:N2}", tax);
                txt_total.Text = string.Format("{0:N2}", "$" + total);
            }
            else if (rad_20.Checked)
            {
                sub = precio * cantidad;
                tax = sub * 0.20;
                total = sub - tax;
                txt_discount.Text = string.Format("{0:N2}", tax);
                txt_total.Text = string.Format("{0:N2}", "$" + total);
            }
            else
            {
                MessageBox.Show("Porfavor seleccione uno de los metodos de descuento");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
