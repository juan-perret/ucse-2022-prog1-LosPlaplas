﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPrincipal
{
    public abstract class Producto
    {
        public enum TiposProducto {
            Hortalizas_y_Verduras, Frutas, Quesos, Lacteos, Carnes, Pescados,
            Panaderia, Bebidas_Alta_en_Azucar, Bebidas_Normal,
            Bebidas_Alcoholicas
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public TiposProducto TipoProducto { get; set; }
        public double PuntoPedido { get; set; }
        public decimal Precio { get; set; }
        public double Cantidad { get; set; }

    }
}
