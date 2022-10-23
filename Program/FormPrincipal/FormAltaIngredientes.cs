﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaPrincipal;

namespace FormPrincipal
{
    public partial class FormAltaIngredientes : Form
    {
        private Despensa logica;
        public enum Ingredientes
        {
            Hortalizas_y_Verduras, Frutas, Quesos, Lacteos, Carnes, Pescados,
            Panaderia, Bebidas_Alta_en_Azucar, Bebidas_Normal,
            Bebidas_Alcoholicas
        }
        public FormAltaIngredientes()
        {
            InitializeComponent();
            logica = new Despensa();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormAltaIngredientes_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Enum.TryParse(CmbBoxCategoria.Text, out Ingredientes tipo);
            switch (tipo)
            {   
                case Ingredientes.Carnes:
                    Carne carne = new Carne();
                    carne.Nombre = txtNombre.Text;
                    carne.Precio = decimal.Parse(txtPrecio.Text) ;
                    carne.PuntoPedido = double.Parse(txtStockPedido.Text);
                    carne.Kg = double.Parse(txtCantidad.Text);                  
                    logica.GuardarProducto(carne);
                    break;
                case Ingredientes.Bebidas_Normal:
                    Bebida bebidaN = new Bebida();
                    bebidaN.Nombre = txtNombre.Text;
                    bebidaN.Precio = decimal.Parse(txtPrecio.Text);
                    bebidaN.PuntoPedido = int.Parse(txtStockPedido.Text);
                    bebidaN.CantidadProducto = int.Parse(txtCantidad.Text);
                    bebidaN.TipoBebida = bebidaN.TiposBebidas(0);
                    logica.GuardarProducto(bebidaN);
                    break;
                case Ingredientes.Bebidas_Alta_en_Azucar:
                    Bebida bebidaAA = new Bebida();
                    bebidaAA.Nombre = txtNombre.Text;
                    bebidaAA.Precio = decimal.Parse(txtPrecio.Text);
                    bebidaAA.PuntoPedido = int.Parse(txtStockPedido.Text);
                    bebidaAA.CantidadProducto = int.Parse(txtCantidad.Text);
                    bebidaAA.TipoBebida = bebidaAA.TiposBebidas(1);
                    logica.GuardarProducto(bebidaAA);
                    break;
                case Ingredientes.Bebidas_Alcoholicas:
                    Bebida bebidaA = new Bebida();
                    bebidaA.Nombre = txtNombre.Text;
                    bebidaA.Precio = decimal.Parse(txtPrecio.Text);
                    bebidaA.PuntoPedido = int.Parse(txtStockPedido.Text);
                    bebidaA.CantidadProducto = int.Parse(txtCantidad.Text);
                    bebidaA.TipoBebida = bebidaA.TiposBebidas(2);
                    logica.GuardarProducto(bebidaA);
                    break;
            }
        }
    }
}
