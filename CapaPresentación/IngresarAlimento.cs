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
    public partial class IngresarAlimento : Form
    {
        public IngresarAlimento()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnIngresarAlimento_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                using (GestorComplementos comp = new GestorComplementos())
                {
                    comp.IngresarCompra(Producto.Text, float.Parse(Sacos.Text));
                }
            }
            Producto.Clear();
            Sacos.Clear();
        }
        public Boolean validar()
        {
            float entero;
            
            if (!float.TryParse(Sacos.Text, out entero))
            {
                MessageBox.Show("La cantidad de sacos no es válida.");
                
                return false;
            }

            return true;
        }

    }
}
