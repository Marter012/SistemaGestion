using SistemaGestion;
using SistemaGestionBussiness;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUI
{
    public partial class ProductoForm : Form
    {
        public ProductoForm()
        {
            InitializeComponent();
        }

        private void ProductoForm_Load(object sender, EventArgs e)
        {
            int idProducto = Program.form1.id;
            if (idProducto > 0)
            {
                Producto _producto = ProductoBussiness.GetProducto(idProducto);
                txtDescripcion.Text = _producto.Descripcion;
                txtCosto.Text = _producto.Costo.ToString();
                txtPrecioVenta.Text = _producto.PrecioVenta.ToString();
                txtStock.Text = _producto.Stock.ToString();
                txtIdUsuario.Text = _producto.IdUsuario.ToString();
                txtId.Text = _producto.Id.ToString();
            }
            else
            {
                limpiar();
            }
        }
        private void limpiar()
        {
            txtDescripcion.Text = null;
            txtCosto.Text = null;
            txtPrecioVenta.Text = null;
            txtStock.Text = null;
            txtIdUsuario.Text = null;
            txtId.Text = null;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
            Program.form1.CargaProductos();
            Program.form1.Show();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text;
            double costo = double.Parse(txtCosto.Text);
            double precioVenta = double.Parse(txtPrecioVenta.Text);
            int stock = int.Parse(txtStock.Text);
            int idUsuario = int.Parse(txtIdUsuario.Text);
            int idProducto = Program.form1.id;

            if (idProducto > 0)
            {
                Producto producto = ProductoBussiness.GetProducto(idProducto);
                producto.Descripcion = descripcion;
                producto.Costo = costo;
                producto.PrecioVenta = precioVenta;
                producto.Stock = stock;
                producto.IdUsuario = idUsuario;
                ProductoBussiness.ModificarProducto(producto);

                MessageBox.Show("Se modifico el producto");

            }
            else
            {
                Producto producto = new Producto();
                producto.Descripcion = descripcion;
                producto.Costo = costo;
                producto.PrecioVenta = precioVenta;
                producto.Stock = stock;
                producto.IdUsuario = idUsuario;

                ProductoBussiness.CrearProducto(producto);

                MessageBox.Show("Se creo el nuevo producto");
            }
            limpiar();
            this.Close();
            Program.form1.id = 0;
            Program.form1.CargaProductos();
            Program.form1.Show();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;

            ProductoBussiness.EliminarProducto(int.Parse(id));
            MessageBox.Show("Se borro el Producto");
            limpiar();
            Program.form1.id = 0;
            this.Close();
            Program.form1.CargaProductos();
            Program.form1.Show();
        }
    }
}
