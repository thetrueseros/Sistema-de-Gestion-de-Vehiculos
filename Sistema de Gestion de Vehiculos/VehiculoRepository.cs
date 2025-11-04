using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestion_de_Vehiculos
{
    public class VehiculoRepository
    {
        public static VehiculoRepository instancia;
        private List<Vehiculo> vehiculos = new List<Vehiculo>();
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
            ObtenerListaVehiculos();
        }
        /// <summary>
        /// Instancia singleton de VehiculoRepository
        /// </summary>
        public static VehiculoRepository Instancia
        {
            ///crea instancia si no hay
            get
            {
                if (instancia == null)
                {
                    instancia = new VehiculoRepository();
                }
                return instancia;
            }
        }
        /// <summary>
        /// Para obtener la lista de vehículos desde el archivo de texto
        /// </summary>
        /// <returns></returns>
        public List<string> ObtenerListaVehiculos()
        {
            if (File.Exists(rutaArchivo))
            {
                return File.ReadAllLines(rutaArchivo).ToList();
            }
            return new List<string>();
        }
        /// <summary>
        /// Para agregar vehiculos a la lista interna y guardarlos en el archivo de texto
        /// </summary>
        /// <param name="veh"></param>
        public void Agregar(Vehiculo veh)
        {
            vehiculos.Add(veh);
            Guardar();
        }
        /// <summary>
        /// Para guardar los vehiculos de la lista interna al archivo de texto
        /// </summary>
        private void Guardar()
        {
            using (StreamWriter sw = new StreamWriter(rutaArchivo))
            {
                foreach (var veh in vehiculos)
                {
                    sw.WriteLine($"Marca: {veh.marca.ToString()}, Modelo: {veh.modelo.ToString()}, Precio final: {veh.CalcularPrecioFinal(veh.precioBase)}");
                }
            }
        }

    }
}
