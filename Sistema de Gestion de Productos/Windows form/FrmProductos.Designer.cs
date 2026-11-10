namespace Sistema_de_Gestion_de_Productos_
{
    partial class FrmProductos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cmbCategoria = new ComboBox();
            label6 = new Label();
            txtPrecioCosto = new TextBox();
            label8 = new Label();
            txtExistencias = new TextBox();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            label9 = new Label();
            txtBuscar = new TextBox();
            btnRetroceder = new Button();
            errorProvider1 = new ErrorProvider(components);
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dgvProductos = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            PrecioCosto = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Existencias = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(199, 27);
            label1.Name = "label1";
            label1.Size = new Size(383, 35);
            label1.TabIndex = 1;
            label1.Text = "Administracion de Productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(49, 80);
            label2.Name = "label2";
            label2.Size = new Size(541, 26);
            label2.TabIndex = 2;
            label2.Text = "Registro y mantenimiento de productos del inventario";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(49, 174);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(368, 27);
            txtNombre.TabIndex = 6;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(49, 130);
            label4.Name = "label4";
            label4.Size = new Size(225, 26);
            label4.TabIndex = 5;
            label4.Text = "Nombre del producto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(49, 221);
            label5.Name = "label5";
            label5.Size = new Size(114, 26);
            label5.TabIndex = 7;
            label5.Text = "Categoria:";
            label5.Click += label5_Click;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(49, 271);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(368, 28);
            cmbCategoria.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(49, 322);
            label6.Name = "label6";
            label6.Size = new Size(171, 26);
            label6.TabIndex = 9;
            label6.Text = "Precio de costo:";
            // 
            // txtPrecioCosto
            // 
            txtPrecioCosto.Location = new Point(49, 360);
            txtPrecioCosto.Name = "txtPrecioCosto";
            txtPrecioCosto.Size = new Size(193, 27);
            txtPrecioCosto.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(49, 404);
            label8.Name = "label8";
            label8.Size = new Size(131, 26);
            label8.TabIndex = 13;
            label8.Text = "Existencias:";
            // 
            // txtExistencias
            // 
            txtExistencias.Location = new Point(49, 459);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(281, 27);
            txtExistencias.TabIndex = 14;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(0, 0);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 25;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.RoyalBlue;
            btnModificar.ForeColor = SystemColors.ControlLightLight;
            btnModificar.Location = new Point(143, 520);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(131, 48);
            btnModificar.TabIndex = 16;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.RoyalBlue;
            btnEliminar.ForeColor = SystemColors.ControlLightLight;
            btnEliminar.Location = new Point(349, 520);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 48);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.RoyalBlue;
            btnLimpiar.ForeColor = SystemColors.ControlLightLight;
            btnLimpiar.Location = new Point(565, 520);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(131, 48);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(284, 612);
            label9.Name = "label9";
            label9.Size = new Size(236, 26);
            label9.TabIndex = 19;
            label9.Text = "Productos Registrados";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(284, 653);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(281, 27);
            txtBuscar.TabIndex = 20;
            // 
            // btnRetroceder
            // 
            btnRetroceder.Location = new Point(37, 22);
            btnRetroceder.Name = "btnRetroceder";
            btnRetroceder.Size = new Size(117, 40);
            btnRetroceder.TabIndex = 22;
            btnRetroceder.Text = "Retroceder";
            btnRetroceder.UseVisualStyleBackColor = true;
            btnRetroceder.Click += button1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(453, 322);
            label7.Name = "label7";
            label7.Size = new Size(227, 26);
            label7.TabIndex = 23;
            label7.Text = "Fecha de Adquisicion:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(453, 358);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(286, 27);
            dateTimePicker1.TabIndex = 24;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Categoria, PrecioCosto, PrecioVenta, Existencias, Total });
            dgvProductos.Location = new Point(-4, 723);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(902, 258);
            dgvProductos.TabIndex = 21;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.Width = 125;
            // 
            // PrecioCosto
            // 
            PrecioCosto.HeaderText = "Precio";
            PrecioCosto.MinimumWidth = 6;
            PrecioCosto.Name = "PrecioCosto";
            PrecioCosto.Width = 125;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Fecha de registro";
            PrecioVenta.MinimumWidth = 6;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.Width = 125;
            // 
            // Existencias
            // 
            Existencias.HeaderText = "Stock";
            Existencias.MinimumWidth = 6;
            Existencias.Name = "Existencias";
            Existencias.Width = 125;
            // 
            // Total
            // 
            Total.HeaderText = "Valor del inventario";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.Width = 125;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            errorProvider4.ContainerControl = this;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(891, 1055);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(btnRetroceder);
            Controls.Add(dgvProductos);
            Controls.Add(txtBuscar);
            Controls.Add(label9);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(txtExistencias);
            Controls.Add(label8);
            Controls.Add(txtPrecioCosto);
            Controls.Add(label6);
            Controls.Add(cmbCategoria);
            Controls.Add(label5);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmProductos";
            Text = "Productos";
            Load += FrmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Label label4;
        private Label label5;
        private ComboBox cmbCategoria;
        private Label label6;
        private TextBox txtPrecioCosto;
        private Label label8;
        private TextBox txtExistencias;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Label label9;
        private TextBox txtBuscar;
        private Button btnRetroceder;
        private ErrorProvider errorProvider1;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn PrecioCosto;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Existencias;
        private DataGridViewTextBoxColumn Total;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
    }
}
