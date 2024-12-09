using CMJ.CapaIntegracion.Gestores;
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
    public partial class ConsultarTratamiento : Form
    {
        public ConsultarTratamiento()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void ConsultarTratamiento_Load(object sender, EventArgs e)
        {
            
            CargarGridExpediente();
        }

    
        private void CargarGridExpediente()
        {
            using (GestorMedico trat = new GestorMedico())
            {

                dgvConsultar.DataSource = trat.ListaVac();
                dgvConsultar.Columns["CodigoRes"].HeaderText = "Codigo de la Vaca";
                dgvConsultar.Columns["CodigoVac"].HeaderText = "Codigo del tratemiento";
                dgvConsultar.Columns["Nombre"].HeaderText = "Nombre del medicamento ";
                dgvConsultar.Columns["Facha"].HeaderText = "Fecha de aplicacion";
                dgvConsultar.Columns["Dosis"].HeaderText = " Dosis ";
                dgvConsultar.Columns["Diagnostico"].HeaderText = "Diagnostico";
                dgvConsultar.Columns["Detalle"].HeaderText = "Detalles";



            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            if (validar()) {
                Busqueda(int.Parse(Consultar.Text));
            }
        }
        public Boolean validar()
        {
            int entero;

            if (!int.TryParse(Consultar.Text, out entero))
            {
                MessageBox.Show("El codigo no es válido.");
                Consultar.Clear();
                return false;
            }

            return true;
        }
        public void Busqueda(int codigo)
        {
            using (GestorMedico trat = new GestorMedico())
            {

                dgvConsultar.DataSource = trat.ConsultarVac(codigo);
                dgvConsultar.Columns["CodigoRes"].HeaderText = "Codigo de la Vaca";
                dgvConsultar.Columns["CodigoVac"].HeaderText = "Codigo del tratemiento";
                dgvConsultar.Columns["Nombre"].HeaderText = "Nombre del medicamento ";
                dgvConsultar.Columns["Facha"].HeaderText = "Fecha de aplicacion";
                dgvConsultar.Columns["Dosis"].HeaderText = " Dosis ";
                dgvConsultar.Columns["Diagnostico"].HeaderText = "Diagnostico";
                dgvConsultar.Columns["Detalle"].HeaderText = "Detalles";



            }
            Consultar.Clear();
        }
    }
}
