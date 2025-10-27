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
        public void G7_RegistrarProducto(string G7_nombre, string G7_categoria, decimal G7_precio, int G7_cantidad)
        {
            // Validaciones
            if (string.IsNullOrEmpty(G7_nombre) || string.IsNullOrEmpty(G7_categoria))
                throw new ArgumentException("Por favor rellene los campos correctamente");

            if (G7_precio <= 0)
                throw new ArgumentOutOfRangeException("El precio debe ser mayor a 0");

            if (G7_cantidad < 0)
                throw new ArgumentOutOfRangeException("La cantidad no puede ser negativa");

            if (G7_Productos.Exists(p => p.G7_Nombre.ToLower() == G7_nombre.ToLower()))
                throw new InvalidOperationException("Ya existe un producto con ese nombre");

            var G7_producto = new G7_Producto(G7_nombre, G7_categoria, G7_precio, G7_cantidad);
            G7_Productos.Add(G7_producto);

            if (!G7_Categorias.ContainsKey(G7_categoria))
            {
                G7_Categorias[G7_categoria] = new G7_Categoria(G7_categoria);
            }
            G7_Categorias[G7_categoria].G7_AgregarProducto(G7_producto);
        }

        // Implementación de búsqueda lineal
        public List<G7_Producto> G7_BuscarProductos(string G7_nombre)
        {
            List<G7_Producto> G7_resultados = new List<G7_Producto>();
            G7_nombre = G7_nombre.ToLower();

            // Búsqueda lineal/secuencial
            for (int i = 0; i < G7_Productos.Count; i++)
            {
                if (G7_Productos[i].G7_Nombre.ToLower().Contains(G7_nombre))
                {
                    G7_resultados.Add(G7_Productos[i]);
                }
            }

            return G7_resultados;
        }

        // Implementación de Insertion Sort xd
        
        public List<G7_Producto> G7_ObtenerProductosOrdenados(bool ascendente)
        {
            List<G7_Producto> G7_productosOrdenados = new List<G7_Producto>(G7_Productos);

            for (int i = 1; i < G7_productosOrdenados.Count; i++)
            {
                var actual = G7_productosOrdenados[i];
                int j = i - 1;

                // Comparar por precio 
                while (j >= 0 && CompararPrecio(G7_productosOrdenados[j].G7_Precio, actual.G7_Precio, ascendente) > 0)
                {
                    G7_productosOrdenados[j + 1] = G7_productosOrdenados[j];
                    j--;
                }

                G7_productosOrdenados[j + 1] = actual;
            }

            return G7_productosOrdenados;
        }

        // Método auxiliar que compara doss precios según orden ascendente/descendente
        private int CompararPrecio(decimal p1, decimal p2, bool G7_ascendente)
        {
            int G7_comparacion = p1.CompareTo(p2);
            return G7_ascendente ? G7_comparacion : -G7_comparacion;
        }

        // Método para calcular stock por categoría usando recursividad
        public Dictionary<string, int> G7_ObtenerStockPorCategoria()
        {
            Dictionary<string, int> G7_resultado = new Dictionary<string, int>();
            foreach (var categoria in G7_Categorias)
            {
                G7_resultado[categoria.Key] = categoria.Value.G7_CalcularStockTotal();
            }
            return G7_resultado;
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
