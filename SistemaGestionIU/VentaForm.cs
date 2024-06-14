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
    public partial class VentaForm : Form
    {
        public VentaForm()
        {
            InitializeComponent();
        }

        private void VentaForm_Load(object sender, EventArgs e)
        {
            int idVenta = Program.form1.id;
            if (idVenta > 0)
            {
                Venta _venta = VentaBussiness.GetVenta(idVenta);
                txtComentarios.Text = _venta.Comentarios;
                txtIdUsuario.Text = _venta.IdUsuario.ToString();
                txtId.Text = _venta.Id.ToString();
            }
            else
            {
                limpiar();
            }
        }
        private void limpiar()
        {
            txtComentarios.Text = null;
            txtIdUsuario.Text = null;
            txtId.Text = null;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
            Program.form1.CargaVentas();
            Program.form1.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string comentarios = txtComentarios.Text;
            int idUsuario = int.Parse(txtIdUsuario.Text);
            int idVenta = Program.form1.id;

            if (idVenta > 0)
            {
                Venta venta = VentaBussiness.GetVenta(idVenta);
                venta.Comentarios = comentarios;
                venta.IdUsuario = idUsuario;
                VentaBussiness.ModificaVenta(venta);

                MessageBox.Show("Se modifico la venta");

            }
            else
            {
                Venta venta = new Venta();
                venta.Comentarios = comentarios;
                venta.IdUsuario = idUsuario;
                VentaBussiness.CrearVenta(venta);

                MessageBox.Show("Se creo la nueva venta");
            }
            limpiar();
            this.Close();
            Program.form1.id = 0;
            Program.form1.CargaVentas();
            Program.form1.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;

            VentaBussiness.EliminarVenta(int.Parse(id));
            MessageBox.Show("Se borro la venta");
            limpiar();
            Program.form1.id = 0;
            this.Close();
            Program.form1.CargaVentas();
            Program.form1.Show();
        }
    }
}
