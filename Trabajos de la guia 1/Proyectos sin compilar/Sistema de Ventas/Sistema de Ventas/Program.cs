using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sistema_de_Ventas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Store store = new Store();
            store.FormClosed += StoreForm_Closed;
            store.Show();
            Application.Run();
        }
        private static void StoreForm_Closed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= StoreForm_Closed;
            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += StoreForm_Closed;
            }
        }
    }
}
