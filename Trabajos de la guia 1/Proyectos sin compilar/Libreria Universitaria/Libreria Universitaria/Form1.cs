using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Libreria_Universitaria
{
    public partial class Libreria_Universitaria : Form
    {
        public Libreria_Universitaria()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Libreria_Universitaria_Load(object sender, EventArgs e)
        {
            cob_books.Items.Add("Antropologia una guia para la existencia (Juan Manuel Burgos)");
            cob_books.Items.Add("Filosofia para jovenes");
            cob_books.Items.Add("Analisis de estados financieros");
            cob_books.Items.Add("Programacion orientada a objetos");
            cob_books.Items.Add("Curso de programacion en visual basic y C# vol 1");
            cob_books.Items.Add("Curso de programacion en visual basic y C# vol 2");
            cob_books.Items.Add("Curso de programacion en visual basic y C# vol 3");
            cob_books.Items.Add("Curso de programacion en visual basic y C# vol 4");
            cob_books.Items.Add("Curso de programacion en visual basic y C# vol 5");
            cob_books.Items.Add("Uso y comprencion del uso de bases de datos");
            cob_books.Items.Add("Python al descubierto");
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            string books = Convert.ToString(cob_books.Text);
            double price = 0, sub = 0, tax = 0, total = 0;
            double cant = Convert.ToDouble(txt_count.Text);
            if (cob_books.Text == "Antropologia una guia para la existencia (Juan Manuel Burgos)")
            {
                price = 20.00;
                sub = price * cant;
                tax = sub * 0.13;
                total = sub + tax;
                txt_price.Text = string.Format("{0:N2}", price);
                txt_subtotal.Text = string.Format("{0:N2}", sub);
                txt_tax.Text = string.Format("{0:N2}", tax);
                txt_pay.Text = string.Format("{0:N2}", total);
            }
            else if (cob_books.Text == "Filosofia para jovenes")
            {
                price = 15.00;
                price = price * cant;
                tax = sub * 0.13;
                total = sub + tax;
                txt_price.Text = string.Format("{0:N2}", price);
                txt_subtotal.Text = string.Format("{0:N2}", sub);
                txt_tax.Text = string.Format("{0:N2}", tax);
                txt_pay.Text = string.Format("{0:N2}", total);
            }
            else if (cob_books.Text == "Analisis de estados financieros")
            {
                price = 25.00;
                sub = price * cant;
                tax = sub * 0.13;
                total = sub + tax;
                txt_price.Text = string.Format("{0:N2}", price);
                txt_subtotal.Text = string.Format("{0:N2}", sub);
                txt_tax.Text = string.Format("{0:N2}", tax);
                txt_pay.Text = string.Format("{0:N2}", total);
            }
            else if (cob_books.Text == "Programacion orientada a objetos")
            {
                price = 18.00;
                sub = price * cant;
                tax = sub * 0.13;
                total = sub + tax;
                txt_price.Text = string.Format("{0:N2}", price);
                txt_subtotal.Text = string.Format("{0:N2}", sub);
                txt_tax.Text = string.Format("{0:N2}", tax);
                txt_pay.Text = string.Format("{0:N2}", total);
            }
            else if (cob_books.Text == "Curso de programacion en visual basic y C# vol 1")
            {
                price = 34.00;
                sub = price * cant;
                tax = sub * 0.13;
                total = sub + tax;
                txt_price.Text = string.Format("{0:N2}", price);
                txt_subtotal.Text = string.Format("{0:N2}", sub);
                txt_tax.Text = string.Format("{0:N2}", tax);
                txt_pay.Text = string.Format("{0:N2}", total);
            }
            else if (cob_books.Text == "Curso de programacion en visual basic y C# vol 2")
            {
                price = 45.00;
                sub = price * cant;
                tax = sub * 0.13;
                total = sub + tax;
                txt_price.Text = string.Format("{0:N2}", price);
                txt_subtotal.Text = string.Format("{0:N2}", sub);
                txt_tax.Text = string.Format("{0:N2}", tax);
                txt_pay.Text = string.Format("{0:N2}", total);
            }
            else if (cob_books.Text == "Curso de programacion en visual basic y C# vol 3")
            {
                price = 60.00;
                sub = price * cant;
                tax = sub * 0.13;
                total = sub + tax;
                txt_price.Text = string.Format("{0:N2}", price);
                txt_subtotal.Text = string.Format("{0:N2}", sub);
                txt_tax.Text = string.Format("{0:N2}", tax);
                txt_pay.Text = string.Format("{0:N2}", total);
            }
            else if (cob_books.Text == "Curso de programacion en visual basic y C# vol 4")
            {
                price = 64.00;
                sub = price * cant;
                tax = sub * 0.13;
                total = sub + tax;
                txt_price.Text = string.Format("{0:N2}", price);
                txt_subtotal.Text = string.Format("{0:N2}", sub);
                txt_tax.Text = string.Format("{0:N2}", tax);
                txt_pay.Text = string.Format("{0:N2}", total);
            }
            else if (cob_books.Text == "Curso de programacion en visual basic y C# vol 5")
            {
                price = 30.00;
                sub = price * cant;
                tax = sub * 0.13;
                total = sub + tax;
                txt_price.Text = string.Format("{0:N2}", price);
                txt_subtotal.Text = string.Format("{0:N2}", sub);
                txt_tax.Text = string.Format("{0:N2}", tax);
                txt_pay.Text = string.Format("{0:N2}", total);
            }
            else if (cob_books.Text == "Uso y comprencion del uso de bases de datos")
            {
                price = 90.00;
                sub = price * cant;
                tax = sub * 0.13;
                total = sub + tax;
                txt_price.Text = string.Format("{0:N2}", price);
                txt_subtotal.Text = string.Format("{0:N2}", sub);
                txt_tax.Text = string.Format("{0:N2}", tax);
                txt_pay.Text = string.Format("{0:N2}", total);
            }
            else if (cob_books.Text == "Python al descubierto")
            {
                price = 50.00;
                sub = price * cant;
                tax = sub * 0.13;
                total = sub + tax;
                txt_price.Text = string.Format("{0:N2}", price);
                txt_subtotal.Text = string.Format("{0:N2}", sub);
                txt_tax.Text = string.Format("{0:N2}", tax);
                txt_pay.Text = string.Format("{0:N2}", total);
            }
            /*else if(txt_count.Text==null)
            {
                MessageBox.Show("Porfavor ingrese valores que se le piden ;)");
            }*/

        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            txt_price.Clear();
            cob_books.ResetText();
            txt_subtotal.Clear();
            txt_tax.Clear();
            txt_pay.Clear();
            txt_count.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
