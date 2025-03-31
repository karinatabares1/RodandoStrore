using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Principal
{
    public partial class VerProveedor : Form
    {

        private string connectionString = "server=localhost;database=rodandoStore;user=root;password=;";

        public VerProveedor()
        {
            InitializeComponent();
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id_proveedor, nombre, telefono, direccion FROM proveedor";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvProveedor.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los proveedores: " + ex.Message);
                }
            }
        }
    }
}

