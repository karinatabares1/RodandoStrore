using System;
using System.Windows.Forms;

namespace Principal
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            // Configura el menú de acuerdo al rol del usuario
            ConfigurarMenuPorRol();
        }

        private void ConfigurarMenuPorRol()
        {
            // Desactiva todo primero
            usuariosToolStripMenuItem.Enabled = false;
            proveedoresToolStripMenuItem.Enabled = false;
            productosToolStripMenuItem.Enabled = false;
            ventasToolStripMenuItem.Enabled = false;
            registrarVentaToolStripMenuItem.Enabled = false;
            verVentasToolStripMenuItem.Enabled = false;

            switch (Session.RoleId)
            {
                case 1: // Cliente
                    registrarVentaToolStripMenuItem.Enabled = true;
                    break;

                case 2: // Vendedor
                    productosToolStripMenuItem.Enabled = true;
                    verVentasToolStripMenuItem.Enabled = true;
                    registrarVentaToolStripMenuItem.Enabled = true;
                    break;

                case 3: // Administrador
                    usuariosToolStripMenuItem.Enabled = true;
                    proveedoresToolStripMenuItem.Enabled = true;
                    productosToolStripMenuItem.Enabled = true;
                    ventasToolStripMenuItem.Enabled = true;
                    registrarVentaToolStripMenuItem.Enabled = true;
                    verVentasToolStripMenuItem.Enabled = true;
                    break;
            }
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Menús de Gestión

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new VerUsuarios().ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new VerProveedor().ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new VerProductos().ShowDialog();
        }

        // Menu Ventas

        private void registrarVentaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Para Cliente o Admin 
            new RegistrarVentas().ShowDialog();
        }

        private void verVentasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Para Vendedor o Admin
            new VerVentas().ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Rodando Store v1.0\nDesarrollado por Mariana Ocampo y Karina Tabares",
                "Acerca de",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            var result = loginForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                ConfigurarMenuPorRol();
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            RegistrarseForm registrarseForm = new RegistrarseForm();
            var result = registrarseForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                ConfigurarMenuPorRol();
            }
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            FormCompra formCompra = new FormCompra();
            formCompra.Show();
        }
    }
}
