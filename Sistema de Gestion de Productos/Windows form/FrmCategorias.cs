
using System;
using System.Windows.Forms;
using Sistema_de_Gestion_de_Productos_.Clases;

namespace Sistema_de_Gestion_de_Productos_
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class FrmCategorias : Form
    {
        // Objeto para acceder a las operaciones de la base de datos.
        private BaseDatosCategoria baseDatosCategoria =
            new BaseDatosCategoria();

        // Guarda el ID de la categoría seleccionada.
        private int idCategoriaSeleccionada = 0;

        public FrmCategorias()
        {
            InitializeComponent();
        }

        // Se ejecuta cuando se abre el formulario.
        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        // Carga las categorías en el ListBox.
        private void CargarCategorias()
        {
            try
            {
                lstCategorias.DataSource = null;

                lstCategorias.DataSource =
                    baseDatosCategoria.ObtenerCategorias();

                lstCategorias.DisplayMember = "Nombre";
                lstCategorias.ValueMember = "Id_Categoria";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las categorías: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        // Detecta cuando se selecciona una categoría.
        private void lstCategorias_MouseClick(object sender, MouseEventArgs e)
        {
            int indice = lstCategorias.IndexFromPoint(e.Location);

            if (indice != ListBox.NoMatches)
            {
                Categorias categoria = (Categorias)lstCategorias.Items[indice];

                idCategoriaSeleccionada = categoria.Id_Categoria;
                txtNombre.Text = categoria.Nombre;
                txtDescripcion.Text = categoria.Descripcion;
            }
            else
            {
                lstCategorias.ClearSelected();
                LimpiarCampos();
            }
        }


        // Limpia los campos y quita la selección.
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            lstCategorias.ClearSelected();
            idCategoriaSeleccionada = 0;
        }

        // Guarda una categoría nueva.
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Debe ingresar el nombre de la categoría.");
                    txtNombre.Focus();
                    return;
                }

                Categorias categoria = new Categorias(
                    0,
                    txtNombre.Text.Trim(),
                    txtDescripcion.Text.Trim()
                );

                baseDatosCategoria.RegistrarCategoria(categoria);

                MessageBox.Show("Categoría registrada correctamente.");

                CargarCategorias();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al registrar la categoría: " + ex.Message
                );
            }
            
        }

        // Modifica la categoría seleccionada.
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idCategoriaSeleccionada == 0)
                {
                    MessageBox.Show("Seleccione una categoría para modificar.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Debe ingresar el nombre de la categoría.");
                    txtNombre.Focus();
                    return;
                }

                Categorias categoria = new Categorias(
                    idCategoriaSeleccionada,
                    txtNombre.Text.Trim(),
                    txtDescripcion.Text.Trim()
                );

                baseDatosCategoria.ModificarCategoria(categoria);

                MessageBox.Show("Categoría modificada correctamente.");

                CargarCategorias();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al modificar la categoría: " + ex.Message
                );
            }
        }

        // Elimina la categoría seleccionada.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idCategoriaSeleccionada == 0)
                {
                    MessageBox.Show("Seleccione una categoría para eliminar.");
                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de que desea eliminar esta categoría?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (respuesta == DialogResult.Yes)
                {
                    baseDatosCategoria.EliminarCategoria(
                        idCategoriaSeleccionada
                    );

                    MessageBox.Show("Categoría eliminada correctamente.");

                    CargarCategorias();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo eliminar la categoría: " + ex.Message
                );
            }
        }


        // Método reutilizable para limpiar los datos.
        private void LimpiarCampos()
        {
            idCategoriaSeleccionada = 0;

            txtNombre.Clear();
            txtDescripcion.Clear();

            txtNombre.Focus();
        }

        // Regresa al formulario anterior.
        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            Funcion_de_Regreso_Boton.Regreso(this);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
