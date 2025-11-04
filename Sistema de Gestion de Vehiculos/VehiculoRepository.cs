using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestion_de_Vehiculos
{
    public class VehiculoRepository
    {
        public static VehiculoRepository instancia;
        private List<string> vehiculos = new List<string>();
        private readonly string rutaArchivo = "vehiculos.txt";

        /// <summary>
        /// Constructor privado para implementar el patrón Singleton
        /// </summary>
        private VehiculoRepository()
        {
            if (!File.Exists(rutaArchivo))
            {
                File.Create(rutaArchivo).Close();
            }
            vehiculos = File.ReadAllLines(rutaArchivo).ToList();
        }

        /// <summary>
        /// Instancia singleton de VehiculoRepository
        /// </summary>
        public static VehiculoRepository Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new VehiculoRepository();
                return instancia;
            }
        }

        /// <summary>
        /// Devuelve una copia de la lista de líneas (para mostrar en la UI)
        /// </summary>
        public List<string> ObtenerListaVehiculos()
        {
            // se devuelve una copia para evitar modificaciones directas desde la UI
            return new List<string>(vehiculos);
        }

        /// <summary>
        /// Agrega un vehículo (construye la línea) y la guarda en el fichero en modo append
        /// </summary>
        public void Agregar(Vehiculo veh)
        {
            if (veh == null) return;
            string linea = "Marca: " + veh.marca +
                           ", Modelo: " + veh.modelo +
                           ", Precio final: " + veh.CalcularPrecioFinal(veh.precioBase);
            vehiculos.Add(linea);

            // Guardamos sólo la línea nueva en modo append para no sobrescribir el fichero
            using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
            {
                sw.WriteLine(linea);
            }
        }
    }
}
