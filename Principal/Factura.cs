using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.Entities;

namespace Principal
{
    public partial class Factura : Form
    {
        private FacturaController facturaController;
        public Factura()
        {
            InitializeComponent();
            facturaController = new FacturaController();
            CargarFacturas();
        }

        private void CargarFacturas()
        {
            List<FacturaEntity> lista = facturaController.ObtenerFacturas();
            dataGridView1.DataSource = lista;
        }
    }
}
