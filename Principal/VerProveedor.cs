using Logica;
using Modelo.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Principal
{
    public partial class VerProveedor : Form
    {
        private ProveedorController proveedorController;

        public VerProveedor()
        {
            InitializeComponent();
            proveedorController = new ProveedorController();
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            try
            {
                List<ProveedorEntity> listaProveedores = proveedorController.ObtenerProveedores();

                DataTable dt = new DataTable();
                dt.Columns.Add("id_proveedor", typeof(int));
                dt.Columns.Add("nombre", typeof(string));
                dt.Columns.Add("telefono", typeof(string));
                dt.Columns.Add("direccion", typeof(string));
                dt.Columns.Add("fecha_registro", typeof(DateTime));

                foreach (ProveedorEntity proveedor in listaProveedores)
                {
                    dt.Rows.Add(proveedor.Id_proveedor, proveedor.Nombre, proveedor.Telefono, proveedor.Direccion, proveedor.FechaRegistro);
                }

                dgvProveedor.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proveedores: " + ex.Message);
            }
        }
    }
}
