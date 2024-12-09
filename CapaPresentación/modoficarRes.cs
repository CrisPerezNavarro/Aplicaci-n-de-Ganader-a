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
    public partial class modoficarRes : Form
    {
        public modoficarRes()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (validar()) { 
            using (GestorRes res = new GestorRes())
            {
                res.ModificarRes(int.Parse(Codigo.Text),Estado.SelectedItem.ToString(), float.Parse(Peso.Text));
                
            }

            }
            Codigo.Text = string.Empty;
            Estado.Text = string.Empty;
            Peso.Text = string.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Boolean validar()
        {
            int entero;
            float flotante;

            if (!int.TryParse(Codigo.Text, out entero))
            {
                MessageBox.Show("El codigo no es válido.");
                return false;
            }

            // Validar flotante
            if (!float.TryParse(Peso.Text, out flotante))
            {
                MessageBox.Show("El peso no es válido.");
                return false;
            }

            return true;
        }
    }
}
