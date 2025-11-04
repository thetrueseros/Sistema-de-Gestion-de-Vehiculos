using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestion_de_Vehiculos
{
    public class VehiculoFactory
    {
        public enum TipoVehiculo
        {
            Automovil,
            Motocicleta
        }
        public static Vehiculo CrearVehiculo(string tipo, string marca, string modelo, double precioBase)
        {
            switch (tipo)
            {
                case "Automovil":
                    return new Automovil(marca, modelo, precioBase);
                case "Motocicleta":
                    return new Motocicleta(marca, modelo, precioBase);
                default:
                    try
                    {
                        throw new ArgumentOutOfRangeException("Tipo de vehiculo no válido");
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return null;
                    }
            }
        }
    }
}
