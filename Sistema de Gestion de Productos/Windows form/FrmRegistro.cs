
using Sistema_de_Gestion_de_Productos_.Clases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sistema_de_Gestion_de_Productos_
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class FrmRegistro : Form
    {
        private readonly BaseDatosProductos datosProductos =
            new BaseDatosProductos();

        private readonly BaseDatosCategoria datosCategorias =
            new BaseDatosCategoria();

        private List<Categorias> listaCategorias =
            new List<Categorias>();

        public FrmRegistro()
        {
            InitializeComponent();

            this.Load += FrmRegistro_Load;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
        }

        // Cargar información inicial.
        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = false;
            label7.Visible = false;

            

            dgvProductos.ReadOnly = true;
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.MultiSelect = false;

            CargarCategorias();
            CargarProductos();
        }

        // Cargar categorías.
        private void CargarCategorias()
        {
            try
            {
                listaCategorias = datosCategorias.ObtenerCategorias();

                cmbCategoria.DataSource = null;
                cmbCategoria.DisplayMember = "Nombre";
                cmbCategoria.ValueMember = "Id_Categoria";
                cmbCategoria.DataSource = listaCategorias;

                cmbCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las categorías: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Cargar productos.
        private void CargarProductos()
        {
            try
            {
                dgvProductos.Rows.Clear();

                List<Producto> productos =
                    datosProductos.ObtenerProductos();

                foreach (Producto producto in productos)
                {
                    AgregarProductoTabla(producto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los productos: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Agregar producto a la tabla.
        private void AgregarProductoTabla(Producto producto)
        {
            string nombreCategoria =
                ObtenerNombreCategoria(producto.Id_Categoria);

            dgvProductos.Rows.Add(
                producto.Id_Producto,
                producto.Nombre,
                nombreCategoria,
                producto.Precio,
                producto.FechaRegistro.ToString("dd/MM/yyyy HH:mm"),
                producto.Cantidad,
                producto.ValorInventario
            );
        }

        // Obtener nombre de categoría.
        private string ObtenerNombreCategoria(int idCategoria)
        {
            foreach (Categorias categoria in listaCategorias)
            {
                if (categoria.Id_Categoria == idCategoria)
                {
                    return categoria.Nombre;
                }
            }

            return "Sin categoría";
        }

        // Registrar producto.
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarDatos())
                    return;

                string nombre = txtNombre.Text.Trim();

                List<Producto> encontrados =
                    datosProductos.BuscarProductos(nombre);

                foreach (Producto existente in encontrados)
                {
                    if (existente.Nombre.Trim().Equals(
                        nombre,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show(
                            "Este producto ya se encuentra registrado.",
                            "Producto duplicado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        txtNombre.Focus();
                        txtNombre.SelectAll();

                        return;
                    }
                }

                Producto producto = CrearProducto();

                datosProductos.RegistrarProducto(producto);

                MessageBox.Show(
                    "Producto registrado correctamente.",
                    "Registro exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarProductos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo registrar el producto: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Validar datos.
        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Digite el nombre del producto.");
                txtNombre.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrecioCosto.Text, out decimal precio)
                || precio <= 0)
            {
                MessageBox.Show(
                    "Digite un precio válido mayor que cero.");

                txtPrecioCosto.Focus();
                return false;
            }

            if (!int.TryParse(txtExistencias.Text, out int stock)
                || stock < 0)
            {
                MessageBox.Show(
                    "Digite una cantidad válida. No puede ser negativa.");

                txtExistencias.Focus();
                return false;
            }

            if (cmbCategoria.SelectedIndex == -1 ||
                cmbCategoria.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una categoría.");
                cmbCategoria.Focus();
                return false;
            }

            return true;
        }

        // Crear producto.
        private Producto CrearProducto()
        {
            string nombre = txtNombre.Text.Trim();
            decimal precio = Convert.ToDecimal(txtPrecioCosto.Text);
            int cantidad = Convert.ToInt32(txtExistencias.Text);
            int idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);

            return new Producto(nombre, precio, cantidad, idCategoria);
        }

        // Buscar productos.
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvProductos.Rows.Clear();

                List<Producto> productos =
                    datosProductos.BuscarProductos(txtBuscar.Text.Trim());

                foreach (Producto producto in productos)
                {
                    AgregarProductoTabla(producto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar productos: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Limpiar campos.
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPrecioCosto.Clear();
            txtExistencias.Clear();
            txtBuscar.Clear();

            cmbCategoria.SelectedIndex = -1;
            dgvProductos.ClearSelection();

            txtNombre.Focus();
        }

        // Regresar al menú.
        private void button1_Click(object sender, EventArgs e)
        {
            Funcion_de_Regreso_Boton.Regreso(this);
        }
    }
}
