using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G7_GestionInventario.Clases
{
    internal class G7_Categoria
    {
        public string G7_Nombre { get; set; }
        private List<G7_Producto> G7_Productos;

        public G7_Categoria(string nombre)
        {
            G7_Nombre = nombre;
            G7_Productos = new List<G7_Producto>();
        }

        public void G7_AgregarProducto(G7_Producto producto)
        {
            G7_Productos.Add(producto);
        }

        public int G7_CalcularStockTotal()
        {
            return G7_CalcularStockRecursivo(G7_Productos, 0);
        }

        private int G7_CalcularStockRecursivo(List<G7_Producto> productos, int indice)
        {
            if (indice >= productos.Count)
                return 0;

            return productos[indice].G7_Cantidad + G7_CalcularStockRecursivo(productos, indice + 1);
        }

        public decimal G7_CalcularValorTotal()
        {
            return G7_Productos.Sum(p => p.G7_Precio * p.G7_Cantidad);
        }
    }
}
