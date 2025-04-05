using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class FormPrueba : Form
    {
        public FormPrueba()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            VerUsuarios formUsuarios = new VerUsuarios();
            formUsuarios.ShowDialog();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            VerProveedor formProveedores = new VerProveedor();
            formProveedores.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventas formVentas = new Ventas();
            formVentas.ShowDialog();
        }
    }
}
