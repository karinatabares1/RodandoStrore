using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Principal
{
    public partial class EliminarProveedor : Form
    {
        public EliminarProveedor()
        {
            InitializeComponent();
        }

        private void btnActualizarProveedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Por favor, ingresa un ID de proveedor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idProveedor;
            if (!int.TryParse(txtID.Text, out idProveedor))
            {
                MessageBox.Show("El ID debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este proveedor?",
                                                  "Confirmar Eliminación",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.EliminarProveedor(idProveedor);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Proveedor eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();  // Cerrar formulario después de eliminar
            }
            else
            {
                MessageBox.Show("No se encontró un proveedor con ese ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    

