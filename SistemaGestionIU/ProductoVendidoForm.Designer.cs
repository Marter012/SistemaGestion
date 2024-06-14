namespace SistemaGestionUI
{
    partial class ProductoVendidoForm
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
            txtIdVenta = new TextBox();
            txtStock = new TextBox();
            txtIdProducto = new TextBox();
            txtId = new TextBox();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnVolver = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(130, 178);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(100, 23);
            txtIdVenta.TabIndex = 22;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(130, 132);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 21;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(130, 82);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(100, 23);
            txtIdProducto.TabIndex = 20;
            // 
            // txtId
            // 
            txtId.Location = new Point(130, 41);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 19;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(178, 275);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(96, 275);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(6, 275);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 16;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 85);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 15;
            label4.Text = "id Producto : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 132);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 14;
            label3.Text = "Stock :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 181);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 13;
            label2.Text = "Id Venta :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 44);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 12;
            label1.Text = "Id :";
            // 
            // ProductoVendidoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 338);
            Controls.Add(txtIdVenta);
            Controls.Add(txtStock);
            Controls.Add(txtIdProducto);
            Controls.Add(txtId);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnVolver);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductoVendidoForm";
            Text = "ProductoVendidoForm";
            Load += ProductoVendidoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdVenta;
        private TextBox txtStock;
        private TextBox txtIdProducto;
        private TextBox txtId;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnVolver;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}