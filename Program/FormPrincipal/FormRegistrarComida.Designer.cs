﻿namespace FormPrincipal
{
    partial class FormRegistrarComida
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
            this.dgvSeleccionReceta = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtpFechaComida = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblSeleccionaReceta = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.Nombre_Receta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_de_comida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingredientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblFiltroComida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionReceta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSeleccionReceta
            // 
            this.dgvSeleccionReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeleccionReceta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_Receta,
            this.Tipo_de_comida,
            this.Ingredientes});
            this.dgvSeleccionReceta.Location = new System.Drawing.Point(152, 110);
            this.dgvSeleccionReceta.Name = "dgvSeleccionReceta";
            this.dgvSeleccionReceta.Size = new System.Drawing.Size(343, 170);
            this.dgvSeleccionReceta.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(22, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(221, 28);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "REGISTRA TUS COMIDAS";
            // 
            // dtpFechaComida
            // 
            this.dtpFechaComida.Location = new System.Drawing.Point(152, 63);
            this.dtpFechaComida.Name = "dtpFechaComida";
            this.dtpFechaComida.Size = new System.Drawing.Size(185, 20);
            this.dtpFechaComida.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(24, 69);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(105, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Selecciona tu fecha:";
            // 
            // lblSeleccionaReceta
            // 
            this.lblSeleccionaReceta.AutoSize = true;
            this.lblSeleccionaReceta.Location = new System.Drawing.Point(24, 110);
            this.lblSeleccionaReceta.Name = "lblSeleccionaReceta";
            this.lblSeleccionaReceta.Size = new System.Drawing.Size(110, 13);
            this.lblSeleccionaReceta.TabIndex = 4;
            this.lblSeleccionaReceta.Text = "Selecciona la receta: ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 310);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 22);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(463, 310);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // Nombre_Receta
            // 
            this.Nombre_Receta.HeaderText = "Nombre de la Receta";
            this.Nombre_Receta.Name = "Nombre_Receta";
            // 
            // Tipo_de_comida
            // 
            this.Tipo_de_comida.HeaderText = "Tipo de Comida";
            this.Tipo_de_comida.Name = "Tipo_de_comida";
            // 
            // Ingredientes
            // 
            this.Ingredientes.HeaderText = "Ingredientes";
            this.Ingredientes.Name = "Ingredientes";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Desayuno",
            "Almuerzo",
            "Merienda",
            "Cena"});
            this.comboBox1.Location = new System.Drawing.Point(27, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(102, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // lblFiltroComida
            // 
            this.lblFiltroComida.AutoSize = true;
            this.lblFiltroComida.Location = new System.Drawing.Point(27, 145);
            this.lblFiltroComida.Name = "lblFiltroComida";
            this.lblFiltroComida.Size = new System.Drawing.Size(53, 13);
            this.lblFiltroComida.TabIndex = 8;
            this.lblFiltroComida.Text = "Filtrar por:";
            // 
            // FormRegistrarComida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 345);
            this.Controls.Add(this.lblFiltroComida);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblSeleccionaReceta);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFechaComida);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvSeleccionReceta);
            this.Name = "FormRegistrarComida";
            this.Text = "FormRegistrarComida";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionReceta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSeleccionReceta;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DateTimePicker dtpFechaComida;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblSeleccionaReceta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Receta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_de_comida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingredientes;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblFiltroComida;
    }
}