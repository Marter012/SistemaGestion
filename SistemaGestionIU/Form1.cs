using SistemaGestionBussiness;
using SistemaGestionEntities;
using SistemaGestionUI;

namespace SistemaGestion
{
    public partial class Form1 : Form
    {
        public int id;
        public string datosCargados;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargaUsuarios();
        }

        public void CargaUsuarios()
        {
            cbOptions.SelectedIndex = 0;

            List<Usuario> usuarios = UsuarioBussiness.GetUsuarios();

            usuarios.OrderBy(b => b.Id).ToList();

            dgvPrincipal.AutoGenerateColumns = true;
            dgvPrincipal.DataSource = usuarios;

            datosCargados = "Usuarios";
        }
        public void CargaProductos()
        {
            cbOptions.SelectedIndex = 1;

            List<Producto> productos = ProductoBussiness.GetProductos();

            productos.OrderBy(b => b.Id).ToList();

            dgvPrincipal.AutoGenerateColumns = true;
            dgvPrincipal.DataSource = productos;

            datosCargados = "Productos";
        }
        public void CargaVentas()
        {
            cbOptions.SelectedIndex = 2;

            List<Venta> ventas = VentaBussiness.GetVentas();

            ventas.OrderBy(b => b.Id).ToList();

            dgvPrincipal.AutoGenerateColumns = true;
            dgvPrincipal.DataSource = ventas;

            datosCargados = "Ventas";
        }

        public void CargaProductosVendidos()
        {
            cbOptions.SelectedIndex = 3;

            List<ProductoVendido> productoVendido = ProductoVendidoBussiness.GetProductoVendidos();

            productoVendido.OrderBy(b => b.Id).ToList();

            dgvPrincipal.AutoGenerateColumns = true;
            dgvPrincipal.DataSource = productoVendido;

            datosCargados = "Productos Vendidos";
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int filaSeleccionada = (int)e.RowIndex;
                id = int.Parse(dgvPrincipal[0, filaSeleccionada].Value.ToString());
            }


            if (datosCargados == "Usuarios")
            {
                UsuarioForm usuarioForm = new UsuarioForm();
                Program.form1.Hide();
                usuarioForm.Show();
            }
            else if (datosCargados == "Productos")
            {
                ProductoForm productoForm = new ProductoForm();
                Program.form1.Hide();
                productoForm.Show();
            }
            else if (datosCargados == "Ventas")
            {
                VentaForm ventaForm = new VentaForm();
                Program.form1.Hide();
                ventaForm.Show();
            }
            else if (datosCargados == "Productos Vendidos")
            {
                ProductoVendidoForm productoVendidoForm = new ProductoVendidoForm();
                Program.form1.Hide();
                productoVendidoForm.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (datosCargados == "Usuarios")
            {
                UsuarioForm usuarioForm = new UsuarioForm();
                Program.form1.Hide();
                usuarioForm.Show();
            }
            else if(datosCargados == "Productos")
            {
                ProductoForm productoForm = new ProductoForm();
                Program.form1.Hide();
                productoForm.Show();
            }
            else if (datosCargados == "Ventas")
            {
                VentaForm ventaForm = new VentaForm();
                Program.form1.Hide();
                ventaForm.Show();
            }
            else if (datosCargados == "Productos Vendidos")
            {
                ProductoVendidoForm productoVendidoForm = new ProductoVendidoForm();
                Program.form1.Hide();
                productoVendidoForm.Show();
            }
        }

        private void cbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectValue = cbOptions.SelectedItem.ToString();

            switch (selectValue)
            {
                case "Usuarios":
                    CargaUsuarios();
                    break;
                case "Productos":
                    CargaProductos();
                    break;
                case "Ventas":
                    CargaVentas();
                    break;
                case "Productos Vendidos":
                    CargaProductosVendidos();
                    break;
                default:
                    break;
            }
        }
    }
}
