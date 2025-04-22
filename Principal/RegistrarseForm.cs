using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Principal
{
    public partial class RegistrarseForm : Form
    {
        private UsuarioController usuarioController;
        public RegistrarseForm()
        {
            InitializeComponent(); 
            usuarioController = new UsuarioController();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingrese un nombre de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idRol = 1; // Cliente por defecto

            int resultado = usuarioController.AgregarUsuario(nombre, idRol);

            if (resultado > 0)
            {
                // Guardar en sesión
                Session.UserId = resultado;
                Session.RoleId = idRol;

                MessageBox.Show("Usuario registrado con éxito.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
