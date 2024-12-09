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
    public partial class IngresarVacunas : Form
    {
        public IngresarVacunas()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnIngresarVacuna_Click(object sender, EventArgs e)
        {
            if (validar()) {
                using (GestorMedicamento medica = new GestorMedicamento())
                {
                    medica.IngresarCompraM(Medicamento.Text, float.Parse(Contenido.Text), Tipo.Text, int.Parse(Temperatura.Text), Fecha.Value);
                } }
            Medicamento.Clear();
            Contenido.Clear();
            Temperatura.Clear();

        }
        public Boolean validar()
        {
            float x;

            if (!float.TryParse(Contenido.Text, out x))
            {
                MessageBox.Show("El contenido no es válido.");
                Contenido.Clear();
                return false;
            }

            return true;
        }
    }
}
