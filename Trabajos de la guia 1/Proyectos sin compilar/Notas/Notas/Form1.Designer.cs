namespace Notas
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.per_1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.per_2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.per_3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.resul = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Esta Aplicacion fue diseñada para calcular \r\nlas notas de cada periodo de una mat" +
    "eria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Por Favor ingrese la nota del primer periodo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // per_1
            // 
            this.per_1.Location = new System.Drawing.Point(16, 62);
            this.per_1.Name = "per_1";
            this.per_1.Size = new System.Drawing.Size(100, 20);
            this.per_1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Por Favor ingrese la nota del segundo periodo";
            // 
            // per_2
            // 
            this.per_2.Location = new System.Drawing.Point(16, 112);
            this.per_2.Name = "per_2";
            this.per_2.Size = new System.Drawing.Size(100, 20);
            this.per_2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Por Favor ingrese la nota del tercer periodo";
            // 
            // per_3
            // 
            this.per_3.Location = new System.Drawing.Point(16, 165);
            this.per_3.Name = "per_3";
            this.per_3.Size = new System.Drawing.Size(100, 20);
            this.per_3.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "La nota final de la materia es:";
            // 
            // resul
            // 
            this.resul.BackColor = System.Drawing.SystemColors.Menu;
            this.resul.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resul.Location = new System.Drawing.Point(163, 205);
            this.resul.Name = "resul";
            this.resul.ReadOnly = true;
            this.resul.Size = new System.Drawing.Size(24, 13);
            this.resul.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ver nota";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resul);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.per_3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.per_2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.per_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Nota Final";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox per_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox per_2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox per_3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox resul;
        private System.Windows.Forms.Button button1;
    }
}

