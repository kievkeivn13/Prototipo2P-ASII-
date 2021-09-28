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
    public partial class Alumnos : UserControl
    {
        public Alumnos()
        {
            InitializeComponent();
            funLimpiar();
            actualizarAlumno();
            
        }
        Controlador cn = new Controlador();
        string estado;

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtCarnetAlumno.Text == "" && txtNobreAlumno.Text == "" && txtDireccion.Text == "" && txtTelefono.Text == "" && txtCorreo.Text == "" && estado == "")
            {
                MessageBox.Show("Una o más casillas están vacías.");
            }
            else
            {
                cn.llamarInsertarAlumno(txtCarnetAlumno.Text, txtNobreAlumno.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text, estado);
                MessageBox.Show("Ingreso exitoso.");
                funLimpiar();
            }
            actualizarAlumno();
        }

        private void rbActivo_CheckedChanged(object sender, EventArgs e)
        {
            estado = "1";
        }

        private void rbInactivo_CheckedChanged(object sender, EventArgs e)
        {
            estado = "0";
        }
        private void funLimpiar()
        {
            txtCarnetAlumno.Text = "";
            txtNobreAlumno.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            estado = "";
            rbActivo.Checked = false;
            rbInactivo.Checked = false;
        }
        string tabla1 = "alumnos";
        public void actualizarAlumno()
        {
            DataTable dt = cn.llenarEmpleado(tabla1);
            dgvAlumno.DataSource = dt;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (txtCarnetAlumno.Text == "" && txtNobreAlumno.Text == "" && txtDireccion.Text == "" && txtTelefono.Text == "" && txtCorreo.Text == "" && estado == "")
            {
                MessageBox.Show("Debe llenar las casillas para modificar el registro.");
            }
            else
            {
                cn.llamarModificarAlumno(txtCarnetAlumno.Text, txtNobreAlumno.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text, estado);
                MessageBox.Show("Modificación exitosa.");
                funLimpiar();
            }
            actualizarAlumno();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (txtCarnetAlumno.Text == "" && txtNobreAlumno.Text == "" && txtDireccion.Text == "" && txtTelefono.Text == "" && txtCorreo.Text == "" && estado == "")
            {
                MessageBox.Show("No se puede buscar un registro para eliminar.");
            }
            else
            {
                cn.llamarEliminarAlumno(txtCarnetAlumno.Text);
                MessageBox.Show("Registro eliminado.");
                funLimpiar();
            }
            actualizarAlumno();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            funLimpiar();
        }

        private void dgvAlumno_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtCarnetAlumno.Text = dgvAlumno.CurrentRow.Cells[0].Value.ToString();
                txtNobreAlumno.Text = dgvAlumno.CurrentRow.Cells[1].Value.ToString();
                txtDireccion.Text = dgvAlumno.CurrentRow.Cells[2].Value.ToString();
                txtTelefono.Text = dgvAlumno.CurrentRow.Cells[3].Value.ToString();
                txtCorreo.Text = dgvAlumno.CurrentRow.Cells[4].Value.ToString();
                estado = dgvAlumno.CurrentRow.Cells[5].Value.ToString();

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
