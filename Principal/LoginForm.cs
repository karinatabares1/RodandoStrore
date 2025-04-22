using System;
using System.Windows.Forms;
using Logica;
using Modelo.Entities;

namespace Principal
{
    public partial class LoginForm : Form
    {
        private UsuarioController usuarioController;

        public LoginForm()
        {
            InitializeComponent();
            usuarioController = new UsuarioController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Solo validamos el nombre, ignoramos txtContrasena
            string nombre = txtNombre.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingrese su nombre de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Buscar usuario por nombre
            UsuarioEntity usuario = usuarioController.ValidarCredenciales(nombre);
            if (usuario != null)
            {
                // Guardar en sesión
                Session.UserId = usuario.Id_usuario;
                Session.RoleId = usuario.Id_rol;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
