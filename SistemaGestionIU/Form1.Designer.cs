namespace SistemaGestion
{
    partial class Form1
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
            dgvPrincipal = new DataGridView();
            btnAgregar = new Button();
            cbOptions = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).BeginInit();
            SuspendLayout();
            // 
            // dgvPrincipal
            // 
            dgvPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrincipal.Location = new Point(12, 47);
            dgvPrincipal.Name = "dgvPrincipal";
            dgvPrincipal.RowTemplate.Height = 25;
            dgvPrincipal.Size = new Size(637, 352);
            dgvPrincipal.TabIndex = 0;
            dgvPrincipal.CellContentClick += dataGridView1_CellClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(526, 17);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(104, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button1_Click;
            // 
            // cbOptions
            // 
            cbOptions.FormattingEnabled = true;
            cbOptions.Items.AddRange(new object[] { "Usuarios", "Productos", "Ventas", "Productos Vendidos" });
            cbOptions.Location = new Point(12, 12);
            cbOptions.Name = "cbOptions";
            cbOptions.Size = new Size(144, 23);
            cbOptions.TabIndex = 2;
            cbOptions.SelectedIndexChanged += cbOptions_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 411);
            Controls.Add(cbOptions);
            Controls.Add(btnAgregar);
            Controls.Add(dgvPrincipal);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPrincipal;
        private Button btnAgregar;
        private ComboBox cbOptions;
    }
}
