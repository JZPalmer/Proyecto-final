namespace ProyectoBiblio
{
    partial class FormReserva
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Boton_salir = new System.Windows.Forms.Button();
            this.Boton_Actualizar = new System.Windows.Forms.Button();
            this.Boton_eliminar = new System.Windows.Forms.Button();
            this.Boton_agregar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 36F);
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 94);
            this.label1.TabIndex = 14;
            this.label1.Text = "Reservas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(354, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(343, 336);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(317, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 24);
            this.comboBox1.TabIndex = 24;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(488, 52);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(157, 24);
            this.comboBox2.TabIndex = 25;
            // 
            // Boton_salir
            // 
            this.Boton_salir.Location = new System.Drawing.Point(157, 256);
            this.Boton_salir.Name = "Boton_salir";
            this.Boton_salir.Size = new System.Drawing.Size(109, 78);
            this.Boton_salir.TabIndex = 29;
            this.Boton_salir.Text = "Salir";
            this.Boton_salir.UseVisualStyleBackColor = true;
            this.Boton_salir.Click += new System.EventHandler(this.Boton_salir_Click);
            // 
            // Boton_Actualizar
            // 
            this.Boton_Actualizar.Location = new System.Drawing.Point(24, 256);
            this.Boton_Actualizar.Name = "Boton_Actualizar";
            this.Boton_Actualizar.Size = new System.Drawing.Size(123, 78);
            this.Boton_Actualizar.TabIndex = 28;
            this.Boton_Actualizar.Text = "Actualizar";
            this.Boton_Actualizar.UseVisualStyleBackColor = true;
            this.Boton_Actualizar.Click += new System.EventHandler(this.Boton_Actualizar_Click);
            // 
            // Boton_eliminar
            // 
            this.Boton_eliminar.Location = new System.Drawing.Point(157, 355);
            this.Boton_eliminar.Name = "Boton_eliminar";
            this.Boton_eliminar.Size = new System.Drawing.Size(109, 72);
            this.Boton_eliminar.TabIndex = 27;
            this.Boton_eliminar.Text = "Eliminar";
            this.Boton_eliminar.UseVisualStyleBackColor = true;
            this.Boton_eliminar.Click += new System.EventHandler(this.Boton_eliminar_Click);
            // 
            // Boton_agregar
            // 
            this.Boton_agregar.Location = new System.Drawing.Point(24, 355);
            this.Boton_agregar.Name = "Boton_agregar";
            this.Boton_agregar.Size = new System.Drawing.Size(123, 72);
            this.Boton_agregar.TabIndex = 26;
            this.Boton_agregar.Text = "Agregar";
            this.Boton_agregar.UseVisualStyleBackColor = true;
            this.Boton_agregar.Click += new System.EventHandler(this.Boton_agregar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 201);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(148, 22);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(183, 201);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(157, 22);
            this.dateTimePicker2.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Libro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Fecha de Prestado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Fecha de Devuelta";
            // 
            // FormReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Boton_salir);
            this.Controls.Add(this.Boton_Actualizar);
            this.Controls.Add(this.Boton_eliminar);
            this.Controls.Add(this.Boton_agregar);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormReserva";
            this.Text = "FormReserva";
            this.Load += new System.EventHandler(this.FormReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button Boton_salir;
        private System.Windows.Forms.Button Boton_Actualizar;
        private System.Windows.Forms.Button Boton_eliminar;
        private System.Windows.Forms.Button Boton_agregar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}