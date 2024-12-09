using CapaPresentación;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Vacuno
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnVolver.Visible = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnVolver.Visible=false;
            btnMaximizar.Visible=true;
        }

        private void btnMiminizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void abrirForm(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;

            // Centrar el formulario hijo en el panel contenedor
            int x = (this.panelContenedor.Width - fh.Width) / 2;
            int y = (this.panelContenedor.Height - fh.Height) / 2;
            fh.Location = this.panelContenedor.PointToScreen(new Point(x, y));

            fh.Show();
        }




        private void btnIngresarRes_Click(object sender, EventArgs e)
        {
            abrirForm(new RegistroVacuno());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            abrirForm(new modoficarRes());
        }

        private void btnEliminarRes_Click(object sender, EventArgs e)
        {
            abrirForm(new EliminarRes());
        }

        private void btnConsultarRes_Click(object sender, EventArgs e)
        {
            abrirForm(new ConsultarRes());
        }


        private void btnregistroTratamiento_Click(object sender, EventArgs e)
        {
            abrirForm(new Tratamiento());
        }

        private void btnConTratamiento_Click(object sender, EventArgs e)
        {
            abrirForm(new ConsultarTratamiento());
        }

        private void btnIngresarVacuna_Click(object sender, EventArgs e)
        {
            abrirForm(new IngresarVacunas());
        }

        private void btnVacunaUsada_Click(object sender, EventArgs e)
        {
            abrirForm(new VacunaUsada());
        }

        private void btnIngresarAlimento_Click(object sender, EventArgs e)
        {
            abrirForm(new IngresarAlimento());
        }

        private void btnGastoAlimento_Click(object sender, EventArgs e)
        {
            abrirForm(new GastoAlimento());  
        }

        private void btnConsultarProducto_Click(object sender, EventArgs e)
        {
            abrirForm(new ConsultarProducto());
        }

        private void btnGenerarInforma_Click(object sender, EventArgs e)
        {
            abrirForm(new Reporte());
        }
    }
}
