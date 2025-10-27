using G7_GestionInventario.Clases;
using System;
using System.Collections.Generic;
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

        // Método para registrar un nuevo producto
        public void G7_RegistrarProducto(string nombre, string categoria, decimal precio, int cantidad)
        {
            // Validaciones
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(categoria))
                throw new ArgumentException("Por favor rellene los campos correctamente");

            if (precio <= 0)
                throw new ArgumentOutOfRangeException("El precio debe ser mayor a 0");

            if (cantidad < 0)
                throw new ArgumentOutOfRangeException("La cantidad no puede ser negativa");

            if (G7_Productos.Exists(p => p.G7_Nombre.ToLower() == nombre.ToLower()))
                throw new InvalidOperationException("Ya existe un producto con ese nombre");

            var producto = new G7_Producto(nombre, categoria, precio, cantidad);
            G7_Productos.Add(producto);

            if (!G7_Categorias.ContainsKey(categoria))
            {
                G7_Categorias[categoria] = new G7_Categoria(categoria);
            }
            G7_Categorias[categoria].G7_AgregarProducto(producto);
        }

        // Implementación de búsqueda lineal
        public List<G7_Producto> G7_BuscarProductos(string nombre)
        {
            List<G7_Producto> resultados = new List<G7_Producto>();
            nombre = nombre.ToLower();

            // Búsqueda lineal/secuencial
            for (int i = 0; i < G7_Productos.Count; i++)
            {
                if (G7_Productos[i].G7_Nombre.ToLower().Contains(nombre))
                {
                    resultados.Add(G7_Productos[i]);
                }
            }

            return resultados;
        }

        // Implementación de Insertion Sort para ordenar únicamente por precio
        
        public List<G7_Producto> G7_ObtenerProductosOrdenados(bool ascendente)
        {
            List<G7_Producto> productosOrdenados = new List<G7_Producto>(G7_Productos);

            for (int i = 1; i < productosOrdenados.Count; i++)
            {
                var actual = productosOrdenados[i];
                int j = i - 1;

                // Comparar por precio directamente
                while (j >= 0 && CompararPrecio(productosOrdenados[j].G7_Precio, actual.G7_Precio, ascendente) > 0)
                {
                    productosOrdenados[j + 1] = productosOrdenados[j];
                    j--;
                }

                productosOrdenados[j + 1] = actual;
            }

            return productosOrdenados;
        }

        // Método auxiliar que compara dos precios según orden ascendente/descendente
        private int CompararPrecio(decimal p1, decimal p2, bool ascendente)
        {
            int comparacion = p1.CompareTo(p2);
            return ascendente ? comparacion : -comparacion;
        }

        // Método para calcular stock por categoría usando recursividad
        public Dictionary<string, int> G7_ObtenerStockPorCategoria()
        {
            Dictionary<string, int> resultado = new Dictionary<string, int>();
            foreach (var categoria in G7_Categorias)
            {
                resultado[categoria.Key] = categoria.Value.G7_CalcularStockTotal();
            }
            return resultado;
        }

        // Método para cargar datos de ejemplo
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
