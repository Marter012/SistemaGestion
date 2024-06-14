namespace SistemaGestionUI
{
    partial class UsuarioForm
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
            label4 = new Label();
            label5 = new Label();
            btnVolver = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtContraseña = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            txtApellido = new TextBox();
            label3 = new Label();
            txtNombreUsuario = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 15);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 0;
            label1.Text = "Id :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 56);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 3;
            label4.Text = "Nombre : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 233);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 4;
            label5.Text = "Contraseña :";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 279);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(102, 279);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(184, 279);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(149, 7);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(149, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 9;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(149, 225);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(100, 23);
            txtContraseña.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 185);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Email :";
            label2.Click += label2_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(149, 177);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 11;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(149, 98);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 103);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido :";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(149, 136);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(100, 23);
            txtNombreUsuario.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 141);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 13;
            label6.Text = "Nombre Usuario :";
            // 
            // UsuarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 326);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label6);
            Controls.Add(txtContraseña);
            Controls.Add(txtEmail);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnVolver);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UsuarioForm";
            Text = "UsuarioForm";
            Load += UsuarioForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label5;
        private Button btnVolver;
        private Button btnGuardar;
        private Button btnEliminar;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtContraseña;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtNombreUsuario;
        private Label label6;
    }
}