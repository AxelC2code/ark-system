using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G7_GestionInventario.Logica;
using G7_GestionInventario.Clases;

namespace G7_GestionInventario
{
    public partial class G7_frmPrincipal : Form
    {
        private G7_Inventario G7_inventario;

        public G7_frmPrincipal()
        {
            InitializeComponent();
            G7_inventario = new G7_Inventario();

            // Configurar columnas del DataGridView de productos
            G7_dgvProductos.Columns.Add("Nombre", "Nombre");
            G7_dgvProductos.Columns.Add("Categoria", "Categoría");
            G7_dgvProductos.Columns.Add("Precio", "Precio");
            G7_dgvProductos.Columns.Add("Cantidad", "Cantidad");

            // Configurar columnas del DataGridView de stock
            G7_dgvStock.Columns.Add("Categoria", "Categoría");
            G7_dgvStock.Columns.Add("StockTotal", "Stock Total");

            G7_inventario.G7_CargarDatosEjemplo();
            G7_ActualizarListaProductos();
        }

        //Para modificar el aspecto de la cabecera se implementará las siguientes lineas de codigo y metodos (solo hasta Cerrar())

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Mover()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0); //pegar code para mover el formulario
        }

        private void Cabecera(object sender, MouseEventArgs e)
        {
            Mover();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void G7_btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal precio = decimal.Parse(G7_txtPrecio.Text);
                int cantidad = int.Parse(G7_txtCantidad.Text);

                G7_inventario.G7_RegistrarProducto(
                    G7_txtNombre.Text,
                    G7_txtCategoria.Text,
                    precio,
                    cantidad
                );

                MessageBox.Show("Producto registrado exitosamente");
                G7_LimpiarCampos();
                G7_ActualizarListaProductos();
            }
            catch (FormatException)
            {
                MessageBox.Show("El precio y la cantidad deben ser valores numéricos válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void G7_btnBuscar_Click(object sender, EventArgs e)
        {
            var productos = G7_inventario.G7_BuscarProductos(G7_txtBuscar.Text);
            G7_MostrarProductos(productos);
        }

        private void G7_btnOrdenar_Click(object sender, EventArgs e)
        {
            var productos = G7_inventario.G7_ObtenerProductosOrdenados(G7_rbAscendente.Checked);
            G7_MostrarProductos(productos);
        }

        private void G7_btnCalcularStock_Click(object sender, EventArgs e)
        {
            var stockPorCategoria = G7_inventario.G7_ObtenerStockPorCategoria();

            G7_dgvStock.Rows.Clear();
            foreach (var kvp in stockPorCategoria)
            {
                G7_dgvStock.Rows.Add(kvp.Key, kvp.Value);
            }
        }

        

        private void G7_ActualizarListaProductos()
        {
            var productos = G7_inventario.G7_ObtenerProductosOrdenados(true);
            G7_MostrarProductos(productos);
        }
        //limpiar
        private void G7_LimpiarCampos()
        {
            G7_txtNombre.Clear();
            G7_txtCategoria.Clear();
            G7_txtPrecio.Clear();
            G7_txtCantidad.Clear();
        }

        private void G7_MostrarProductos(System.Collections.Generic.List<G7_Producto> productos)
        {
            G7_dgvProductos.Rows.Clear();
            foreach (var producto in productos)
            {
                G7_dgvProductos.Rows.Add(
                    producto.G7_Nombre,
                    producto.G7_Categoria,
                    producto.G7_Precio.ToString("C"),
                    producto.G7_Cantidad
                );
            }
        }
    }
}
