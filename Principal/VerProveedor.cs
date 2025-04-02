using Modelo;
using Modelo.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Principal
{
    public partial class VerProveedor : Form
    {
        public VerProveedor()
        {
            InitializeComponent();
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            try
            {
                BaseDatos bd = new BaseDatos();
                List<ProveedorEntity> listaProveedores = bd.TraerProveedores();

                DataTable dt = new DataTable();
                dt.Columns.Add("id_proveedor", typeof(int));
                dt.Columns.Add("nombre", typeof(string));
                dt.Columns.Add("telefono", typeof(string));
                dt.Columns.Add("direccion", typeof(string));

                foreach (ProveedorEntity proveedor in listaProveedores)
                {
                    dt.Rows.Add(proveedor.Id_proveedor, proveedor.Nombre, proveedor.Telefono, proveedor.Direccion);
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
