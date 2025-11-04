using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestion_de_Vehiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipo.Text == "(Seleccione)")
                {
                    throw new ArgumentException("No has seleccionado un tipo de vehículo.");
                }
                if (double.TryParse(txtbPrecioBase.Text, out double precioBase) == false)
                {
                    throw new ArgumentException("El campo de precio base debe ser un número válido.");
                }
                if (double.Parse(txtbPrecioBase.Text)<=0)
                {
                    throw new ArgumentOutOfRangeException("El campo de precio base no puede estar vacío.");
                }
                if (string.IsNullOrWhiteSpace(txtbMarca.Text))
                {
                    throw new ArgumentNullException("El campo de marca no puede estar vacío.");
                }
                if (string.IsNullOrWhiteSpace(txtbModelo.Text))
                {
                    throw new ArgumentNullException("El campo de modelo no puede estar vacío.");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Vehiculo vehiculo = VehiculoFactory.CrearVehiculo(cmbTipo.Text, txtbMarca.Text, txtbModelo.Text, double.Parse(txtbPrecioBase.Text));
        }
        private void LimpiarCampos()
        {
            txtbMarca.Clear();
            txtbModelo.Clear();
            txtbPrecioBase.Clear();
            cmbTipo.SelectedIndex = 0;
        }
    }
}
