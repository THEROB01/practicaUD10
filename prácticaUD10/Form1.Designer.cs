namespace prácticaUD10
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
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tApellido = new System.Windows.Forms.TextBox();
            this.tTeléfono = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lTeléfono = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(93, 21);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(153, 20);
            this.tNombre.TabIndex = 0;
            // 
            // tApellido
            // 
            this.tApellido.Location = new System.Drawing.Point(384, 21);
            this.tApellido.Name = "tApellido";
            this.tApellido.Size = new System.Drawing.Size(155, 20);
            this.tApellido.TabIndex = 1;
            // 
            // tTeléfono
            // 
            this.tTeléfono.Location = new System.Drawing.Point(666, 21);
            this.tTeléfono.Name = "tTeléfono";
            this.tTeléfono.Size = new System.Drawing.Size(132, 20);
            this.tTeléfono.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(34, 125);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(764, 252);
            this.textBox4.TabIndex = 3;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(31, 25);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 4;
            this.lNombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido";
            // 
            // lTeléfono
            // 
            this.lTeléfono.AutoSize = true;
            this.lTeléfono.Location = new System.Drawing.Point(602, 25);
            this.lTeléfono.Name = "lTeléfono";
            this.lTeléfono.Size = new System.Drawing.Size(49, 13);
            this.lTeléfono.TabIndex = 6;
            this.lTeléfono.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lista socios";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(706, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lTeléfono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.tTeléfono);
            this.Controls.Add(this.tApellido);
            this.Controls.Add(this.tNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tApellido;
        private System.Windows.Forms.TextBox tTeléfono;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lTeléfono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

