namespace Sistema_de_Gestion_de_Productos_
{
    partial class FrmCategorias
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
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtDescripcion = new TextBox();
            label4 = new Label();
            lstCategorias = new ListBox();
            label5 = new Label();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            btnRetroceder = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(196, 33);
            label1.Name = "label1";
            label1.Size = new Size(398, 35);
            label1.TabIndex = 30;
            label1.Text = "Administración de Categorías ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(113, 78);
            label2.Name = "label2";
            label2.Size = new Size(575, 26);
            label2.TabIndex = 31;
            label2.Text = "Registro y mantenimiento de las categorías de productos";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(196, 169);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(368, 27);
            txtNombre.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(196, 130);
            label3.Name = "label3";
            label3.Size = new Size(249, 26);
            label3.TabIndex = 32;
            label3.Text = "Nombre de la categoria:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(196, 260);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(368, 27);
            txtDescripcion.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(196, 221);
            label4.Name = "label4";
            label4.Size = new Size(134, 26);
            label4.TabIndex = 34;
            label4.Text = "Descripcion:";
            // 
            // lstCategorias
            // 
            lstCategorias.FormattingEnabled = true;
            lstCategorias.Location = new Point(196, 378);
            lstCategorias.Name = "lstCategorias";
            lstCategorias.Size = new Size(368, 284);
            lstCategorias.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(196, 320);
            label5.Name = "label5";
            label5.Size = new Size(249, 26);
            label5.TabIndex = 37;
            label5.Text = "Categorias Registradas:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.RoyalBlue;
            btnLimpiar.ForeColor = SystemColors.ControlLightLight;
            btnLimpiar.Location = new Point(196, 755);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(131, 48);
            btnLimpiar.TabIndex = 42;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.RoyalBlue;
            btnEliminar.ForeColor = SystemColors.ControlLightLight;
            btnEliminar.Location = new Point(433, 755);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 48);
            btnEliminar.TabIndex = 41;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.RoyalBlue;
            btnModificar.ForeColor = SystemColors.ControlLightLight;
            btnModificar.Location = new Point(433, 685);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(131, 48);
            btnModificar.TabIndex = 40;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.RoyalBlue;
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(196, 685);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 48);
            btnGuardar.TabIndex = 39;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnRetroceder
            // 
            btnRetroceder.Location = new Point(12, 12);
            btnRetroceder.Name = "btnRetroceder";
            btnRetroceder.Size = new Size(117, 40);
            btnRetroceder.TabIndex = 46;
            btnRetroceder.Text = "Retroceder";
            btnRetroceder.UseVisualStyleBackColor = true;
            btnRetroceder.Click += btnRetroceder_Click;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(951, 823);
            Controls.Add(btnRetroceder);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(lstCategorias);
            Controls.Add(txtDescripcion);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmCategorias";
            Text = "Categorías";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtDescripcion;
        private Label label4;
        private ListBox lstCategorias;
        private Label label5;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private Button btnRetroceder;
    }
}
