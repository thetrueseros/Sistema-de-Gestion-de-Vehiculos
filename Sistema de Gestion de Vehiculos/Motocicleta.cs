using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestion_de_Vehiculos
{
    public class Motocicleta : Vehiculo
    {
        public Motocicleta(string marca, string modelo, double precioBase) : base(marca, modelo, precioBase)
        {
        }
        public override double CalcularPrecioFinal(double precioBase)
        {
            if (precioBase > 15000000)
            {
                return precioBase + 500000;
            }
            else
            {
                return precioBase;
            }
        }
    }
}
