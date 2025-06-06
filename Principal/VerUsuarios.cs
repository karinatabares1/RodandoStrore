﻿using Logica;
using Modelo.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Principal
{
    public partial class VerUsuarios : Form
    {
        private UsuarioController usuarioController;

        public VerUsuarios()
        {
            InitializeComponent();
            usuarioController = new UsuarioController();
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            try
            {
                List<UsuarioEntity> usuarios = usuarioController.ObtenerUsuarios();
                Dictionary<int, string> roles = usuarioController.ObtenerRoles();

                DataTable dt = new DataTable();
                dt.Columns.Add("id_usuario", typeof(int));
                dt.Columns.Add("nombre", typeof(string));
                dt.Columns.Add("rol", typeof(string));

                foreach (var usuario in usuarios)
                {
                    string rolNombre = roles.ContainsKey(usuario.Id_rol) ? roles[usuario.Id_rol] : "Desconocido";
                    dt.Rows.Add(usuario.Id_usuario, usuario.nombre, rolNombre);
                }

                dgvUsuarios.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los usuarios: " + ex.Message);
            }
        }
    }
}
