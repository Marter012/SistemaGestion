namespace SistemaGestionUI
{
    partial class ProductoForm
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
            txtPrecioVenta = new TextBox();
            txtCosto = new TextBox();
            txtDescripcion = new TextBox();
            txtId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtStock = new TextBox();
            label6 = new Label();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(125, 226);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(100, 23);
            txtIdUsuario.TabIndex = 22;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(125, 147);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(100, 23);
            txtPrecioVenta.TabIndex = 21;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(125, 107);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(100, 23);
            txtCosto.TabIndex = 20;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(125, 68);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 19;
            // 
            // txtId
            // 
            txtId.Location = new Point(125, 27);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 229);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 17;
            label5.Text = "Id Usuario :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 71);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 16;
            label4.Text = "Descripcion :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 107);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 15;
            label3.Text = "Costo :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 150);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 14;
            label2.Text = "Precio Venta :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 30);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 13;
            label1.Text = "Id :";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(125, 184);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 187);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 23;
            label6.Text = "Stock :";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(180, 271);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 27;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(98, 271);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 26;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(8, 271);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 25;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // ProductoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 317);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnVolver);
            Controls.Add(txtStock);
            Controls.Add(label6);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtCosto);
            Controls.Add(txtDescripcion);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductoForm";
            Text = "ProductoForm";
            Load += ProductoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdUsuario;
        private TextBox txtPrecioVenta;
        private TextBox txtCosto;
        private TextBox txtDescripcion;
        private TextBox txtId;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtStock;
        private Label label6;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnVolver;
    }
}