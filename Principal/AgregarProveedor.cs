using Logica;
using Modelo.Entities;
using System;
using System.Windows.Forms;

namespace Principal
{
    public partial class AgregarProveedor : Form
    {
        private ProveedorController proveedorController;

        public AgregarProveedor()
        {
            InitializeComponent();
            proveedorController = new ProveedorController();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los controles
            string nombre = txtNombre.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            DateTime fecha = dtpFecha.Value;  // Suponiendo que tienes un DateTimePicker llamado dtpFecha

            // Validar que el nombre no esté vacío
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear un objeto ProveedorEntity con los datos
            ProveedorEntity proveedor = new ProveedorEntity
            {
                Nombre = nombre,
                Telefono = telefono,
                Direccion = direccion,
                FechaRegistro = fecha
            };

            try
            {
                // Llamar al controlador para agregar el proveedor
                int resultado = proveedorController.AgregarProveedor(nombre, telefono, direccion, fecha);
                if (resultado > 0)
                {
                    MessageBox.Show("Proveedor agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Cierra el formulario tras guardar
                }
                else
                {
                    MessageBox.Show("Error al guardar el proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
