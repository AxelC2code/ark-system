using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
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

            G7_dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            G7_inventario.G7_CargarDatosEjemplo();
            G7_ActualizarListaProductos();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Mover()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
                decimal G7_precio = decimal.Parse(G7_txtPrecio.Text);
                int G7_cantidad = int.Parse(G7_txtCantidad.Text);

                G7_inventario.G7_RegistrarProducto(
                    G7_txtNombre.Text,
                    G7_txtCategoria.Text,
                    G7_precio,
                    G7_cantidad
                );

                MessageBox.Show("Producto registrado exitosamente");
                G7_LimpiarCampos();
                G7_ActualizarListaProductos();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese valores numéricos válidos para precio y cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                var G7_productos = G7_inventario.G7_BuscarProductos(G7_txtBuscar.Text);
                G7_MostrarProductos(G7_productos);
                
                if (G7_productos.Count == 0)
                {
                    MessageBox.Show("No se encontro productos relacionados", 
                        "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al realizar la búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void G7_btnOrdenar_Click(object sender, EventArgs e)
        {
            try
            {
                var G7_productos = G7_inventario.G7_ObtenerProductosOrdenados(G7_rbAscendente.Checked);
                G7_MostrarProductos(G7_productos);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ordenar los productos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void G7_btnCalcularStock_Click(object sender, EventArgs e)
        {
            try
            {
                var G7_stockPorCategoria = G7_inventario.G7_ObtenerStockPorCategoria();

                G7_dgvStock.Rows.Clear();
                foreach (var kvp in G7_stockPorCategoria)
                {
                    G7_dgvStock.Rows.Add(kvp.Key, kvp.Value);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al calcular el stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void G7_ActualizarListaProductos()
        {
            var G7_productos = G7_inventario.G7_ObtenerProductosOrdenados(true);
            G7_MostrarProductos(G7_productos);
        }

        private void G7_LimpiarCampos()
        {
            G7_txtNombre.Clear();
            G7_txtCategoria.Clear();
            G7_txtPrecio.Clear();
            G7_txtCantidad.Clear();
        }

        private void G7_MostrarProductos(List<G7_Producto> G7_productos)
        {
            G7_dgvProductos.Rows.Clear();
            foreach (var G7_producto in G7_productos)
            {
                G7_dgvProductos.Rows.Add(
                    G7_producto.G7_Nombre,
                    G7_producto.G7_Categoria,
                    G7_producto.G7_Precio.ToString("C"),
                    G7_producto.G7_Cantidad
                );
            }
        }
    }
}
