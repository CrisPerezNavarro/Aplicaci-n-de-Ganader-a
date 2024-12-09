using CMJ.CapaIntegracion.Gestores;
using System;
using System.Collections;
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
    public partial class VacunaUsada : Form
    {
        public VacunaUsada()
        {
            InitializeComponent();
        }

        private void VacunaUsada_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnIngresarGasto_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                using (GestorMedicamento medi = new GestorMedicamento())
                {
                    medi.IngresarGastoM(Lista.Text, float.Parse(CantidadUsada.Text), DateTime.Parse(FechaV.Text));
                }
            }
            CantidadUsada.Clear();
            CargarCombo();

        }

        public Boolean validar()
        {
            float entero;

            if (!float.TryParse(CantidadUsada.Text, out entero))
            {
                MessageBox.Show("La cantidad no es válida.");
                CantidadUsada.Clear();
                return false;
            }

            return true;
        }
        private void CargarCombo()
        {

            using (GestorMedicamento  med= new GestorMedicamento())
            {

                Lista.DataSource = med.InventarioC();
                Lista.ValueMember = "Nombre";
                Lista.DisplayMember = "Nombre";
                FechaV.DataSource = med.InventarioC();
                FechaV.ValueMember = "Fecha";
                FechaV.DisplayMember = "Fecha";
                
            }
        }
    }
}
