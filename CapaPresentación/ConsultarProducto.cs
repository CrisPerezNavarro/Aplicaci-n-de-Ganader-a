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
    public partial class ConsultarProducto : Form
    {
        public ConsultarProducto()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultarProducto_Load(object sender, EventArgs e)
        {
            CargarGridExpediente();
        }
        private void CargarGridExpediente()
        {
            using (GestorMedicamento med = new GestorMedicamento())
            {

                dgvConsultar.DataSource = med.InventarioC();
                dgvConsultar.Columns["Nombre"].HeaderText = "Nombre";
                dgvConsultar.Columns["Contenido"].HeaderText = "Stock ";
                dgvConsultar.Columns["Tipo"].HeaderText = "Tipo";
                dgvConsultar.Columns["Temperatura"].HeaderText = "Temperatura";
                dgvConsultar.Columns["Fecha"].HeaderText = "Fecha";



            }
            using (GestorComplementos med = new GestorComplementos())
            {

                dgvComple.DataSource = med.InventarioC();
                dgvComple.Columns["Nombre"].HeaderText = "Nombre";
                dgvComple.Columns["Cantidad"].HeaderText = "Cantidad";



            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (GestorMedicamento med = new GestorMedicamento())
            {
                 med.Vencido(DateTime.Now.Date);
                MessageBox.Show("Se elimino los medicamentos vencidos","Infomacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            CargarGridExpediente();
        }
    }
}
