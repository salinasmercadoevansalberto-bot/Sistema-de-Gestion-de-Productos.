
using Sistema_de_Gestion_de_Productos_.Clases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sistema_de_Gestion_de_Productos_
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class FrmProductos : Form
    {
        private readonly BaseDatosProductos datosProductos = new BaseDatosProductos();
        private readonly BaseDatosCategoria datosCategorias = new BaseDatosCategoria();

        private List<Categorias> listaCategorias = new List<Categorias>();

        public FrmProductos()
        {
            InitializeComponent();

            // Evento para buscar mientras se escribe.
            txtBuscar.TextChanged += txtBuscar_TextChanged;
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            // La fecha se registra automáticamente en SQL Server.
            dateTimePicker1.Visible = false;
            label7.Visible = false;

            

            CargarCategorias();
            CargarProductos();
        }

        // Cargar las categorías en el ComboBox.
        private void CargarCategorias()
        {
            try
            {
                listaCategorias = datosCategorias.ObtenerCategorias();

                cmbCategoria.DataSource = null;
                cmbCategoria.DataSource = listaCategorias;
                cmbCategoria.DisplayMember = "Nombre";
                cmbCategoria.ValueMember = "Id_Categoria";
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

        // Cargar los productos en el DataGridView.
        private void CargarProductos()
        {
            try
            {
                dgvProductos.Rows.Clear();

                List<Producto> productos = datosProductos.ObtenerProductos();

                foreach (Producto producto in productos)
                {
                    string nombreCategoria = "Sin categoría";

                    foreach (Categorias categoria in listaCategorias)
                    {
                        if (categoria.Id_Categoria == producto.Id_Categoria)
                        {
                            nombreCategoria = categoria.Nombre;
                            break;
                        }
                    }

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

        // Registrar un producto.
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarDatos())
                    return;

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

        // Modificar un producto seleccionado.
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un producto.");
                    return;
                }

                if (!ValidarDatos())
                    return;

                int idProducto = Convert.ToInt32(
                    dgvProductos.CurrentRow.Cells["Codigo"].Value);

                Producto producto = CrearProducto();
                producto.Id_Producto = idProducto;

                datosProductos.ModificarProducto(producto);

                MessageBox.Show(
                    "Producto modificado correctamente.",
                    "Modificación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarProductos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo modificar el producto: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Eliminar un producto seleccionado.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un producto.");
                    return;
                }

                int idProducto = Convert.ToInt32(
                    dgvProductos.CurrentRow.Cells["Codigo"].Value);

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar este producto?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    datosProductos.EliminarProducto(idProducto);

                    MessageBox.Show("Producto eliminado correctamente.");

                    CargarProductos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo eliminar el producto: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Validar los datos ingresados.
        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Digite el nombre del producto.");
                txtNombre.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrecioCosto.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Digite un precio válido mayor que cero.");
                txtPrecioCosto.Focus();
                return false;
            }

            if (!int.TryParse(txtExistencias.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Digite una cantidad válida. No puede ser negativa.");
                txtExistencias.Focus();
                return false;
            }

            if (cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una categoría.");
                cmbCategoria.Focus();
                return false;
            }

            return true;
        }

        // Crear el objeto Producto con los datos del formulario.
        private Producto CrearProducto()
        {
            string nombre = txtNombre.Text.Trim();
            decimal precio = Convert.ToDecimal(txtPrecioCosto.Text);
            int cantidad = Convert.ToInt32(txtExistencias.Text);
            int idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);

            return new Producto(nombre, precio, cantidad, idCategoria);
        }

        // Seleccionar un producto desde el DataGridView.
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

            txtNombre.Text = fila.Cells["Nombre"].Value?.ToString();
            txtPrecioCosto.Text = fila.Cells["PrecioCosto"].Value?.ToString();
            txtExistencias.Text = fila.Cells["Existencias"].Value?.ToString();

            string nombreCategoria = fila.Cells["Categoria"].Value?.ToString();

            foreach (Categorias categoria in listaCategorias)
            {
                if (categoria.Nombre == nombreCategoria)
                {
                    cmbCategoria.SelectedValue = categoria.Id_Categoria;
                    break;
                }
            }
        }

        // Buscar productos por nombre.
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvProductos.Rows.Clear();

                List<Producto> productos =
                    datosProductos.BuscarProductos(txtBuscar.Text.Trim());

                foreach (Producto producto in productos)
                {
                    string nombreCategoria = "Sin categoría";

                    foreach (Categorias categoria in listaCategorias)
                    {
                        if (categoria.Id_Categoria == producto.Id_Categoria)
                        {
                            nombreCategoria = categoria.Nombre;
                            break;
                        }
                    }

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

        // Limpiar los campos del formulario.
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

        private void button1_Click(object sender, EventArgs e)
        {
            Funcion_de_Regreso_Boton.Regreso(this);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Sin acción asignada.
        }
    }
}
