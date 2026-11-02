namespace Sistema_de_Gestion_de_Productos_.Windows_form
{
    partial class Menu_Principal
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
            buttonCategoria = new Button();
            label1 = new Label();
            buttonSalir = new Button();
            buttonProductos = new Button();
            SuspendLayout();
            // 
            // buttonCategoria
            // 
            buttonCategoria.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCategoria.Location = new Point(414, 160);
            buttonCategoria.Name = "buttonCategoria";
            buttonCategoria.Size = new Size(349, 82);
            buttonCategoria.TabIndex = 1;
            buttonCategoria.Text = "Administrar Categorias";
            buttonCategoria.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(129, 27);
            label1.Name = "label1";
            label1.Size = new Size(527, 84);
            label1.TabIndex = 2;
            label1.Text = "Sistema de Gestion de Productos\r\n                   Menu.";
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.IndianRed;
            buttonSalir.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSalir.Location = new Point(329, 367);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(140, 52);
            buttonSalir.TabIndex = 3;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            // 
            // buttonProductos
            // 
            buttonProductos.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProductos.Location = new Point(42, 160);
            buttonProductos.Name = "buttonProductos";
            buttonProductos.Size = new Size(346, 82);
            buttonProductos.TabIndex = 4;
            buttonProductos.Text = "Administrar Productos";
            buttonProductos.UseVisualStyleBackColor = true;
            // 
            // Menu_Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(buttonProductos);
            Controls.Add(buttonSalir);
            Controls.Add(label1);
            Controls.Add(buttonCategoria);
            Name = "Menu_Principal";
            Text = "Menus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCategoria;
        private Label label1;
        private Button buttonSalir;
        private Button buttonProductos;
    }
}