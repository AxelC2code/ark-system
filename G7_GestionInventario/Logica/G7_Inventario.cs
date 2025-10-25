using G7_GestionInventario.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace G7_GestionInventario.Logica
{
    internal class G7_Inventario
    {
        private List<G7_Producto> G7_Productos;
        private Dictionary<string, G7_Categoria> G7_Categorias;

        public G7_Inventario()
        {
            G7_Productos = new List<G7_Producto>();
            G7_Categorias = new Dictionary<string, G7_Categoria>();
        }

        public void G7_RegistrarProducto(string nombre, string categoria, decimal precio, int cantidad)
        {
            // Validaciones
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(categoria))
                throw new ArgumentException("El nombre y la categoría son obligatorios");

            if (precio <= 0)
                throw new ArgumentOutOfRangeException("El precio debe ser mayor a 0");

            if (cantidad < 0)
                throw new ArgumentOutOfRangeException("La cantidad no puede ser negativa");

            if (G7_Productos.Any(p => p.G7_Nombre.ToLower() == nombre.ToLower()))
                throw new InvalidOperationException("Ya existe un producto con ese nombre");

            // Crear y registrar el producto
            var producto = new G7_Producto(nombre, categoria, precio, cantidad);
            G7_Productos.Add(producto);

            // Manejar la categoría
            if (!G7_Categorias.ContainsKey(categoria))
            {
                G7_Categorias[categoria] = new G7_Categoria(categoria);
            }
            G7_Categorias[categoria].G7_AgregarProducto(producto);
        }

        public List<G7_Producto> G7_BuscarProductos(string nombre)
        {
            return G7_Productos
                .Where(p => p.G7_Nombre.ToLower().Contains(nombre.ToLower()))
                .ToList();
        }

        public List<G7_Producto> G7_ObtenerProductosOrdenados(bool ascendente)
        {
            return ascendente
                ? G7_Productos.OrderBy(p => p.G7_Precio).ToList()
                : G7_Productos.OrderByDescending(p => p.G7_Precio).ToList();
        }

        public Dictionary<string, int> G7_ObtenerStockPorCategoria()
        {
            return G7_Categorias.ToDictionary(
                kvp => kvp.Key,
                kvp => kvp.Value.G7_CalcularStockTotal()
            );
        }

        // Método para precargar datos desde archivo
        public void G7_CargarDatosEjemplo()
        {
            try
            {
                string[] lineas = File.ReadAllLines("data.txt");
                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(',');
                    if (datos.Length == 4)
                    {
                        string nombre = datos[0].Trim();
                        string categoria = datos[1].Trim();
                        if (decimal.TryParse(datos[2].Trim(), out decimal precio) &&
                            int.TryParse(datos[3].Trim(), out int cantidad))
                        {
                            try
                            {
                                G7_RegistrarProducto(nombre, categoria, precio, cantidad);
                            }
                            catch (InvalidOperationException)
                            {
                                // Ignorar productos duplicados
                                continue;
                            }
                            catch (ArgumentException)
                            {
                                // Ignorar productos con datos inválidos
                                continue;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new IOException($"Error al cargar datos desde archivo: {ex.Message}", ex);
            }
        }
    }
}
