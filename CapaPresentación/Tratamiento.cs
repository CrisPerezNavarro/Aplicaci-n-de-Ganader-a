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
    public partial class Tratamiento : Form
    {
        public Tratamiento()
        {
            InitializeComponent();
        }

        private void CodigoRes_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                using (GestorMedico medico = new GestorMedico())
                {
                    medico.IngresarVac(int.Parse(cbCodigo.Text), Medicamento.Text, DTfecha.Value, Dosis.Text, Diagnostico.Text, Detalle.Text);

                }
            }
            Medicamento.Clear();
            Dosis.Clear();
            Diagnostico.Clear();
            Detalle.Clear();
            CargarCombo();

        }
        public Boolean validar()
        {
            int entero;
            

            if (!int.TryParse(cbCodigo.Text, out entero))
            {
                MessageBox.Show("El Codigo no es válido.");
                return false;
            }


            return true;
        }

        private void CargarCombo()
        {

            using (GestorRes res = new GestorRes())
            {

                cbCodigo.DataSource = res.ConsultarResE();
                cbCodigo.ValueMember = "Codigo";
                cbCodigo.DisplayMember = "Codigo";
            }
        }

        private void Tratamiento_Load(object sender, EventArgs e)
        {
            CargarCombo();
            cbCodigo.SelectedIndex = 0;

        }
    }
}
