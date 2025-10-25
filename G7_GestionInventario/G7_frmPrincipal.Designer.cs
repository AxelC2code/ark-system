namespace G7_GestionInventario
{
    partial class G7_frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.G7_grpRegistro = new System.Windows.Forms.GroupBox();
            this.G7_btnRegistrar = new System.Windows.Forms.Button();
            this.G7_txtCantidad = new System.Windows.Forms.TextBox();
            this.G7_txtPrecio = new System.Windows.Forms.TextBox();
            this.G7_txtCategoria = new System.Windows.Forms.TextBox();
            this.G7_txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.G7_grpStock = new System.Windows.Forms.GroupBox();
            this.G7_btnCalcularStock = new System.Windows.Forms.Button();
            this.G7_grpBusqueda = new System.Windows.Forms.GroupBox();
            this.G7_btnBuscar = new System.Windows.Forms.Button();
            this.G7_txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.G7_grpOrdenamiento = new System.Windows.Forms.GroupBox();
            this.G7_rbDescendente = new System.Windows.Forms.RadioButton();
            this.G7_rbAscendente = new System.Windows.Forms.RadioButton();
            this.G7_btnOrdenar = new System.Windows.Forms.Button();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.G7_dgvProductos = new System.Windows.Forms.DataGridView();
            this.G7_dgvStock = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.G7_grpRegistro.SuspendLayout();
            this.G7_grpStock.SuspendLayout();
            this.G7_grpBusqueda.SuspendLayout();
            this.G7_grpOrdenamiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G7_dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G7_dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Cerrar);
            this.panel1.Controls.Add(this.Minimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 27);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cabecera);
            // 
            // G7_grpRegistro
            // 
            this.G7_grpRegistro.Controls.Add(this.pictureBox2);
            this.G7_grpRegistro.Controls.Add(this.G7_btnRegistrar);
            this.G7_grpRegistro.Controls.Add(this.G7_txtCantidad);
            this.G7_grpRegistro.Controls.Add(this.G7_txtPrecio);
            this.G7_grpRegistro.Controls.Add(this.G7_txtCategoria);
            this.G7_grpRegistro.Controls.Add(this.G7_txtNombre);
            this.G7_grpRegistro.Controls.Add(this.label5);
            this.G7_grpRegistro.Controls.Add(this.label6);
            this.G7_grpRegistro.Controls.Add(this.label7);
            this.G7_grpRegistro.Controls.Add(this.label8);
            this.G7_grpRegistro.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G7_grpRegistro.Location = new System.Drawing.Point(12, 42);
            this.G7_grpRegistro.Name = "G7_grpRegistro";
            this.G7_grpRegistro.Size = new System.Drawing.Size(250, 200);
            this.G7_grpRegistro.TabIndex = 2;
            this.G7_grpRegistro.TabStop = false;
            this.G7_grpRegistro.Text = "Registro de Productos";
            // 
            // G7_btnRegistrar
            // 
            this.G7_btnRegistrar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G7_btnRegistrar.Location = new System.Drawing.Point(58, 159);
            this.G7_btnRegistrar.Name = "G7_btnRegistrar";
            this.G7_btnRegistrar.Size = new System.Drawing.Size(123, 35);
            this.G7_btnRegistrar.TabIndex = 8;
            this.G7_btnRegistrar.Text = "Registrar";
            this.G7_btnRegistrar.Click += new System.EventHandler(this.G7_btnRegistrar_Click);
            // 
            // G7_txtCantidad
            // 
            this.G7_txtCantidad.Location = new System.Drawing.Point(85, 124);
            this.G7_txtCantidad.Name = "G7_txtCantidad";
            this.G7_txtCantidad.Size = new System.Drawing.Size(150, 25);
            this.G7_txtCantidad.TabIndex = 7;
            // 
            // G7_txtPrecio
            // 
            this.G7_txtPrecio.Location = new System.Drawing.Point(85, 92);
            this.G7_txtPrecio.Name = "G7_txtPrecio";
            this.G7_txtPrecio.Size = new System.Drawing.Size(150, 25);
            this.G7_txtPrecio.TabIndex = 6;
            // 
            // G7_txtCategoria
            // 
            this.G7_txtCategoria.Location = new System.Drawing.Point(85, 60);
            this.G7_txtCategoria.Name = "G7_txtCategoria";
            this.G7_txtCategoria.Size = new System.Drawing.Size(150, 25);
            this.G7_txtCategoria.TabIndex = 5;
            // 
            // G7_txtNombre
            // 
            this.G7_txtNombre.Location = new System.Drawing.Point(85, 28);
            this.G7_txtNombre.Name = "G7_txtNombre";
            this.G7_txtNombre.Size = new System.Drawing.Size(150, 25);
            this.G7_txtNombre.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cantidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Precio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Categoría:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nombre:";
            // 
            // G7_grpStock
            // 
            this.G7_grpStock.Controls.Add(this.pictureBox1);
            this.G7_grpStock.Controls.Add(this.G7_dgvStock);
            this.G7_grpStock.Controls.Add(this.G7_btnCalcularStock);
            this.G7_grpStock.Location = new System.Drawing.Point(12, 248);
            this.G7_grpStock.Name = "G7_grpStock";
            this.G7_grpStock.Size = new System.Drawing.Size(250, 261);
            this.G7_grpStock.TabIndex = 4;
            this.G7_grpStock.TabStop = false;
            this.G7_grpStock.Text = "Stock por Categoría";
            // 
            // G7_btnCalcularStock
            // 
            this.G7_btnCalcularStock.BackgroundImage = global::G7_GestionInventario.Properties.Resources.icon_calcular;
            this.G7_btnCalcularStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.G7_btnCalcularStock.Location = new System.Drawing.Point(53, 19);
            this.G7_btnCalcularStock.Name = "G7_btnCalcularStock";
            this.G7_btnCalcularStock.Size = new System.Drawing.Size(128, 23);
            this.G7_btnCalcularStock.TabIndex = 0;
            this.G7_btnCalcularStock.Text = "Calcular";
            this.G7_btnCalcularStock.Click += new System.EventHandler(this.G7_btnCalcularStock_Click);
            // 
            // G7_grpBusqueda
            // 
            this.G7_grpBusqueda.Controls.Add(this.G7_btnBuscar);
            this.G7_grpBusqueda.Controls.Add(this.G7_txtBuscar);
            this.G7_grpBusqueda.Controls.Add(this.label1);
            this.G7_grpBusqueda.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.G7_grpBusqueda.Location = new System.Drawing.Point(275, 42);
            this.G7_grpBusqueda.Name = "G7_grpBusqueda";
            this.G7_grpBusqueda.Size = new System.Drawing.Size(250, 114);
            this.G7_grpBusqueda.TabIndex = 5;
            this.G7_grpBusqueda.TabStop = false;
            this.G7_grpBusqueda.Text = "Búsqueda";
            // 
            // G7_btnBuscar
            // 
            this.G7_btnBuscar.Location = new System.Drawing.Point(85, 63);
            this.G7_btnBuscar.Name = "G7_btnBuscar";
            this.G7_btnBuscar.Size = new System.Drawing.Size(121, 31);
            this.G7_btnBuscar.TabIndex = 2;
            this.G7_btnBuscar.Text = "Buscar";
            this.G7_btnBuscar.Click += new System.EventHandler(this.G7_btnBuscar_Click);
            // 
            // G7_txtBuscar
            // 
            this.G7_txtBuscar.Location = new System.Drawing.Point(85, 28);
            this.G7_txtBuscar.Name = "G7_txtBuscar";
            this.G7_txtBuscar.Size = new System.Drawing.Size(150, 25);
            this.G7_txtBuscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // G7_grpOrdenamiento
            // 
            this.G7_grpOrdenamiento.Controls.Add(this.G7_rbDescendente);
            this.G7_grpOrdenamiento.Controls.Add(this.G7_rbAscendente);
            this.G7_grpOrdenamiento.Controls.Add(this.G7_btnOrdenar);
            this.G7_grpOrdenamiento.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.G7_grpOrdenamiento.Location = new System.Drawing.Point(531, 42);
            this.G7_grpOrdenamiento.Name = "G7_grpOrdenamiento";
            this.G7_grpOrdenamiento.Size = new System.Drawing.Size(215, 114);
            this.G7_grpOrdenamiento.TabIndex = 6;
            this.G7_grpOrdenamiento.TabStop = false;
            this.G7_grpOrdenamiento.Text = "Ordenamiento";
            // 
            // G7_rbDescendente
            // 
            this.G7_rbDescendente.AutoSize = true;
            this.G7_rbDescendente.Location = new System.Drawing.Point(8, 63);
            this.G7_rbDescendente.Name = "G7_rbDescendente";
            this.G7_rbDescendente.Size = new System.Drawing.Size(107, 23);
            this.G7_rbDescendente.TabIndex = 2;
            this.G7_rbDescendente.Text = "Descendente";
            // 
            // G7_rbAscendente
            // 
            this.G7_rbAscendente.AutoSize = true;
            this.G7_rbAscendente.Checked = true;
            this.G7_rbAscendente.Location = new System.Drawing.Point(8, 30);
            this.G7_rbAscendente.Name = "G7_rbAscendente";
            this.G7_rbAscendente.Size = new System.Drawing.Size(99, 23);
            this.G7_rbAscendente.TabIndex = 1;
            this.G7_rbAscendente.TabStop = true;
            this.G7_rbAscendente.Text = "Ascendente";
            // 
            // G7_btnOrdenar
            // 
            this.G7_btnOrdenar.Location = new System.Drawing.Point(134, 41);
            this.G7_btnOrdenar.Name = "G7_btnOrdenar";
            this.G7_btnOrdenar.Size = new System.Drawing.Size(75, 41);
            this.G7_btnOrdenar.TabIndex = 0;
            this.G7_btnOrdenar.Text = "Ordenar";
            this.G7_btnOrdenar.Click += new System.EventHandler(this.G7_btnOrdenar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Image = global::G7_GestionInventario.Properties.Resources.icon_minimized;
            this.Minimizar.Location = new System.Drawing.Point(665, 0);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(34, 23);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizar.TabIndex = 0;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Image = global::G7_GestionInventario.Properties.Resources.icon_close;
            this.Cerrar.Location = new System.Drawing.Point(715, 0);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(31, 23);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cerrar.TabIndex = 1;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // G7_dgvProductos
            // 
            this.G7_dgvProductos.AllowUserToAddRows = false;
            this.G7_dgvProductos.AllowUserToDeleteRows = false;
            this.G7_dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.G7_dgvProductos.Location = new System.Drawing.Point(275, 166);
            this.G7_dgvProductos.Name = "G7_dgvProductos";
            this.G7_dgvProductos.ReadOnly = true;
            this.G7_dgvProductos.Size = new System.Drawing.Size(469, 343);
            this.G7_dgvProductos.TabIndex = 8;
            // 
            // G7_dgvStock
            // 
            this.G7_dgvStock.AllowUserToAddRows = false;
            this.G7_dgvStock.AllowUserToDeleteRows = false;
            this.G7_dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.G7_dgvStock.Location = new System.Drawing.Point(4, 48);
            this.G7_dgvStock.Name = "G7_dgvStock";
            this.G7_dgvStock.ReadOnly = true;
            this.G7_dgvStock.Size = new System.Drawing.Size(240, 206);
            this.G7_dgvStock.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::G7_GestionInventario.Properties.Resources.icon_calcular;
            this.pictureBox1.Location = new System.Drawing.Point(187, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.G7_btnCalcularStock_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::G7_GestionInventario.Properties.Resources.icon_registrar;
            this.pictureBox2.Location = new System.Drawing.Point(187, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.G7_btnRegistrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Liberation Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gestión de inventario ";
            // 
            // G7_frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(756, 522);
            this.Controls.Add(this.G7_dgvProductos);
            this.Controls.Add(this.G7_grpOrdenamiento);
            this.Controls.Add(this.G7_grpBusqueda);
            this.Controls.Add(this.G7_grpStock);
            this.Controls.Add(this.G7_grpRegistro);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "G7_frmPrincipal";
            this.Text = "G7_frmPrincipal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.G7_grpRegistro.ResumeLayout(false);
            this.G7_grpRegistro.PerformLayout();
            this.G7_grpStock.ResumeLayout(false);
            this.G7_grpBusqueda.ResumeLayout(false);
            this.G7_grpBusqueda.PerformLayout();
            this.G7_grpOrdenamiento.ResumeLayout(false);
            this.G7_grpOrdenamiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G7_dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G7_dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox G7_grpRegistro;
        private System.Windows.Forms.Button G7_btnRegistrar;
        private System.Windows.Forms.TextBox G7_txtCantidad;
        private System.Windows.Forms.TextBox G7_txtPrecio;
        private System.Windows.Forms.TextBox G7_txtCategoria;
        private System.Windows.Forms.TextBox G7_txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox G7_grpStock;
        private System.Windows.Forms.Button G7_btnCalcularStock;
        private System.Windows.Forms.GroupBox G7_grpBusqueda;
        private System.Windows.Forms.Button G7_btnBuscar;
        private System.Windows.Forms.TextBox G7_txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox G7_grpOrdenamiento;
        private System.Windows.Forms.RadioButton G7_rbDescendente;
        private System.Windows.Forms.RadioButton G7_rbAscendente;
        private System.Windows.Forms.Button G7_btnOrdenar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.DataGridView G7_dgvStock;
        private System.Windows.Forms.DataGridView G7_dgvProductos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}