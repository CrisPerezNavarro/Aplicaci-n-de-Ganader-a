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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Registro_Vacuno
{
    public partial class ConsultarRes : Form
    {
        public ConsultarRes()
        {
            InitializeComponent();

        }
        private void ConsultarRes_Load(object sender, EventArgs e)
        {
            CargarGridExpediente();
            Modo.SelectedIndex = 0;
        }
       
      
        private void CargarGridExpediente()
        {
            using (GestorRes res = new GestorRes())
            {

                dgvConsultar.DataSource = res.ConsultarResE();
                dgvConsultar.Columns["Codigo"].HeaderText = "Codigo de la Vaca";
                dgvConsultar.Columns["Estado"].HeaderText = "Estado ";
                dgvConsultar.Columns["Raza"].HeaderText = "Raza";
                dgvConsultar.Columns["FechaNac"].HeaderText = "Fecha de Nacimiento";
                dgvConsultar.Columns["Peso"].HeaderText = "Peso Kg";
                dgvConsultar.Columns["Sexo"].HeaderText = "Sexo";
                


            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

       

        private void Buscar (object sender, EventArgs e)
        {
            using (GestorRes res = new GestorRes())
            {

                if (Modo.SelectedItem.ToString() == "Especifico")
                {
                    if (int.TryParse(CodigoR.Text, out int resultado) && validar())
                    {
                        dgvConsultar.DataSource = res.ConsultarRes(int.Parse(CodigoR.Text));
                        dgvConsultar.Columns["Codigo"].HeaderText = "Codigo de la Vaca";
                        dgvConsultar.Columns["Estado"].HeaderText = "Estado ";
                        dgvConsultar.Columns["Raza"].HeaderText = "Raza";
                        dgvConsultar.Columns["FechaNac"].HeaderText = "Fecha de Nacimiento";
                        dgvConsultar.Columns["Peso"].HeaderText = "Peso Kg";
                        dgvConsultar.Columns["Sexo"].HeaderText = "Sexo";

                    }
                    else
                    {
                      
                        MessageBox.Show("El codigo tiene que ser numerico", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                CodigoR.Text = string.Empty;

            }
            CodigoR.Clear();
        }

        private void Modo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Modo.SelectedItem.ToString() == "General")
            {
                CargarGridExpediente();
            }
        }
        public Boolean validar()
        {
            int entero;

            if (!int.TryParse(CodigoR.Text, out entero))
            {
                MessageBox.Show("El Codigo del entero no es válido.");
                CodigoR.Clear();
                return false;
            }

            return true;
        }
    }
}
