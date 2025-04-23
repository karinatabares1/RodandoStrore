using MySql.Data.MySqlClient;
using Modelo.Entities;
using System;
using System.Collections.Generic;

namespace Modelo
{
    public class BaseDatos
    {
        private string connectionString = "server=localhost;database=rodandoStore;user=root;password=;";

        // Métodos de Usuario

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


        // Métodos para Rol

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

        // Métodos de Producto


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
                            precio = reader.GetDecimal("precio")
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

        public int ActualizarProducto(int idProducto, string nombre, string descripcion, string imagenUrl, int existencia, decimal precio)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE producto SET nombre = @nombre, descripcion = @descripcion, imagen_url = @imagenUrl, existencia = @existencia, precio = @precio WHERE id_producto = @idProducto";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@imagenUrl", imagenUrl);
                    cmd.Parameters.AddWithValue("@existencia", existencia);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Agregar Imagen de Producto
        // Agregar Imagen de Producto (actualizado para usar ID)
        public int ActualizarImagenProducto(int idProducto, byte[] imagen)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE producto SET imagen = @imagen WHERE id_producto = @idProducto";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@imagen", imagen);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);
                    return cmd.ExecuteNonQuery();
                }
            }
        }



        // Método para eliminar un producto por ID
        public int EliminarProducto(int idProducto)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM producto WHERE id_producto = @idProducto";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);
                    return cmd.ExecuteNonQuery();
                }
            }
        }


        // Métodos de Venta

        public List<VentasEntity> TraerVentas()
        {
            List<VentasEntity> listaVentas = new List<VentasEntity>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT v.id_ventas, v.id_usuario, u.nombre AS nombre_usuario, v.fecha, v.total 
                                 FROM ventas v
                                 INNER JOIN usuario u ON v.id_usuario = u.id_usuario";

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
                            total = reader.GetDecimal("total"),
                            usuario = new UsuarioEntity
                            {
                                Id_usuario = reader.GetInt32("id_usuario"),
                                nombre = reader.GetString("nombre_usuario")
                            }
                        });
                    }
                }
            }

            return listaVentas;
        }

        public int GuardarVenta(int idUsuario, decimal total)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    INSERT INTO ventas (id_usuario, total)
                    VALUES (@idUsuario, @total);
                    SELECT LAST_INSERT_ID();";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@total", total);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public int ActualizarVenta(int idVenta, DateTime fecha, decimal total)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE ventas SET fecha = @fecha, total = @total WHERE id_ventas = @idVenta";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@idVenta", idVenta);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

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



        // Métodos de Detalle de Venta

        public int GuardarDetalleVenta(int idVenta, int idProducto, int cantidad, decimal subtotal)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    INSERT INTO detalle_ventas 
                    (id_ventas, id_producto, cantidad, subtotal) 
                    VALUES 
                    (@idVenta, @idProducto, @cantidad, @subtotal)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idVenta", idVenta);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@subtotal", subtotal);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public List<DetalleVentaEntity> TraerDetalleVentas(int idVenta)
        {
            var lista = new List<DetalleVentaEntity>();
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM detalle_ventas WHERE id_ventas = @idVenta";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idVenta", idVenta);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new DetalleVentaEntity
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
            return lista;
        }

        public int ActualizarDetalleVenta(int idVenta, int idProducto, int cantidad, decimal subtotal)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE detalle_ventas SET cantidad = @cantidad, subtotal = @subtotal WHERE id_ventas = @idVenta AND id_producto = @idProducto";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@subtotal", subtotal);
                    cmd.Parameters.AddWithValue("@idVenta", idVenta);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);
                    return cmd.ExecuteNonQuery();
                }
            }
        }


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

        // Métodos de Proveedor

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


        // Metodos de Factura
        public int GuardarFactura(int idVentas, string metodoPago, string direccionEntrega)
        {
            int filasAfectadas = 0;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO factura (id_ventas, metodo_pago, direccion_entrega) VALUES (@idVentas, @metodoPago, @direccionEntrega)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idVentas", idVentas);
                cmd.Parameters.AddWithValue("@metodoPago", metodoPago);
                cmd.Parameters.AddWithValue("@direccionEntrega", direccionEntrega);
                filasAfectadas = cmd.ExecuteNonQuery();
            }

            return filasAfectadas;
        }

        public List<FacturaEntity> TraerFacturas()
        {
            List<FacturaEntity> lista = new List<FacturaEntity>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM factura";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    FacturaEntity f = new FacturaEntity();
                    f.Id_factura = reader.GetInt32("id_factura");
                    f.Id_ventas = reader.GetInt32("id_ventas");
                    f.Fecha_emision = reader.GetDateTime("fecha_emision");
                    f.Metodo_pago = reader.GetString("metodo_pago");
                    f.Direccion_entrega = reader.GetString("direccion_entrega");

                    lista.Add(f);
                }
            }

            return lista;
        }

    }
}
