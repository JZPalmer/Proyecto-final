namespace ProyectoBiblio
{
    partial class FormCliente
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Boton_salir = new System.Windows.Forms.Button();
            this.Boton_Actualizar = new System.Windows.Forms.Button();
            this.Boton_eliminar = new System.Windows.Forms.Button();
            this.Boton_agregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(383, 171);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(141, 22);
            this.textBox5.TabIndex = 23;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(383, 229);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(141, 22);
            this.textBox4.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(543, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 22);
            this.textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(543, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 22);
            this.textBox1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 36F);
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 94);
            this.label1.TabIndex = 14;
            this.label1.Text = "Usuarios";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(343, 336);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Boton_salir
            // 
            this.Boton_salir.Location = new System.Drawing.Point(383, 280);
            this.Boton_salir.Name = "Boton_salir";
            this.Boton_salir.Size = new System.Drawing.Size(123, 81);
            this.Boton_salir.TabIndex = 29;
            this.Boton_salir.Text = "Salir";
            this.Boton_salir.UseVisualStyleBackColor = true;
            this.Boton_salir.Click += new System.EventHandler(this.Boton_salir_Click);
            // 
            // Boton_Actualizar
            // 
            this.Boton_Actualizar.Location = new System.Drawing.Point(512, 280);
            this.Boton_Actualizar.Name = "Boton_Actualizar";
            this.Boton_Actualizar.Size = new System.Drawing.Size(124, 81);
            this.Boton_Actualizar.TabIndex = 28;
            this.Boton_Actualizar.Text = "Actualizar";
            this.Boton_Actualizar.UseVisualStyleBackColor = true;
            this.Boton_Actualizar.Click += new System.EventHandler(this.Boton_Actualizar_Click);
            // 
            // Boton_eliminar
            // 
            this.Boton_eliminar.Location = new System.Drawing.Point(512, 367);
            this.Boton_eliminar.Name = "Boton_eliminar";
            this.Boton_eliminar.Size = new System.Drawing.Size(124, 71);
            this.Boton_eliminar.TabIndex = 27;
            this.Boton_eliminar.Text = "Eliminar";
            this.Boton_eliminar.UseVisualStyleBackColor = true;
            this.Boton_eliminar.Click += new System.EventHandler(this.Boton_eliminar_Click);
            // 
            // Boton_agregar
            // 
            this.Boton_agregar.Location = new System.Drawing.Point(383, 367);
            this.Boton_agregar.Name = "Boton_agregar";
            this.Boton_agregar.Size = new System.Drawing.Size(124, 71);
            this.Boton_agregar.TabIndex = 26;
            this.Boton_agregar.Text = "Agregar";
            this.Boton_agregar.UseVisualStyleBackColor = true;
            this.Boton_agregar.Click += new System.EventHandler(this.Boton_agregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Telefono";
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Boton_salir);
            this.Controls.Add(this.Boton_Actualizar);
            this.Controls.Add(this.Boton_eliminar);
            this.Controls.Add(this.Boton_agregar);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Boton_salir;
        private System.Windows.Forms.Button Boton_Actualizar;
        private System.Windows.Forms.Button Boton_eliminar;
        private System.Windows.Forms.Button Boton_agregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}