using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G7_GestionInventario.Clases
{
    internal class G7_Producto
    {
        // Usamos propiedades para encapsular los datos del producto.
        public string G7_Nombre { get; set; }
        public string G7_Categoria { get; set; } // Nombre de la categoría a la que pertenece
        public decimal G7_Precio { get; set; }
        public int G7_Cantidad { get; set; }

        // Un constructor para facilitar la creación de nuevos productos.
        public G7_Producto(string g7_nombre, string g7_categoria, decimal g7_precio, int g7_cantidad)
        {
            G7_Nombre = g7_nombre;
            G7_Categoria = g7_categoria;
            G7_Precio = g7_precio;
            G7_Cantidad = g7_cantidad;
        }
    }
}
