using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestion_de_Vehiculos
{
    public class Automovil : Vehiculo
    {
        public Automovil(string marca, string modelo, double precioBase) : base(marca, modelo, precioBase)
        {
        }
        public override double CalcularPrecioFinal(double precioBase)
        {
            if (precioBase > 50000000)
            {
                return precioBase * 1.1;
            }
            return 0;
        }
    }
}
