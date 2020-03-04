namespace Sistema_de_descuento
{
    partial class discount_system
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(discount_system));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_0 = new System.Windows.Forms.RadioButton();
            this.rad_5 = new System.Windows.Forms.RadioButton();
            this.rad_10 = new System.Windows.Forms.RadioButton();
            this.rad_15 = new System.Windows.Forms.RadioButton();
            this.rad_20 = new System.Windows.Forms.RadioButton();
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txt_count
            // 
            resources.ApplyResources(this.txt_count, "txt_count");
            this.txt_count.Name = "txt_count";
            // 
            // txt_price
            // 
            resources.ApplyResources(this.txt_price, "txt_price");
            this.txt_price.Name = "txt_price";
            // 
            // txt_discount
            // 
            this.txt_discount.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.txt_discount, "txt_discount");
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.ReadOnly = true;
            // 
            // txt_total
            // 
            this.txt_total.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.txt_total, "txt_total");
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            // 
            // btn_calculate
            // 
            resources.ApplyResources(this.btn_calculate, "btn_calculate");
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_20);
            this.groupBox1.Controls.Add(this.rad_15);
            this.groupBox1.Controls.Add(this.rad_10);
            this.groupBox1.Controls.Add(this.rad_5);
            this.groupBox1.Controls.Add(this.rad_0);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // rad_0
            // 
            resources.ApplyResources(this.rad_0, "rad_0");
            this.rad_0.Name = "rad_0";
            this.rad_0.TabStop = true;
            this.rad_0.UseVisualStyleBackColor = true;
            // 
            // rad_5
            // 
            resources.ApplyResources(this.rad_5, "rad_5");
            this.rad_5.Name = "rad_5";
            this.rad_5.TabStop = true;
            this.rad_5.UseVisualStyleBackColor = true;
            // 
            // rad_10
            // 
            resources.ApplyResources(this.rad_10, "rad_10");
            this.rad_10.Name = "rad_10";
            this.rad_10.TabStop = true;
            this.rad_10.UseVisualStyleBackColor = true;
            // 
            // rad_15
            // 
            resources.ApplyResources(this.rad_15, "rad_15");
            this.rad_15.Name = "rad_15";
            this.rad_15.TabStop = true;
            this.rad_15.UseVisualStyleBackColor = true;
            // 
            // rad_20
            // 
            resources.ApplyResources(this.rad_20, "rad_20");
            this.rad_20.Name = "rad_20";
            this.rad_20.TabStop = true;
            this.rad_20.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            resources.ApplyResources(this.btn_exit, "btn_exit");
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // discount_system
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "discount_system";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_20;
        private System.Windows.Forms.RadioButton rad_15;
        private System.Windows.Forms.RadioButton rad_10;
        private System.Windows.Forms.RadioButton rad_5;
        private System.Windows.Forms.RadioButton rad_0;
        private System.Windows.Forms.Button btn_exit;
    }
}

