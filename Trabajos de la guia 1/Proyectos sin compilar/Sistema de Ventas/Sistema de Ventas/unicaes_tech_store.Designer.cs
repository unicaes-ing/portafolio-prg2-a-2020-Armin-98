namespace Sistema_de_Ventas
{
    partial class unicaes_tech_store
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(unicaes_tech_store));
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.mask_txt_DUI = new System.Windows.Forms.MaskedTextBox();
            this.mask_txt_NIT = new System.Windows.Forms.MaskedTextBox();
            this.sex_combo = new System.Windows.Forms.ComboBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pay_combo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mask_txt_codecard = new System.Windows.Forms.MaskedTextBox();
            this.mask_txt_seccard = new System.Windows.Forms.MaskedTextBox();
            this.mask_txt_expire = new System.Windows.Forms.MaskedTextBox();
            this.unicaes_compras = new System.Windows.Forms.DataGridView();
            this.Code_row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_product_row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model_row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description_row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment_method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant_row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.final_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.product_combo = new System.Windows.Forms.ComboBox();
            this.Brand = new System.Windows.Forms.Label();
            this.brand_combo = new System.Windows.Forms.ComboBox();
            this.model_label = new System.Windows.Forms.Label();
            this.model_combo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.game_title = new System.Windows.Forms.Label();
            this.game_combo = new System.Windows.Forms.ComboBox();
            this.platform_combo = new System.Windows.Forms.ComboBox();
            this.platform = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_sum = new System.Windows.Forms.TextBox();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.unicaes_compras)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(1331, 686);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(1429, 686);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(98, 23);
            this.btn_print.TabIndex = 1;
            this.btn_print.Text = "Imprimir y guardar";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Documeto de identidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numero de Identificacion Tributaria (N.I.T)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sexo";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(28, 63);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(156, 20);
            this.txt_name.TabIndex = 7;
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(28, 127);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(156, 20);
            this.txt_lastname.TabIndex = 8;
            // 
            // mask_txt_DUI
            // 
            this.mask_txt_DUI.Location = new System.Drawing.Point(28, 255);
            this.mask_txt_DUI.Mask = "00000000-0";
            this.mask_txt_DUI.Name = "mask_txt_DUI";
            this.mask_txt_DUI.Size = new System.Drawing.Size(174, 20);
            this.mask_txt_DUI.TabIndex = 9;
            // 
            // mask_txt_NIT
            // 
            this.mask_txt_NIT.Location = new System.Drawing.Point(28, 319);
            this.mask_txt_NIT.Mask = "0000-000000-000-0";
            this.mask_txt_NIT.Name = "mask_txt_NIT";
            this.mask_txt_NIT.Size = new System.Drawing.Size(302, 20);
            this.mask_txt_NIT.TabIndex = 10;
            // 
            // sex_combo
            // 
            this.sex_combo.FormattingEnabled = true;
            this.sex_combo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.sex_combo.Location = new System.Drawing.Point(32, 192);
            this.sex_combo.Name = "sex_combo";
            this.sex_combo.Size = new System.Drawing.Size(121, 21);
            this.sex_combo.TabIndex = 11;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(12, 686);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 12;
            this.btn_exit.Text = "Salir";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pay_combo
            // 
            this.pay_combo.FormattingEnabled = true;
            this.pay_combo.Location = new System.Drawing.Point(401, 59);
            this.pay_combo.Name = "pay_combo";
            this.pay_combo.Size = new System.Drawing.Size(174, 21);
            this.pay_combo.TabIndex = 13;
            this.pay_combo.SelectedIndexChanged += new System.EventHandler(this.pay_combo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(401, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Metodo de pago";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(401, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tarjeta de credito o debito";
            this.label7.Visible = false;
            // 
            // mask_txt_codecard
            // 
            this.mask_txt_codecard.Location = new System.Drawing.Point(401, 127);
            this.mask_txt_codecard.Mask = "0000-0000-0000-0000";
            this.mask_txt_codecard.Name = "mask_txt_codecard";
            this.mask_txt_codecard.Size = new System.Drawing.Size(121, 20);
            this.mask_txt_codecard.TabIndex = 16;
            this.mask_txt_codecard.Visible = false;
            // 
            // mask_txt_seccard
            // 
            this.mask_txt_seccard.Location = new System.Drawing.Point(528, 127);
            this.mask_txt_seccard.Mask = "000";
            this.mask_txt_seccard.Name = "mask_txt_seccard";
            this.mask_txt_seccard.Size = new System.Drawing.Size(29, 20);
            this.mask_txt_seccard.TabIndex = 17;
            this.mask_txt_seccard.Visible = false;
            // 
            // mask_txt_expire
            // 
            this.mask_txt_expire.Location = new System.Drawing.Point(563, 127);
            this.mask_txt_expire.Mask = "00/0000";
            this.mask_txt_expire.Name = "mask_txt_expire";
            this.mask_txt_expire.Size = new System.Drawing.Size(53, 20);
            this.mask_txt_expire.TabIndex = 18;
            this.mask_txt_expire.ValidatingType = typeof(System.DateTime);
            this.mask_txt_expire.Visible = false;
            // 
            // unicaes_compras
            // 
            this.unicaes_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unicaes_compras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code_row,
            this.Name_product_row,
            this.Model_row,
            this.Description_row,
            this.payment_method,
            this.Cant_row,
            this.Price_row,
            this.final_price});
            this.unicaes_compras.Location = new System.Drawing.Point(12, 398);
            this.unicaes_compras.Name = "unicaes_compras";
            this.unicaes_compras.Size = new System.Drawing.Size(1515, 282);
            this.unicaes_compras.TabIndex = 19;
            // 
            // Code_row
            // 
            this.Code_row.HeaderText = "Codigo";
            this.Code_row.Name = "Code_row";
            // 
            // Name_product_row
            // 
            this.Name_product_row.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name_product_row.HeaderText = "Nombre completo";
            this.Name_product_row.Name = "Name_product_row";
            // 
            // Model_row
            // 
            this.Model_row.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Model_row.HeaderText = "Modelo";
            this.Model_row.Name = "Model_row";
            // 
            // Description_row
            // 
            this.Description_row.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description_row.HeaderText = "Descripcion";
            this.Description_row.Name = "Description_row";
            // 
            // payment_method
            // 
            this.payment_method.HeaderText = "Metodo de pago";
            this.payment_method.Name = "payment_method";
            // 
            // Cant_row
            // 
            this.Cant_row.HeaderText = "Cantidad";
            this.Cant_row.Name = "Cant_row";
            // 
            // Price_row
            // 
            this.Price_row.HeaderText = "Precio";
            this.Price_row.Name = "Price_row";
            // 
            // final_price
            // 
            this.final_price.HeaderText = "Total";
            this.final_price.Name = "final_price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(401, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Tipo de producto";
            // 
            // product_combo
            // 
            this.product_combo.FormattingEnabled = true;
            this.product_combo.Location = new System.Drawing.Point(401, 187);
            this.product_combo.Name = "product_combo";
            this.product_combo.Size = new System.Drawing.Size(174, 21);
            this.product_combo.TabIndex = 20;
            this.product_combo.SelectedIndexChanged += new System.EventHandler(this.product_combo_SelectedIndexChanged);
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brand.Location = new System.Drawing.Point(401, 223);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(53, 20);
            this.Brand.TabIndex = 23;
            this.Brand.Text = "Marca";
            this.Brand.Visible = false;
            // 
            // brand_combo
            // 
            this.brand_combo.FormattingEnabled = true;
            this.brand_combo.Location = new System.Drawing.Point(401, 251);
            this.brand_combo.Name = "brand_combo";
            this.brand_combo.Size = new System.Drawing.Size(174, 21);
            this.brand_combo.TabIndex = 22;
            this.brand_combo.Visible = false;
            // 
            // model_label
            // 
            this.model_label.AutoSize = true;
            this.model_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model_label.Location = new System.Drawing.Point(401, 287);
            this.model_label.Name = "model_label";
            this.model_label.Size = new System.Drawing.Size(61, 20);
            this.model_label.TabIndex = 25;
            this.model_label.Text = "Modelo";
            this.model_label.Visible = false;
            // 
            // model_combo
            // 
            this.model_combo.FormattingEnabled = true;
            this.model_combo.Location = new System.Drawing.Point(401, 315);
            this.model_combo.Name = "model_combo";
            this.model_combo.Size = new System.Drawing.Size(174, 21);
            this.model_combo.TabIndex = 24;
            this.model_combo.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 365);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Productos selecccionados";
            // 
            // game_title
            // 
            this.game_title.AutoSize = true;
            this.game_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_title.Location = new System.Drawing.Point(401, 223);
            this.game_title.Name = "game_title";
            this.game_title.Size = new System.Drawing.Size(115, 20);
            this.game_title.TabIndex = 27;
            this.game_title.Text = "Titulo del juego";
            this.game_title.Visible = false;
            // 
            // game_combo
            // 
            this.game_combo.FormattingEnabled = true;
            this.game_combo.Location = new System.Drawing.Point(401, 251);
            this.game_combo.Name = "game_combo";
            this.game_combo.Size = new System.Drawing.Size(174, 21);
            this.game_combo.TabIndex = 28;
            this.game_combo.Visible = false;
            // 
            // platform_combo
            // 
            this.platform_combo.FormattingEnabled = true;
            this.platform_combo.Location = new System.Drawing.Point(401, 315);
            this.platform_combo.Name = "platform_combo";
            this.platform_combo.Size = new System.Drawing.Size(174, 21);
            this.platform_combo.TabIndex = 30;
            this.platform_combo.Visible = false;
            // 
            // platform
            // 
            this.platform.AutoSize = true;
            this.platform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platform.Location = new System.Drawing.Point(401, 287);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(86, 20);
            this.platform.TabIndex = 29;
            this.platform.Text = "Plataforma";
            this.platform.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(635, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Cantidad";
            // 
            // txt_sum
            // 
            this.txt_sum.Location = new System.Drawing.Point(633, 123);
            this.txt_sum.Name = "txt_sum";
            this.txt_sum.Size = new System.Drawing.Size(76, 20);
            this.txt_sum.TabIndex = 32;
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(634, 59);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(76, 20);
            this.txt_code.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(636, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Codigo";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(633, 185);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 35;
            this.btn_add.Text = "Agregar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.BackColor = System.Drawing.Color.White;
            this.txt_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_descripcion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_descripcion.Location = new System.Drawing.Point(102, 708);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(100, 13);
            this.txt_descripcion.TabIndex = 37;
            this.txt_descripcion.Visible = false;
            // 
            // txt_price
            // 
            this.txt_price.BackColor = System.Drawing.Color.White;
            this.txt_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_price.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_price.Location = new System.Drawing.Point(197, 708);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 13);
            this.txt_price.TabIndex = 38;
            this.txt_price.Visible = false;
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.Color.White;
            this.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_total.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_total.Location = new System.Drawing.Point(293, 708);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 13);
            this.txt_total.TabIndex = 39;
            this.txt_total.Visible = false;
            // 
            // unicaes_tech_store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 721);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_sum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.platform_combo);
            this.Controls.Add(this.platform);
            this.Controls.Add(this.game_combo);
            this.Controls.Add(this.game_title);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.model_label);
            this.Controls.Add(this.model_combo);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.brand_combo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.product_combo);
            this.Controls.Add(this.unicaes_compras);
            this.Controls.Add(this.mask_txt_expire);
            this.Controls.Add(this.mask_txt_seccard);
            this.Controls.Add(this.mask_txt_codecard);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pay_combo);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.sex_combo);
            this.Controls.Add(this.mask_txt_NIT);
            this.Controls.Add(this.mask_txt_DUI);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "unicaes_tech_store";
            this.Text = "UNICAES Tech Store";
            this.Load += new System.EventHandler(this.unicaes_tech_store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unicaes_compras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.MaskedTextBox mask_txt_DUI;
        private System.Windows.Forms.MaskedTextBox mask_txt_NIT;
        private System.Windows.Forms.ComboBox sex_combo;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ComboBox pay_combo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mask_txt_codecard;
        private System.Windows.Forms.MaskedTextBox mask_txt_seccard;
        private System.Windows.Forms.MaskedTextBox mask_txt_expire;
        private System.Windows.Forms.DataGridView unicaes_compras;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox product_combo;
        private System.Windows.Forms.Label Brand;
        private System.Windows.Forms.ComboBox brand_combo;
        private System.Windows.Forms.Label model_label;
        private System.Windows.Forms.ComboBox model_combo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label game_title;
        private System.Windows.Forms.ComboBox game_combo;
        private System.Windows.Forms.ComboBox platform_combo;
        private System.Windows.Forms.Label platform;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_sum;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code_row;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_product_row;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model_row;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description_row;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment_method;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant_row;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_row;
        private System.Windows.Forms.DataGridViewTextBoxColumn final_price;
    }
}