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
            CargarTodasLasFacturas();
        }

        private void CargarTodasLasFacturas()
        {
            List<FacturaEntity> lista = facturaController.ObtenerFacturas();
            dgvFactura.DataSource = lista;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // Obtener la fecha seleccionada en el DateTimePicker
            DateTime fechaSeleccionada = dtpFecha.Value.Date;

            // Obtener todas las facturas
            List<FacturaEntity> todas = facturaController.ObtenerFacturas();

            // Filtrar por fecha (comparando solo la fecha sin la hora)
            List<FacturaEntity> filtradas = todas.FindAll(f => f.Fecha_emision.Date == fechaSeleccionada);

            // Mostrar en DataGridView
            dgvFactura.DataSource = filtradas;
        }
    }
}
