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
    public partial class ProductoVendidoForm : Form
    {
        public ProductoVendidoForm()
        {
            InitializeComponent();
        }

        private void ProductoVendidoForm_Load(object sender, EventArgs e)
        {
            int idProductoVendido = Program.form1.id;
            if (idProductoVendido > 0)
            {
                ProductoVendido _productoVendido = ProductoVendidoBussiness.GetProductoVendido(idProductoVendido);
                txtIdProducto.Text = _productoVendido.IdProducto.ToString();
                txtStock.Text = _productoVendido.Stock.ToString();
                txtIdVenta.Text = _productoVendido.IdVenta.ToString();
                txtId.Text = _productoVendido.Id.ToString();
            }
            else
            {
                limpiar();
            }
        }
        private void limpiar()
        {
            txtIdProducto.Text = null;
            txtStock.Text = null;
            txtIdVenta.Text = null;
            txtId.Text = null;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
            Program.form1.CargaProductosVendidos();
            Program.form1.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idProducto = int.Parse(txtIdProducto.Text);
            int stock = int.Parse(txtStock.Text);
            int idVenta = int.Parse(txtIdVenta.Text);
            int idProductoVendido = Program.form1.id;

            if (idProductoVendido > 0)
            {
                ProductoVendido productoVendido = ProductoVendidoBussiness.GetProductoVendido(idProductoVendido);
                productoVendido.IdProducto = idProducto;
                productoVendido.Stock = stock;
                productoVendido.IdVenta = idVenta;
                ProductoVendidoBussiness.ModificarProductoVendido(productoVendido);

                MessageBox.Show("Se modifico el producto vendido");

            }
            else
            {
                ProductoVendido productoVendido = new ProductoVendido();
                productoVendido.IdProducto = idProducto;
                productoVendido.Stock = stock;
                productoVendido.IdVenta = idVenta;
                ProductoVendidoBussiness.CrearProductoVendido(productoVendido);

                MessageBox.Show("Se creo el nuevo producto vendido");
            }
            limpiar();
            this.Close();
            Program.form1.id = 0;
            Program.form1.CargaProductosVendidos();
            Program.form1.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;

            ProductoVendidoBussiness.EliminarProductoVendido(int.Parse(id));
            MessageBox.Show("Se borro el producto vendido");
            limpiar();
            Program.form1.id = 0;
            this.Close();
            Program.form1.CargaProductosVendidos();
            Program.form1.Show();
        }
    }
}
