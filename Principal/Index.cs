//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using MySql.Data.MySqlClient;

//namespace Principal
//{
//    public partial class Index : Form
//    {
//        private string connectionString = "server=localhost;database=rodandoStore;user=root;password=;";
//        private string carpetaImagenes = Path.Combine(Application.StartupPath, "Imagenes"); // Carpeta donde están las imágenes


//        public Index()
//        {
//            InitializeComponent();
//            CargarProductos();
//        }

//        private void CargarProductos()
//        {
//            using (MySqlConnection conn = new MySqlConnection(connectionString))
//            {
//                try
//                {
//                    conn.Open();
//                    string query = "SELECT nombre, imagen_url FROM producto LIMIT 3"; // Máximo 3 productos
//                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
//                    using (MySqlDataReader reader = cmd.ExecuteReader())
//                    {
//                        int index = 1; // Contador para asignar a controles existentes

//                        while (reader.Read())
//                        {
//                            string nombre = reader["nombre"].ToString();
//                            string imagenUrl = reader["imagen_url"].ToString();
//                            string rutaImagen = Path.Combine(carpetaImagenes, imagenUrl); // Ruta completa de la imagen

//                            // Buscar controles existentes por nombre
//                            PictureBox pb = this.Controls.Find("pictureBox" + index, true).FirstOrDefault() as PictureBox;
//                            Label lbl = this.Controls.Find("label" + index, true).FirstOrDefault() as Label;

//                            if (pb != null)
//                            {
//                                try
//                                {
//                                    if (File.Exists(rutaImagen))
//                                    {
//                                        pb.Image = Image.FromFile(rutaImagen);
//                                    }
//                                    else
//                                    {
//                                        pb.Image = Image.FromFile(Path.Combine(carpetaImagenes, "imagen_default.png")); // Imagen de respaldo
//                                    }
//                                }
//                                catch
//                                {
//                                    pb.Image = Image.FromFile(Path.Combine(carpetaImagenes, "imagen_default.png")); // Imagen de respaldo en caso de error
//                                }
//                            }

//                            if (lbl != null)
//                            {
//                                lbl.Text = nombre;
//                            }

//                            index++; // Incrementar índice para el siguiente producto
//                        }
//                    }
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show("Error al cargar los productos: " + ex.Message);
//                }
//            }
//        }
//    }
//}
