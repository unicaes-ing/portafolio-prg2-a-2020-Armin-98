namespace conversor_de_temperarura
{
    partial class Temperatura
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_temp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_celsius = new System.Windows.Forms.RadioButton();
            this.rdo_fahrenheit = new System.Windows.Forms.RadioButton();
            this.rdo_kelvin = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdo_kelvin_r = new System.Windows.Forms.RadioButton();
            this.rdo_fahrenheit_r = new System.Windows.Forms.RadioButton();
            this.rdo_celsius_r = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_convert = new System.Windows.Forms.TextBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_temp
            // 
            this.txt_temp.Location = new System.Drawing.Point(141, 10);
            this.txt_temp.Name = "txt_temp";
            this.txt_temp.Size = new System.Drawing.Size(100, 20);
            this.txt_temp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperarura a convertir:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_kelvin);
            this.groupBox1.Controls.Add(this.rdo_fahrenheit);
            this.groupBox1.Controls.Add(this.rdo_celsius);
            this.groupBox1.Location = new System.Drawing.Point(15, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convertir de:";
            // 
            // rdo_celsius
            // 
            this.rdo_celsius.AutoSize = true;
            this.rdo_celsius.Location = new System.Drawing.Point(7, 20);
            this.rdo_celsius.Name = "rdo_celsius";
            this.rdo_celsius.Size = new System.Drawing.Size(58, 17);
            this.rdo_celsius.TabIndex = 0;
            this.rdo_celsius.TabStop = true;
            this.rdo_celsius.Text = "Celsius";
            this.rdo_celsius.UseVisualStyleBackColor = true;
            // 
            // rdo_fahrenheit
            // 
            this.rdo_fahrenheit.AutoSize = true;
            this.rdo_fahrenheit.Location = new System.Drawing.Point(7, 44);
            this.rdo_fahrenheit.Name = "rdo_fahrenheit";
            this.rdo_fahrenheit.Size = new System.Drawing.Size(75, 17);
            this.rdo_fahrenheit.TabIndex = 1;
            this.rdo_fahrenheit.TabStop = true;
            this.rdo_fahrenheit.Text = "Fahrenheit";
            this.rdo_fahrenheit.UseVisualStyleBackColor = true;
            // 
            // rdo_kelvin
            // 
            this.rdo_kelvin.AutoSize = true;
            this.rdo_kelvin.Location = new System.Drawing.Point(7, 68);
            this.rdo_kelvin.Name = "rdo_kelvin";
            this.rdo_kelvin.Size = new System.Drawing.Size(54, 17);
            this.rdo_kelvin.TabIndex = 2;
            this.rdo_kelvin.TabStop = true;
            this.rdo_kelvin.Text = "Kelvin";
            this.rdo_kelvin.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdo_kelvin_r);
            this.groupBox2.Controls.Add(this.rdo_fahrenheit_r);
            this.groupBox2.Controls.Add(this.rdo_celsius_r);
            this.groupBox2.Location = new System.Drawing.Point(141, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Convertir a:";
            // 
            // rdo_kelvin_r
            // 
            this.rdo_kelvin_r.AutoSize = true;
            this.rdo_kelvin_r.Location = new System.Drawing.Point(7, 68);
            this.rdo_kelvin_r.Name = "rdo_kelvin_r";
            this.rdo_kelvin_r.Size = new System.Drawing.Size(54, 17);
            this.rdo_kelvin_r.TabIndex = 2;
            this.rdo_kelvin_r.TabStop = true;
            this.rdo_kelvin_r.Text = "Kelvin";
            this.rdo_kelvin_r.UseVisualStyleBackColor = true;
            // 
            // rdo_fahrenheit_r
            // 
            this.rdo_fahrenheit_r.AutoSize = true;
            this.rdo_fahrenheit_r.Location = new System.Drawing.Point(7, 44);
            this.rdo_fahrenheit_r.Name = "rdo_fahrenheit_r";
            this.rdo_fahrenheit_r.Size = new System.Drawing.Size(75, 17);
            this.rdo_fahrenheit_r.TabIndex = 1;
            this.rdo_fahrenheit_r.TabStop = true;
            this.rdo_fahrenheit_r.Text = "Fahrenheit";
            this.rdo_fahrenheit_r.UseVisualStyleBackColor = true;
            // 
            // rdo_celsius_r
            // 
            this.rdo_celsius_r.AutoSize = true;
            this.rdo_celsius_r.Location = new System.Drawing.Point(7, 20);
            this.rdo_celsius_r.Name = "rdo_celsius_r";
            this.rdo_celsius_r.Size = new System.Drawing.Size(58, 17);
            this.rdo_celsius_r.TabIndex = 0;
            this.rdo_celsius_r.TabStop = true;
            this.rdo_celsius_r.Text = "Celsius";
            this.rdo_celsius_r.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temperatura convertida:";
            // 
            // txt_convert
            // 
            this.txt_convert.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_convert.Location = new System.Drawing.Point(141, 180);
            this.txt_convert.Name = "txt_convert";
            this.txt_convert.ReadOnly = true;
            this.txt_convert.Size = new System.Drawing.Size(100, 20);
            this.txt_convert.TabIndex = 4;
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(22, 212);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(75, 23);
            this.btn_convert.TabIndex = 5;
            this.btn_convert.Text = "Convertir";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(148, 212);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Temperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 245);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.txt_convert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_temp);
            this.Name = "Temperatura";
            this.Text = "Conversor de Temperatura";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_temp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_kelvin;
        private System.Windows.Forms.RadioButton rdo_fahrenheit;
        private System.Windows.Forms.RadioButton rdo_celsius;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdo_kelvin_r;
        private System.Windows.Forms.RadioButton rdo_fahrenheit_r;
        private System.Windows.Forms.RadioButton rdo_celsius_r;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_convert;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Button btn_salir;
    }
}

