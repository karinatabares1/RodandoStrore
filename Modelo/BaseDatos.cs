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

        // Método para eliminar un usuario por ID
        public int EliminarUsuario(int idUsuario)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM usuario WHERE id_usuario = @idUsuario";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
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
        public int GuardarProducto(string nombre, string descripcion, string imagenUrl, int existencia, decimal precio)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO producto (nombre, descripcion, imagen_url, existencia, precio) VALUES (@nombre, @descripcion, @imagenUrl, @existencia, @precio)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@imagenUrl", imagenUrl);
                    cmd.Parameters.AddWithValue("@existencia", existencia);
                    cmd.Parameters.AddWithValue("@precio", precio);
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

        // Método para Actualizar una venta

        public int ActualizarVenta(int idVenta, int idUsuario, decimal total)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE ventas SET id_usuario = @idUsuario, total = @total WHERE id_ventas = @idVenta";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@idVenta", idVenta);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para eliminar una venta

        public int EliminarVenta(int idVenta)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM ventas WHERE id_ventas = @idVenta";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idVenta", idVenta);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Obtener detalle de ventas por id de venta
        public List<DetalleVentaEntity> TraerDetalleVentas(int idVenta)
        {
            List<DetalleVentaEntity> listaDetalles = new List<DetalleVentaEntity>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM detalle_ventas WHERE id_ventas = @idVenta";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idVenta", idVenta);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaDetalles.Add(new DetalleVentaEntity
                            {
                                Id_detalle_venta = reader.GetInt32("id_detalle_venta"),
                                Id_ventas = reader.GetInt32("id_ventas"),
                                Id_producto = reader.GetInt32("id_producto"),
                                cantidad = reader.GetInt32("cantidad"),
                                subtotal = reader.GetDecimal("subtotal")
                            });
                        }
                    }
                }
            }
            return listaDetalles;
        }

        // Guardar un detalle de venta
        public int GuardarDetalleVenta(int idVentas, int idProducto, int cantidad, decimal subtotal)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO detalle_ventas (id_ventas, id_producto, cantidad, subtotal) VALUES (@idVentas, @idProducto, @cantidad, @subtotal)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idVentas", idVentas);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@subtotal", subtotal);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Actualizar un detalle de venta
        public int ActualizarDetalleVenta(int idDetalleVenta, int idVentas, int idProducto, int cantidad, decimal subtotal)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE detalle_ventas SET id_ventas = @idVentas, id_producto = @idProducto, cantidad = @cantidad, subtotal = @subtotal WHERE id_detalle_venta = @idDetalleVenta";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idVentas", idVentas);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@subtotal", subtotal);
                    cmd.Parameters.AddWithValue("@idDetalleVenta", idDetalleVenta);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Eliminar un detalle de venta
        public int EliminarDetalleVenta(int idDetalleVenta)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM detalle_ventas WHERE id_detalle_venta = @idDetalleVenta";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idDetalleVenta", idDetalleVenta);
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

        // Método para obtener todos los proveedores (sin id_producto)
        public List<ProveedorEntity> TraerProveedores()
        {
            List<ProveedorEntity> listaProveedores = new List<ProveedorEntity>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM proveedor";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listaProveedores.Add(new ProveedorEntity
                        {
                            Id_proveedor = reader.GetInt32("id_proveedor"),
                            Nombre = reader.GetString("nombre"),
                            Telefono = reader.IsDBNull(reader.GetOrdinal("telefono")) ? null : reader.GetString("telefono"),
                            Direccion = reader.IsDBNull(reader.GetOrdinal("direccion")) ? null : reader.GetString("direccion"),
                            FechaRegistro = reader.GetDateTime("fecha_registro")
                        });
                    }
                }
            }
            return listaProveedores;
        }

        // Método para guardar un proveedor (sin id_producto)
        public int GuardarProveedor(string nombre, string telefono, string direccion, DateTime fecha)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO proveedor (nombre, telefono, direccion) VALUES (@nombre, @telefono, @direccion, @fecha)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@direccion", direccion);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para actualizar un proveedor (sin id_producto)
        public int ActualizarProveedor(int idProveedor, string nombre, string telefono, string direccion, DateTime fecha)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE proveedor SET nombre = @nombre, telefono = @telefono, direccion = @direccion, fecha = @fecha WHERE id_proveedor = @idProveedor";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@direccion", direccion);
                    cmd.Parameters.AddWithValue("@idProveedor", idProveedor);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para eliminar un proveedor
        public int EliminarProveedor(int idProveedor)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM proveedor WHERE id_proveedor = @idProveedor";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idProveedor", idProveedor);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para asignar un producto a un proveedor en la tabla intermedia proveedor_producto
        public int AsignarProductoProveedor(int idProveedor, int idProducto)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO proveedor_producto (id_proveedor, id_producto) VALUES (@idProveedor, @idProducto)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idProveedor", idProveedor);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

    }    
}