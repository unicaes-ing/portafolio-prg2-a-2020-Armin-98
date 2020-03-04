using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_Ventas
{
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            //Variable para la llamada de formulario de ventas
            Form form_store = new unicaes_tech_store();
            Form form_validate = new Store();
            //Variables de los usuarios
            string user0 = Convert.ToString(txt_user.Text);
            string user1 = Convert.ToString(txt_user.Text);
            string user2 = Convert.ToString(txt_user.Text);
            string user3 = Convert.ToString(txt_user.Text);
            string admin = Convert.ToString(txt_user.Text);
            string notuser = Convert.ToString(txt_user.Text);
            //Variables de las contraseñas
            string pass0 = Convert.ToString(txt_password.Text);
            string pass1 = Convert.ToString(txt_password.Text);
            string pass2 = Convert.ToString(txt_password.Text);
            string pass3 = Convert.ToString(txt_password.Text);
            string pass_admin = Convert.ToString(txt_password.Text);
            string notpass = Convert.ToString(txt_password.Text);
            //Funciones de acceso
            if (txt_user.Text == "admin@syscatolica.edu.sv")
            {
                if (txt_password.Text == "armando1998")
                {
                    MessageBox.Show("Acceso concedido al administrador");
                    form_store.Show();
                    form_store.Visible = true;
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Acceso denegado contrasena incorrecta");
                }
            }
            else if (txt_user.Text == "user0@catolica.edu.sv")
            {
                if (txt_password.Text == "user0unicaes")
                {
                    MessageBox.Show("Acceso concedido al usuario 0");
                    form_store.Show();
                    form_store.Visible = true;
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Accseso denegado contrasena incorrecta");
                }
            }
            else if (txt_user.Text == "user1@catolica.edu.sv")
            {
                if (txt_password.Text == "user1unicaes")
                {
                    MessageBox.Show("Acceso concedido al usuario 1");
                    form_store.Show();
                    form_store.Visible = true;
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Accseso denegado contrasena incorrecta");
                }
            }
            else if (txt_user.Text == "user2@catolica.edu.sv")
            {
                if (txt_password.Text == "user2unicaes")
                {
                    MessageBox.Show("Acceso concedido al usuario 2");
                    form_store.Show();
                    form_store.Visible = true;
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Accseso denegado contrasena incorrecta");
                }
            }
            else if (txt_user.Text == "user3@catolica.edu.sv")
            {
                if (txt_password.Text == "user3unicaes")
                {
                    MessageBox.Show("Acceso concedido al usuario 3");
                    form_store.Show();
                    form_store.Visible = true;
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Accseso denegado contrasena incorrecta");
                }
            }
            else if (txt_user.Text == "root@user")
            {
                if (txt_password.Text == "test")
                {
                    MessageBox.Show("Usuaro de prueba");
                    form_store.Show();
                    form_store.Visible = true;
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("contraseña predeterminada para prueba es *test*");
                }
            }
            else
            {
                MessageBox.Show("No es un usuario registrado porfavor contacte al administrador");
            }
            txt_user.Clear();
            txt_password.Clear();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
