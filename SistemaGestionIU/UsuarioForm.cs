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
    public partial class UsuarioForm : Form
    {
        public UsuarioForm()
        {
            InitializeComponent();
        }

        private void UsuarioForm_Load(object sender, EventArgs e)
        {
            int idUsuario = Program.form1.id;
            if (idUsuario > 0)
            {
                Usuario _usuario = UsuarioBussiness.GetUsuario(idUsuario);
                txtNombre.Text = _usuario.Nombre;
                txtApellido.Text = _usuario.NombreUsuario;
                txtNombreUsuario.Text = _usuario.NombreUsuario;
                txtEmail.Text = _usuario.Email;
                txtContraseña.Text = _usuario.Contraseña;
                txtId.Text = _usuario.Id.ToString();
            }
            else
            {
                limpiar();
            }
        }

        private void limpiar()
        {
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtEmail.Text = null;
            txtContraseña.Text = null;
            txtId.Text = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
            Program.form1.CargaUsuarios();
            Program.form1.Show();
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string nombreUsuario = txtNombreUsuario.Text;
            string email = txtEmail.Text;
            string contraseña = txtContraseña.Text;
            int idUsuario = Program.form1.id;

            if (idUsuario > 0)
            {
                Usuario usuario = UsuarioBussiness.GetUsuario(idUsuario);
                usuario.Nombre =   nombre;
                usuario.Apellido = apellido;
                usuario.NombreUsuario = nombreUsuario;
                usuario.Email = email;
                usuario.Contraseña = contraseña;
                UsuarioBussiness.ModificarUsuario(usuario);

                MessageBox.Show("Se modifico el Cliente");

            }
            else
            {
                Usuario usuario = new Usuario();
                usuario.Nombre = nombre;
                usuario.Apellido = apellido;
                usuario.NombreUsuario = nombreUsuario;
                usuario.Email = email;
                usuario.Contraseña = contraseña;

                UsuarioBussiness.AgregarUsuario(usuario);

                MessageBox.Show("Se creo el nuevo Cliente");
            }
            limpiar();
            this.Close();
            Program.form1.id = 0;
            Program.form1.CargaUsuarios();
            Program.form1.Show();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;

            UsuarioBussiness.EliminarUsuario(int.Parse(id));
            MessageBox.Show("Se borro el Cliente");
            limpiar();
            Program.form1.id = 0;
            this.Close();
            Program.form1.CargaUsuarios();
            Program.form1.Show();
        }
    }
}
