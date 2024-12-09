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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Registro_Vacuno
{
    public partial class EliminarRes : Form
    {

 
        public EliminarRes()
        {
            InitializeComponent();

        }

      

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using(GestorRes res = new GestorRes())
            {

                if (Codigo.Text != "" && validar())
                {
                    MessageBox.Show(res.EliminarRes(int.Parse(Codigo.Text)));
                    Codigo.Clear();

                }
                    else
                    {
                   
                    
                    string codigoSeleccionado = Lista.Text;
                    
                    // Utilizando int.Parse()
                    int codigoInt = int.Parse(codigoSeleccionado);

                    // Utilizando int.TryParse()

                    if (int.TryParse(codigoSeleccionado, out codigoInt))
                    {
                        if (Codigo.Text == "")
                        { 
                            // Conversión exitosa, puedes utilizar el valor de 'codigoInt'
                            MessageBox.Show(res.EliminarRes(codigoInt));
                            Codigo.Clear();
                        }
                        
                    }
                    else
                    {
                        // La cadena seleccionada no se pudo convertir a un entero válido
                        // Maneja el caso de error apropiadamente
                        MessageBox.Show("La cadena seleccionada no se pudo convertir a un entero válido");
                    }

                }

            }
            CargarCombo();
        }
        private void CargarCombo()
        {
            
            using (GestorRes res = new GestorRes())
            {

                Lista.DataSource = res.ConsultarResE();
                Lista.ValueMember = "Codigo";
                Lista.DisplayMember = "Codigo";
            }
        }

        private void EliminarRes_Load(object sender, EventArgs e)
        {
            CargarCombo();
            Lista.SelectedIndex = 0;
        }

        public Boolean validar()
        {
            int entero;
            
            if (!int.TryParse(Codigo.Text, out entero))
            {
                MessageBox.Show("El Codigo del entero no es válido.");
                Codigo.Clear();
                return false;
            }

            return true;
        }
    }
}
