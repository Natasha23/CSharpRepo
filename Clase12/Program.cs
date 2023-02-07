using PreEntrega;
using System.Data.SqlClient;

namespace Clase12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=DESKTOP-4R3SBSS\\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            ListarProductos(connectionString);


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                ListarProductos(connectionString);
                ListarUsuarios(connectionString);
                ListarVentas(connectionString);
                ListarProductosVendidos(connectionString);
            }
        }
        public static List<Producto> ListarProductos(string connectionString)
        {
            List<Producto> productos = new List<Producto>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Select para traer todos los productos
                SqlCommand comandoProducto = new SqlCommand("SELECT * FROM Producto", connection);
                connection.Open();
                using (SqlDataReader reader = comandoProducto.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            productos.Add(new Producto(
                                Convert.ToInt64(reader["Id"]),
                                Convert.ToString(reader["Descripciones"]),
                                Convert.ToDecimal(reader["Costo"]),
                                Convert.ToDecimal(reader["PrecioVenta"]),
                                Convert.ToInt32(reader["Stock"]),
                                Convert.ToInt64(reader["IdUsuario"])
                            ));
                        }
                    }
                }
            }
            foreach (Producto producto in productos)
            {
                Console.WriteLine(producto);
            }
            return productos;
        }
        public static List<Usuario> ListarUsuarios(string connectionString)
        {
            List<Usuario> usuarios = new List<Usuario>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Select para traer todos los productos
                SqlCommand comandoUsuario = new SqlCommand("SELECT * FROM Usuario", connection);
                connection.Open();
                using (SqlDataReader reader = comandoUsuario.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            usuarios.Add(new Usuario(
                                Convert.ToInt64(reader["Id"]),
                                Convert.ToString(reader["Nombre"]),
                                Convert.ToString(reader["Apellido"]),
                                Convert.ToString(reader["NombreUsuario"]),
                                Convert.ToString(reader["Contraseña"]),
                                Convert.ToString(reader["Mail"])
                            ));
                        }
                    }
                }
            }
            foreach (Usuario user in usuarios)
            {
                Console.WriteLine(user);
            }
            return usuarios;
        }

        public static List<Venta> ListarVentas(string connectionString)
        {
            List<Venta> ventas = new List<Venta>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Select para traer todos los productos
                SqlCommand comandoVenta = new SqlCommand("SELECT * FROM Venta", connection);
                connection.Open();
                using (SqlDataReader reader = comandoVenta.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ventas.Add(new Venta(
                                Convert.ToInt64(reader["Id"]),
                                Convert.ToString(reader["Comentarios"]),
                                Convert.ToInt64(reader["IdUsuario"])
                            ));
                        }
                    }
                }
            }
            foreach (Venta venta in ventas)
            {
                Console.WriteLine(venta);
            }
            return ventas;
        }

        public static List<ProductoVendido> ListarProductosVendidos(string connectionString)
        {
            List<ProductoVendido> productosVendidos = new List<ProductoVendido>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Select para traer todos los productos
                SqlCommand comandoProductoVendido = new SqlCommand("SELECT * FROM ProductoVendido", connection);
                connection.Open();
                using (SqlDataReader reader = comandoProductoVendido.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            productosVendidos.Add(new ProductoVendido(
                                Convert.ToInt64(reader["Id"]),
                                Convert.ToInt32(reader["Stock"]),
                                Convert.ToInt64(reader["IdProducto"]),
                                Convert.ToInt64(reader["IdVenta"])
                            ));
                        }
                    }
                }
            }
            foreach (ProductoVendido prod in productosVendidos)
            {
                Console.WriteLine(prod);
            }
            return productosVendidos;
        }
    }
}