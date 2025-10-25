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
        public G7_Producto(string nombre, string categoria, decimal precio, int cantidad)
        {
            G7_Nombre = nombre;
            G7_Categoria = categoria;
            G7_Precio = precio;
            G7_Cantidad = cantidad;
        }
    }
}
