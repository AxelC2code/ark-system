using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G7_GestionInventario.Modelo
{
    internal class G7_Categoria
    {
        public string G7_Nombre { get; set; }
        public List<G7_Producto> G7_Productos { get; set; } // Productos directamente en esta categoría
        public List<G7_Categoria> G7_Subcategorias { get; set; } // Categorías hijas

        public G7_Categoria(string g7_nombre)
        {
            G7_Nombre = g7_nombre;
            G7_Productos = new List<G7_Producto>();
            G7_Subcategorias = new List<G7_Categoria>();
        }

        /// REQUISITO 4: Calcula el stock total usando recursividad.
        /// Suma el stock de sus productos y llama a esta misma función para todas sus subcategorías.

        public int G7_CalcularStockTotalRecursivo()
        {
            // 1. Suma el stock de los productos que están directamente en esta categoría.
            int G7_stockTotal = this.G7_Productos.Sum(p => p.G7_Cantidad);

            // 2. Por cada subcategoría, llama a este mismo método y suma su resultado al total.
            foreach (var G7_subcategoria in this.G7_Subcategorias)
            {
                G7_stockTotal += G7_subcategoria.G7_CalcularStockTotalRecursivo();
            }

            return G7_stockTotal;
        }
    }
}
