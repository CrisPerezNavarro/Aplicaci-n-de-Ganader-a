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
    public partial class GastoAlimento : Form
    {
        public GastoAlimento()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlimentoUsado_Click(object sender, EventArgs e)
        {
            if (validar()) {
                using (GestorComplementos com = new GestorComplementos())
                {
                    com.IngresarGasto(Producto.Text, float.Parse(Cantidad.Text));
                }
            }
            Cantidad.Clear();
            CargarCombo();

        }
        public Boolean validar()
        {
            float e;

            if (!float.TryParse(Cantidad.Text, out e))
            {
                MessageBox.Show("La cantida es un valor numerico.");
                Cantidad.Clear();
                return false;
            }

            return true;
        }
        private void GastoAlimento_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }
        private void CargarCombo()
{

    using (GestorComplementos med = new GestorComplementos())
    {

        Producto.DataSource = med.InventarioC();
        Producto.ValueMember = "Nombre";
        Producto.DisplayMember = "Nombre";
        

    }
}
    }
}
