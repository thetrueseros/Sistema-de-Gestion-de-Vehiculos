using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestion_de_Vehiculos
{
    public abstract class Vehiculo
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public double precioBase { get; set; }
        private double precioFinal { get; set; }
        public Vehiculo(string marca, string modelo,  double precioBase)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.precioBase = precioBase;
        }
        public abstract double CalcularPrecioFinal(double precioBase);
    }
}
