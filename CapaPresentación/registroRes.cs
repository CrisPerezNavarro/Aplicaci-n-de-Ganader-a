using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMJ.CapaIntegracion.Gestores;

namespace Registro_Vacuno
{
    public partial class RegistroVacuno : Form
    {
        public RegistroVacuno()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if (Valida())
            {

                #region
                GestorRes res = new GestorRes();
                res.IngresarRes(int.Parse(CodigoRes.Text), Estado.SelectedItem.ToString(), Raza.Text, (Fecha.Value), float.Parse(Peso.Text), Sexo.Text);

                CodigoRes.Text = string.Empty;
                Estado.Text = string.Empty;
                Fecha.Text = string.Empty;
                Sexo.Text = string.Empty;
                Peso.Text = string.Empty;
                Raza.Text = string.Empty;
                #endregion
            }
        }

        private Boolean Valida()
        {
            int entero;
            float flotante;

            
            // Validar entero
            if (!int.TryParse(CodigoRes.Text, out entero))
            {
                MessageBox.Show("El Codigo no es válido.");
                return false;
            }

            // Validar flotante
            if (!float.TryParse(Peso.Text, out flotante))
            {
                MessageBox.Show("El Peso no es válido.");
                return false;
            }

            // Si se llega a este punto, todos los valores son válidos
            // Puedes realizar la lógica adicional o procesar los datos como desees
            MessageBox.Show("Todos los valores son válidos.");
            
                return true; }
        

    }
}
