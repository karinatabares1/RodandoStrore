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
    public partial class VerUsuarios : Form
    {
        private string connectionString = "server=localhost;database=rodandoStore;user=root;password=;";

        public VerUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT usuario.id_usuario, usuario.nombre, rol.nombre AS rol FROM usuario INNER JOIN rol ON usuario.id_rol = rol.id_rol";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvUsuarios.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los usuarios: " + ex.Message);
                }
            }
        }
    }
}
