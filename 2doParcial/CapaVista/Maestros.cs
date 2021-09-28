using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaContolador;
namespace CapaVista
{
    public partial class Maestros : UserControl
    {
        public Maestros()
        {
            InitializeComponent();
            actualizarmaestro();
            funLimpiar();
        }
        Controlador cn = new Controlador();
        string estado="";
        private void rbActivo_CheckedChanged_1(object sender, EventArgs e)
        {
            estado = "1";
        }

        private void rbInactivo_CheckedChanged_1(object sender, EventArgs e)
        {
            estado = "0";
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtCodigoMaestro.Text == "" && txtNombreMaestro.Text == "" && txtDireccion.Text == "" && txtTelefono.Text == "" && txtCorreo.Text == "" && estado == "")
            {
                MessageBox.Show("Una o más casillas están vacías.");
            }
            else
            {
                cn.llamarInsertarMaestro(txtCodigoMaestro.Text, txtNombreMaestro.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text, estado);
                MessageBox.Show("Ingreso exitoso.");
                funLimpiar();
            }
            actualizarmaestro();
        }
     

        private void btnModificar_Click(object sender, EventArgs e)
        { 
            if (txtCodigoMaestro.Text == "" && txtNombreMaestro.Text == "" && txtDireccion.Text == "" && txtTelefono.Text == "" && txtCorreo.Text == "" && estado == "")
            {
                MessageBox.Show("Debe llenar las casillas para modificar el registro.");
            }
            else
            {
                cn.llamarModificarMaestro(txtCodigoMaestro.Text, txtNombreMaestro.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text, estado);
                MessageBox.Show("Modificación exitosa.");
                funLimpiar();
            }
              actualizarmaestro();

        }
        string tabla1 = "maestros";
        public void actualizarmaestro()
        {
            DataTable dt = cn.llenarTabla(tabla1);
            dgvMaestro.DataSource = dt;
        }
        private void funLimpiar()
        {
            txtCodigoMaestro.Text = "";
            txtNombreMaestro.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            estado = "";
            rbActivo.Checked = false;
            rbInactivo.Checked = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigoMaestro.Text == "" && txtNombreMaestro.Text == "" && txtDireccion.Text == "" && txtTelefono.Text == "" && txtCorreo.Text == "" && estado == "")
            {
                MessageBox.Show("No se puede buscar un registro para eliminar.");
            }
            else
            {
                cn.llamarEliminarMaestro(txtCodigoMaestro.Text);
                MessageBox.Show("Registro eliminado.");
                funLimpiar();
            }
            actualizarmaestro();
        }

        private void dgvMaestro_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtCodigoMaestro.Text = dgvMaestro.CurrentRow.Cells[0].Value.ToString();
                txtNombreMaestro.Text = dgvMaestro.CurrentRow.Cells[1].Value.ToString();
                txtDireccion.Text = dgvMaestro.CurrentRow.Cells[2].Value.ToString();
                txtTelefono.Text = dgvMaestro.CurrentRow.Cells[3].Value.ToString();
                txtCorreo.Text = dgvMaestro.CurrentRow.Cells[4].Value.ToString();
                estado = dgvMaestro.CurrentRow.Cells[5].Value.ToString();

                if (estado == "1")
                {
                    rbActivo.Checked = true;
                    rbInactivo.Checked = false;
                }
                else
                {
                    rbActivo.Checked = false;
                    rbInactivo.Checked = true;
                }
            }
            catch
            {

            }
        }

       
    }
}
