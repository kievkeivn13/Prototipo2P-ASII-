using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            frmAlumno newMDIChild = new frmAlumno();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void btnMaestros_Click(object sender, EventArgs e)
        {
            frmMaestros newMDIChild = new frmMaestros();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }
    }
}
