namespace SistemaGestionUI
{
    partial class VentaForm
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
            txtIdUsuario = new TextBox();
            txtComentarios = new TextBox();
            txtId = new TextBox();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnVolver = new Button();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(129, 166);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(100, 23);
            txtIdUsuario.TabIndex = 21;
            // 
            // txtComentarios
            // 
            txtComentarios.Location = new Point(129, 102);
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(100, 23);
            txtComentarios.TabIndex = 20;
            // 
            // txtId
            // 
            txtId.Location = new Point(129, 40);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 19;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(177, 264);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(95, 264);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(5, 264);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 16;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 169);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 15;
            label5.Text = "Id Usuario :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 105);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 14;
            label4.Text = "Comentarios : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 43);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 13;
            label1.Text = "Id :";
            // 
            // VentaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 326);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtComentarios);
            Controls.Add(txtId);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnVolver);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "VentaForm";
            Text = "VentaForm";
            Load += VentaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdUsuario;
        private TextBox txtComentarios;
        private TextBox txtId;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnVolver;
        private Label label5;
        private Label label4;
        private Label label1;
    }
}