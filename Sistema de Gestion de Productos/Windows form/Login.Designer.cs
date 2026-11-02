namespace Sistema_de_Gestion_de_Productos_
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonIniciar_secion = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxUsuario = new TextBox();
            label3 = new Label();
            textBoxContraseña = new TextBox();
            SuspendLayout();
            // 
            // buttonIniciar_secion
            // 
            buttonIniciar_secion.BackColor = Color.AliceBlue;
            buttonIniciar_secion.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonIniciar_secion.Location = new Point(293, 349);
            buttonIniciar_secion.Name = "buttonIniciar_secion";
            buttonIniciar_secion.Size = new Size(239, 40);
            buttonIniciar_secion.TabIndex = 0;
            buttonIniciar_secion.Text = "Iniciar Secion";
            buttonIniciar_secion.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(143, 9);
            label1.Name = "label1";
            label1.Size = new Size(527, 42);
            label1.TabIndex = 1;
            label1.Text = "Sistema de Gestion de Productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(214, 74);
            label2.Name = "label2";
            label2.Size = new Size(241, 32);
            label2.TabIndex = 2;
            label2.Text = "Ingrese se Usuario:";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(214, 125);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(415, 27);
            textBoxUsuario.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(214, 170);
            label3.Name = "label3";
            label3.Size = new Size(284, 32);
            label3.TabIndex = 4;
            label3.Text = "Ingrese se Contraseña:";
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(212, 215);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(417, 27);
            textBoxContraseña.TabIndex = 5;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxContraseña);
            Controls.Add(label3);
            Controls.Add(textBoxUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonIniciar_secion);
            ForeColor = Color.Black;
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonIniciar_secion;
        private Label label1;
        private Label label2;
        private TextBox textBoxUsuario;
        private Label label3;
        private TextBox textBoxContraseña;
    }
}
