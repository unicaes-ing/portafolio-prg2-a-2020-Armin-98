using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal num1 = 0;
            decimal num2 = 0;
            decimal num3 = 0;
            decimal suma = 0;
            decimal res = 0;

            num1 = Convert.ToDecimal(per_1.Text);
            num2 = Convert.ToDecimal(per_2.Text);
            num3 = Convert.ToDecimal(per_3.Text);
            suma = num1 + num2 + num3;
            res = suma / 3;
            //else
            //{
              //  res = res / 3;
            //}
            resul.Text = res.ToString();
            //if ()
            //res / 3;

        }
    }
}
