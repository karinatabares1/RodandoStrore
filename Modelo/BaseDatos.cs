using MySql.Data.MySqlClient;
using Modelo.Entities;
using System;
using System.Collections.Generic;

namespace Modelo
{
    public class BaseDatos
    {
        private string connectionString = "server=localhost;database=rodandoStore;user=root;password=;";

        // Método para obtener todos los usuarios
        public List<UsuarioEntity> TraerUsuarios()
        {
            List<UsuarioEntity> listaUsuarios = new List<UsuarioEntity>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM usuario";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listaUsuarios.Add(new UsuarioEntity
                        {
                            Id_usuario = reader.GetInt32("id_usuario"),
                            nombre = reader.GetString("nombre"),
                            Id_rol = reader.GetInt32("id_rol")
                        });
                    }
                }
            }
            return listaUsuarios;
        }

        // Método para guardar un usuario
        public int GuardarUsuario(string nombre, int idRol)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO usuario (nombre, id_rol) VALUES (@nombre, @idRol)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@idRol", idRol);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para actualizar un usuario
        public int ActualizarUsuario(int Id_Usuario, string nombre, int Id_Rol)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE usuario SET nombre = @nombre, id_rol = @idRol WHERE id_usuario = @idUsuario";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@idRol", Id_Rol);
                    cmd.Parameters.AddWithValue("@idUsuario", Id_Usuario);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para obtener todos los productos
        public List<ProductoEntity> TraerProductos()
        {
            List<ProductoEntity> listaProductos = new List<ProductoEntity>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM producto";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listaProductos.Add(new ProductoEntity
                        {
                            Id_producto = reader.GetInt32("id_producto"),
                            nombre = reader.GetString("nombre"),
                            descripcion = reader.GetString("descripcion"),
                            imagen_url = reader.IsDBNull(reader.GetOrdinal("imagen_url")) ? null : reader.GetString("imagen_url"),
                            existencia = reader.GetInt32("existencia"),
                            precio = reader.GetDecimal("precio"),
                            cantidad = reader.GetInt32("cantidad")
                        });
                    }
                }
            }
            return listaProductos;
        }

        // Método para guardar un producto
        public int GuardarProducto(string nombre, string descripcion, string imagenUrl, int existencia, decimal precio, int cantidad)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO producto (nombre, descripcion, imagen_url, existencia, precio, cantidad) VALUES (@nombre, @descripcion, @imagenUrl, @existencia, @precio, @cantidad)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@imagenUrl", imagenUrl);
                    cmd.Parameters.AddWithValue("@existencia", existencia);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para obtener todas las ventas
        public List<VentasEntity> TraerVentas()
        {
            List<VentasEntity> listaVentas = new List<VentasEntity>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM ventas";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listaVentas.Add(new VentasEntity
                        {
                            Id_ventas = reader.GetInt32("id_ventas"),
                            Id_usuario = reader.GetInt32("id_usuario"),
                            fecha = reader.GetDateTime("fecha"),
                            total = reader.GetDecimal("total")
                        });
                    }
                }
            }
            return listaVentas;
        }

        // Método para guardar una venta
        public int GuardarVenta(int idUsuario, decimal total)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO ventas (id_usuario, total) VALUES (@idUsuario, @total)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@total", total);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para obtener los roles correctamente
        public Dictionary<int, string> ObtenerRoles()
        {
            Dictionary<int, string> roles = new Dictionary<int, string>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                // Corrige el nombre de la tabla y la columna
                string query = "SELECT id_rol, nombre FROM rol";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        roles.Add(reader.GetInt32("id_rol"), reader.GetString("nombre"));
                    }
                }
            }
            return roles;
        }

    }
}
