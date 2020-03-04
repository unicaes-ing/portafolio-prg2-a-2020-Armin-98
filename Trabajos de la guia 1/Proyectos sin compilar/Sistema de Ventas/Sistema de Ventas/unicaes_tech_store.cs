using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Sistema_de_Ventas
{
    public partial class unicaes_tech_store : Form
    {
        public unicaes_tech_store()
        {
            InitializeComponent();
            this.CenterToScreen();
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void unicaes_tech_store_Load(object sender, EventArgs e)
        {
            //Metodos de pago
            pay_combo.Items.Add("");
            pay_combo.Items.Add("Efectivo");
            pay_combo.Items.Add("Linea de credito");
            pay_combo.Items.Add("Tarjeta de credito o debito");
            pay_combo.Items.Add("Cheque Bancario");
            //Productos
            product_combo.Items.Add("");
            product_combo.Items.Add("Computadora de escritorio (Completa)");
            product_combo.Items.Add("Laptop");
            product_combo.Items.Add("Memoria Ram");
            product_combo.Items.Add("Disco Duro");
            product_combo.Items.Add("Microprosesadores");
            product_combo.Items.Add("Placa Madre");
            product_combo.Items.Add("Tarjetas de video");
            product_combo.Items.Add("Teclado");
            product_combo.Items.Add("Mouse");
            product_combo.Items.Add("Memorias USB");
            product_combo.Items.Add("Pantallas y monitores");
            product_combo.Items.Add("Sistemas Operativos");
            product_combo.Items.Add("Juegos");
            //juegos
            game_combo.Items.Add("");
            game_combo.Items.Add("Call Of Duty: Modern Warfare");
            game_combo.Items.Add("Call Of Duty: Modern Warfare 2");
            game_combo.Items.Add("Call Of Duty: Modern Warfare 3");
            game_combo.Items.Add("Grand Theft Auto IV");
            game_combo.Items.Add("Grand Theft Auto: Episodes From Liberty City");
            game_combo.Items.Add("Grand Theft Auto V");
            game_combo.Items.Add("Assassins Creed IV");
            game_combo.Items.Add("Assassins Creed Unity");
            game_combo.Items.Add("Assassins Creed Syndicate");
            /*game_combo.Items.Add("God Of War 3 Remastered");
            game_combo.Items.Add("God Of War 4");
            game_combo.Items.Add("God Of War: Saga Colection");
            game_combo.Items.Add("Watch Dogs");
            game_combo.Items.Add("Watch Dogs 2");*/
            //Plataforma
            platform_combo.Items.Add("");
            platform_combo.Items.Add("Play Station 3 o 4");
            platform_combo.Items.Add("Xbox 360 o ONE");
            platform_combo.Items.Add("PC(Medio Fisico)");
            platform_combo.Items.Add("PC(Medio Digital por codigo)");
            //Marcas
            brand_combo.Items.Add("");
            brand_combo.Items.Add("Call Of Duty: Modern Warfare");
            brand_combo.Items.Add("Call Of Duty: Modern Warfare 2");
            brand_combo.Items.Add("Call Of Duty: Modern Warfare 3");
            brand_combo.Items.Add("Grand Theft Auto IV");
            brand_combo.Items.Add("Grand Theft Auto: Episodes From Liberty City");
            brand_combo.Items.Add("Grand Theft Auto V");
            brand_combo.Items.Add("Assassins Creed IV");
            brand_combo.Items.Add("Assassins Creed Unity");
            brand_combo.Items.Add("Assassins Creed Syndicate");
            //Modelo


        }
        private void pay_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pay_combo.Text == "Tarjeta de credito o debito")
            {
                label7.Show();
                mask_txt_codecard.Show();
                mask_txt_seccard.Show();
                mask_txt_expire.Show();
            }
            else if (pay_combo.Text == "")
            {
                label7.Hide();
                mask_txt_codecard.Hide();
                mask_txt_seccard.Hide();
                mask_txt_expire.Hide();
            }
            else
            {
                label7.Hide();
                mask_txt_codecard.Hide();
                mask_txt_seccard.Hide();
                mask_txt_expire.Hide();
            }
        }

        private void product_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            double games, pc, laptop, ram, hdd, cpu, board, video, keyboard, mouse, usb, screen, os;
            double total;
            string code_product = Convert.ToString(txt_code.Text);
            games = 0;
            
            string info = Convert.ToString(txt_descripcion.Text);
            if (product_combo.Text == "Juegos")
            {
                Brand.Hide();
                brand_combo.Hide();
                model_label.Hide();
                model_combo.Hide();
                game_title.Show();
                platform.Show();
                game_combo.Show();
                platform_combo.Show();
                if (game_combo.Text == "Call Of Duty: Modern Warfare")
                {
                    if (platform_combo.Text == "Play Station 3 o 4")
                    {
                        games = 40.00;
                        txt_code.Text = string.Format("codmw19853");
                        info = Convert.ToString("version fisico del juego para PS4");
                        /*total = games + sum;*/
                    }
                }
            }
            else if (product_combo.Text == "Computadora de escritorio (Completa)")
            {
                Brand.Show();
                brand_combo.Show();
                model_label.Show();
                model_combo.Show();
                game_title.Hide();
                platform.Hide();
                game_combo.Hide();
                platform_combo.Hide();
            }
            else if (product_combo.Text == "Laptop")
            {
                Brand.Show();
                brand_combo.Show();
                model_label.Show();
                model_combo.Show();
                game_title.Hide();
                platform.Hide();
                game_combo.Hide();
                platform_combo.Hide();
            }
            else if (product_combo.Text == "Memoria Ram")
            {
                Brand.Show();
                brand_combo.Show();
                model_label.Show();
                model_combo.Show();
                game_title.Hide();
                platform.Hide();
                game_combo.Hide();
                platform_combo.Hide();
            }
            else if (product_combo.Text == "Disco Duro")
            {
                Brand.Show();
                brand_combo.Show();
                model_label.Show();
                model_combo.Show();
                game_title.Hide();
                platform.Hide();
                game_combo.Hide();
                platform_combo.Hide();
            }
            else if (product_combo.Text == "Microprocesadores")
            {
                Brand.Show();
                brand_combo.Show();
                model_label.Show();
                model_combo.Show();
                game_title.Hide();
                platform.Hide();
                game_combo.Hide();
                platform_combo.Hide();
            }
            else if (product_combo.Text == "Placa Madre")
            {
                Brand.Show();
                brand_combo.Show();
                model_label.Show();
                model_combo.Show();
                game_title.Hide();
                platform.Hide();
                game_combo.Hide();
                platform_combo.Hide();
            }
            else if (product_combo.Text == "Tarjetas de video")
            {
                Brand.Show();
                brand_combo.Show();
                model_label.Show();
                model_combo.Show();
                game_title.Hide();
                platform.Hide();
                game_combo.Hide();
                platform_combo.Hide();
            }
            else if (product_combo.Text == "Teclado")
            {
                Brand.Show();
                brand_combo.Show();
                model_label.Show();
                model_combo.Show();
                game_title.Hide();
                platform.Hide();
                game_combo.Hide();
                platform_combo.Hide();
            }
            else if (product_combo.Text == "Mouse")
            {
                Brand.Show();
                brand_combo.Show();
                model_label.Show();
                model_combo.Show();
                game_title.Hide();
                platform.Hide();
                game_combo.Hide();
                platform_combo.Hide();
            }
            else if (product_combo.Text == "Memorias USB")
            {
                Brand.Show();
                brand_combo.Show();
                model_label.Show();
                model_combo.Show();
                game_title.Hide();
                platform.Hide();
                game_combo.Hide();
                platform_combo.Hide();
            }
            else if (product_combo.Text == "Pantallas y monitores")
            {
                Brand.Show();
                brand_combo.Show();
                model_label.Show();
                model_combo.Show();
                game_title.Hide();
                platform.Hide();
                game_combo.Hide();
                platform_combo.Hide();
            }
            else if (product_combo.Text == "Sistemas Operativos")
            {
                Brand.Show();
                brand_combo.Show();
                model_label.Show();
                model_combo.Show();
                game_title.Hide();
                platform.Hide();
                game_combo.Hide();
                platform_combo.Hide();
            }
            else if (product_combo.Text == "")
            {
                Brand.Hide();
                brand_combo.Hide();
                model_label.Hide();
                model_combo.Hide();
                game_title.Hide();
                platform.Hide();
                game_combo.Hide();
                platform_combo.Hide();
            }
            else
            {
                game_title.Hide();
                platform.Hide();
                game_combo.Hide();
                platform_combo.Hide();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string games, pc, laptop, ram, hdd, cpu, board, video, keyboard, mouse, usb, screen, os;
            double games2, pc2, laptop2, ram2, hdd2, cpu2, board2, video2, keyboard2, mouse2, usb2, screen2, os2;
            double total;
            string code_product = Convert.ToString(txt_code.Text);
            string info = Convert.ToString(txt_descripcion.Text);
            int sum = Convert.ToInt32(txt_sum.Text);
            games = Convert.ToString(txt_price.Text);
            if (product_combo.Text == "Juegos")
            {
                //Call Of Duty
                if (game_combo.Text == "Call Of Duty: Modern Warfare")
                {
                    if (platform_combo.Text == "Play Station 3 o 4")
                    {
                        games2 = 43.60;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("codmw19853");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Activision en version fisica del juego para Play Station");
                    }
                    else if (platform_combo.Text == "Xbox 360 o ONE")
                    {
                        games2 = 43.60;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("codmw27981");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Activision en version fisica del juego para Xbox");
                    }
                    else if (platform_combo.Text == "PC(Medio Fisico)")
                    {
                        games2 = 43.60;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("codmw39298");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Activision en version fisica del juego para PC");
                    }
                    else if (platform_combo.Text == "PC(Medio Digital por codigo)")
                    {
                        games2 = 43.60;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("codmw47196");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Activision en version digital del juego para PC");
                    }

                }
                if (game_combo.Text == "Call Of Duty: Modern Warfare 2")
                {
                    if (platform_combo.Text == "Play Station 3 o 4")
                    {
                        games2 = 43.60;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("codmw20187");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Activision en version fisica del juego para Play Station");
                    }
                    else if (platform_combo.Text == "Xbox 360 o ONE")
                    {
                        games2 = 43.60;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("codmw27981");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Activision en version fisica del juego para Xbox");
                    }
                    else if (platform_combo.Text == "PC(Medio Fisico)")
                    {
                        games2 = 43.60;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("codmw34881");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Activision en version fisica del juego para PC");
                    }
                    else if (platform_combo.Text == "PC(Medio Digital por codigo)")
                    {
                        games2 = 43.60;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("codmw4761");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Activision en version digital del juego para PC");
                    }

                }
                if (game_combo.Text == "Call Of Duty: Modern Warfare 3")
                {
                    if (platform_combo.Text == "Play Station 3 o 4")
                    {
                        games2 = 43.60;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("codmw19853");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Activision en version fisica del juego para Play Station");
                    }
                    else if (platform_combo.Text == "Xbox 360 o ONE")
                    {
                        games2 = 43.60;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("codmw27981");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Activision en version fisica del juego para Xbox");
                    }
                    else if (platform_combo.Text == "PC(Medio Fisico)")
                    {
                        games2 = 43.60;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("codmw27981");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Activision en version fisica del juego para PC");
                    }
                    else if (platform_combo.Text == "PC(Medio Digital por codigo)")
                    {
                        games2 = 43.60;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("codmw27981");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Activision en version digital del juego para PC");
                    }

                }
                //Grand Theft Auto
                if (game_combo.Text == "Grand Theft Auto IV")
                {
                    if (platform_combo.Text == "Play Station 3 o 4")
                    {
                        games2 = 50.00;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("GTAIV19853");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Rockstar Games en version fisica del juego para Play Station");
                    }
                    else if (platform_combo.Text == "Xbox 360 o ONE")
                    {
                        games2 = 50.00;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("GTAIV27981");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Rockstar Games en version fisica del juego para Xbox");
                    }
                    else if (platform_combo.Text == "PC(Medio Fisico)")
                    {
                        games2 = 50.00;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("GTAIV27981");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Rockstar Games en version fisica del juego para PC");
                    }
                    else if (platform_combo.Text == "PC(Medio Digital por codigo)")
                    {
                        games2 = 50.00;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("GTAIV27981");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Rockstar Games en version digital del juego para PC");
                    }

                }
                if (game_combo.Text == "Grand Theft Auto: Episodes From Liberty City")
                {
                    if (platform_combo.Text == "Play Station 3 o 4")
                    {
                        games2 = 50.00;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("GTAEFLC19853");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Rockstar Games en version fisica del juego para Play Station");
                    }
                    else if (platform_combo.Text == "Xbox 360 o ONE")
                    {
                        games2 = 50.00;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("GTAEFLC27981");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Rockstar Games en version fisica del juego para Xbox");
                    }
                    else if (platform_combo.Text == "PC(Medio Fisico)")
                    {
                        games2 = 50.00;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("GTAEFLC27981");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Rockstar Games en version fisica del juego para PC");
                    }
                    else if (platform_combo.Text == "PC(Medio Digital por codigo)")
                    {
                        games2 = 50.00; ;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("GTAEFLC27981");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Rockstar Games en version digital del juego para PC");
                    }
                }
                if (game_combo.Text == "Grand Theft Auto V")
                {
                    if (platform_combo.Text == "Play Station 3 o 4")
                    {
                        games2 = 75.00;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("GTAV19853");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Rockstar Games en version fisica del juego para Play Station");
                    }
                    else if (platform_combo.Text == "Xbox 360 o ONE")
                    {
                        games2 = 75.00;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("GTAV27981");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Rockstar Games en version fisica del juego para Xbox");
                    }
                    else if (platform_combo.Text == "PC(Medio Fisico)")
                    {
                        games2 = 75.00;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("GTAV27981");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Rockstar Games en version fisica del juego para PC");
                    }
                    else if (platform_combo.Text == "PC(Medio Digital por codigo)")
                    {
                        games2 = 75.00;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("GTAV27981");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Rockstar Games en version digital del juego para PC");
                    }
                }
                //Assassins Creed
                if (game_combo.Text == "Assassins Creed IV")
                {
                    if (platform_combo.Text == "Play Station 3 o 4")
                    {
                        games2 = 75.00;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("ACIV19853");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Ubisoft en version fisica del juego para Play Station");
                    }
                    else if (platform_combo.Text == "Xbox 360 o ONE")
                    {
                        games2 = 75.00;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("ACIV27981");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Ubisoft en version fisica del juego para Xbox");
                    }
                    else if (platform_combo.Text == "PC(Medio Fisico)")
                    {
                        games2 = 75.00;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("ACIV27981");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Ubisoft en version fisica del juego para PC");
                    }
                    else if (platform_combo.Text == "PC(Medio Digital por codigo)")
                    {
                        games2 = 75.00;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("ACIV27981");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Ubisoft en version digital del juego para PC");
                    }
                }
                if (game_combo.Text == "Assassins Creed Unity")
                {
                    if (platform_combo.Text == "Play Station 3 o 4")
                    {
                        games2 = 75.00;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("ACUN19853");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Ubisoft en version fisica del juego para Play Station");
                    }
                    else if (platform_combo.Text == "Xbox 360 o ONE")
                    {
                        games2 = 75.00;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("ACUN27981");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Ubisoft en version fisica del juego para Xbox");
                    }
                    else if (platform_combo.Text == "PC(Medio Fisico)")
                    {
                        games2 = 75.00;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("ACUN27981");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Ubisoft en version fisica del juego para PC");
                    }
                    else if (platform_combo.Text == "PC(Medio Digital por codigo)")
                    {
                        games2 = 75.00;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("ACUN27981");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Ubisoft en version digital del juego para PC");
                    }
                }
                if (game_combo.Text == "Assassins Creed Syndicate")
                {
                    if (platform_combo.Text == "Play Station 3 o 4")
                    {
                        games2 = 75.00;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("ACSY19853");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Ubisoft en version fisica del juego para Play Station");
                    }
                    else if (platform_combo.Text == "Xbox 360 o ONE")
                    {
                        games2 = 75.00;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("ACSY27981");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Ubisoft en version fisica del juego para Xbox");
                    }
                    else if (platform_combo.Text == "PC(Medio Fisico)")
                    {
                        games2 = 75.00;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("ACSY27981");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Ubisoft en version fisica del juego para PC");
                    }
                    else if (platform_combo.Text == "PC(Medio Digital por codigo)")
                    {
                        games2 = 75.00;
                        total = games2 * sum;
                        txt_total.Text = string.Format("{0:N1}", total);
                        txt_price.Text = string.Format("43.60");
                        txt_code.Text = string.Format("ACSY27981");
                        txt_descripcion.Text = string.Format("Juego desarrollado por Ubisoft en version digital del juego para PC");
                    }
                }
            }

            //se agreganlas variables a las celdas de DataGridView
            int n = unicaes_compras.Rows.Add();
            //Se agregan los datos a las celdas correspondientes
            unicaes_compras.Rows[n].Cells[0].Value = txt_code.Text;
            unicaes_compras.Rows[n].Cells[1].Value = game_combo.Text;
            //unicaes_compras.Rows[n].Cells[1].Value = brand_combo.Text;
            unicaes_compras.Rows[n].Cells[2].Value = platform_combo.Text;
            //unicaes_compras.Rows[n].Cells[2].Value = model_combo.Text;
            unicaes_compras.Rows[n].Cells[3].Value = txt_descripcion.Text;
            unicaes_compras.Rows[n].Cells[4].Value = pay_combo.Text;
            unicaes_compras.Rows[n].Cells[5].Value = txt_sum.Text;
            unicaes_compras.Rows[n].Cells[6].Value = txt_price.Text;
            unicaes_compras.Rows[n].Cells[7].Value = txt_total.Text;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            StreamWriter pago = null;
            pago = File.CreateText("Pago.txt");
            string nombre = txt_name.Text;
            string apellido = txt_lastname.Text;
            string sexo = sex_combo.Text;
            string DUI = mask_txt_DUI.Text;
            string NIT = mask_txt_NIT.Text;
            string metodo_pago = pay_combo.Text;
            string tarjeta = mask_txt_codecard.Text;
            string sectarjeta = mask_txt_seccard.Text;
            string fecha = mask_txt_expire.Text;
            pago.Write(nombre);
            pago.Write(apellido);
            pago.Write(sexo);
            pago.Write(DUI);
            pago.Write(NIT);
            pago.Write(metodo_pago);
            pago.Write(tarjeta);
            pago.Write(sectarjeta);
            pago.Write(fecha);
            pago.Flush();
            pago.Close();

        }
    }
}
