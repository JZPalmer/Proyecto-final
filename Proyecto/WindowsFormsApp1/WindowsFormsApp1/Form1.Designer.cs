namespace ProyectoBiblio
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
            this.Boton_1 = new System.Windows.Forms.Button();
            this.Boton_3 = new System.Windows.Forms.Button();
            this.Boton_2 = new System.Windows.Forms.Button();
            this.Boton_4 = new System.Windows.Forms.Button();
            this.Boton_Cierre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrar Biblioteca";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Boton_1
            // 
            this.Boton_1.Location = new System.Drawing.Point(42, 123);
            this.Boton_1.Name = "Boton_1";
            this.Boton_1.Size = new System.Drawing.Size(128, 201);
            this.Boton_1.TabIndex = 1;
            this.Boton_1.Text = "Libros";
            this.Boton_1.UseVisualStyleBackColor = true;
            this.Boton_1.Click += new System.EventHandler(this.Boton_Libros_Click);
            // 
            // Boton_3
            // 
            this.Boton_3.Location = new System.Drawing.Point(333, 123);
            this.Boton_3.Name = "Boton_3";
            this.Boton_3.Size = new System.Drawing.Size(132, 201);
            this.Boton_3.TabIndex = 2;
            this.Boton_3.Text = "Usuario";
            this.Boton_3.UseVisualStyleBackColor = true;
            this.Boton_3.Click += new System.EventHandler(this.Boton_Clientes_Click);
            // 
            // Boton_2
            // 
            this.Boton_2.Location = new System.Drawing.Point(185, 123);
            this.Boton_2.Name = "Boton_2";
            this.Boton_2.Size = new System.Drawing.Size(132, 201);
            this.Boton_2.TabIndex = 3;
            this.Boton_2.Text = "Reserva";
            this.Boton_2.UseVisualStyleBackColor = true;
            this.Boton_2.Click += new System.EventHandler(this.Boton_Reserva_Click);
            // 
            // Boton_4
            // 
            this.Boton_4.Location = new System.Drawing.Point(486, 123);
            this.Boton_4.Name = "Boton_4";
            this.Boton_4.Size = new System.Drawing.Size(123, 201);
            this.Boton_4.TabIndex = 4;
            this.Boton_4.Text = "Consultas y Reportes";
            this.Boton_4.UseVisualStyleBackColor = true;
            this.Boton_4.Click += new System.EventHandler(this.Boton_Consultas_Click);
            // 
            // Boton_Cierre
            // 
            this.Boton_Cierre.Location = new System.Drawing.Point(625, 277);
            this.Boton_Cierre.Name = "Boton_Cierre";
            this.Boton_Cierre.Size = new System.Drawing.Size(120, 47);
            this.Boton_Cierre.TabIndex = 5;
            this.Boton_Cierre.Text = "Cerrar";
            this.Boton_Cierre.UseVisualStyleBackColor = true;
            this.Boton_Cierre.Click += new System.EventHandler(this.Boton_Cierre_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 337);
            this.Controls.Add(this.Boton_Cierre);
            this.Controls.Add(this.Boton_4);
            this.Controls.Add(this.Boton_2);
            this.Controls.Add(this.Boton_3);
            this.Controls.Add(this.Boton_1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Boton_1;
        private System.Windows.Forms.Button Boton_3;
        private System.Windows.Forms.Button Boton_2;
        private System.Windows.Forms.Button Boton_4;
        private System.Windows.Forms.Button Boton_Cierre;
    }
}

