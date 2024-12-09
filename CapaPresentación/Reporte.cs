using CMJ.CapaIntegracion.Gestores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (validar()) {
                using (GestorRes res = new GestorRes())
                {

                    dgvConsultar.DataSource = res.Reporte(int.Parse(CodigoR.Text));
                    dgvConsultar.Columns["Codigo"].HeaderText = "Codigo de la Vaca";
                    dgvConsultar.Columns["Estado"].HeaderText = "Estado ";
                    dgvConsultar.Columns["Raza"].HeaderText = "Raza";
                    dgvConsultar.Columns["FechaNac"].HeaderText = "Fecha de Nacimiento";
                    dgvConsultar.Columns["Peso"].HeaderText = "Peso Kg";
                    dgvConsultar.Columns["Sexo"].HeaderText = "Sexo";
                    dgvConsultar.Columns["Nombre"].HeaderText = "Nombre de medicamento";
                    dgvConsultar.Columns["Facha"].HeaderText = "Fecha de apiacacion";
                    dgvConsultar.Columns["Dosis"].HeaderText = "Dosis aplicada";
                    dgvConsultar.Columns["Diagnostico"].HeaderText = "Diagnostico";
                    dgvConsultar.Columns["Detalle"].HeaderText = "Detalles";

                    //t2.Facha, t2.Dosis, t2.Diagnostico,t2.Detalle
                }
            }
            CodigoR.Clear();
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font fontTitle = new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Point);
            Font fontHeader = new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Point);
            Font fontBody = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
            float fontHeightTitle = fontTitle.GetHeight();
            float fontHeightHeader = fontHeader.GetHeight();
            float fontHeightBody = fontBody.GetHeight();

            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            string title = "Informe de Res";
            string[] columnHeaders = { "Codigo de la Vaca", "Estado", "Raza", "Fecha de Nacimiento", "Peso Kg", "Sexo", "Nombre de medicamento", "Fecha de aplicacion", "Dosis aplicada", "Diagnostico", "Detalles" };

            // Imprimir título
            e.Graphics.DrawString(title, fontTitle, Brushes.Black, x, y);
            y += fontHeightTitle * 2; // Espacio adicional para separación

            // Imprimir encabezados de columna
            for (int i = 0; i < columnHeaders.Length; i++)
            {
                if (!dgvConsultar.Columns[i].Visible)
                    continue;

                string headerText = columnHeaders[i];
                string cellText = dgvConsultar.Rows[0].Cells[i].FormattedValue.ToString();

                float maxTextHeight = Math.Max(fontHeightHeader, fontHeightBody);

                // Imprimir encabezado de columna
                e.Graphics.DrawString(headerText, fontHeader, Brushes.Black, x, y);
                y += maxTextHeight;

                // Imprimir dato del DataGridView
                e.Graphics.DrawString(cellText, fontBody, Brushes.Black, x, y);
                y += maxTextHeight;

                // Alinear el texto a la derecha para la columna de "Peso Kg"
               

                y += fontHeightBody;

                // Avanzar a la siguiente columna si hay suficiente espacio
                if (y + fontHeightBody > e.MarginBounds.Bottom)
                {
                    y = e.MarginBounds.Top;
                    x += dgvConsultar.Columns[i].Width;
                }
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();
        }

        public Boolean validar()
        {
            int entero;

            if (!int.TryParse(CodigoR.Text, out entero))
            {
                MessageBox.Show("El Codigo no es válido.");
                CodigoR.Clear();
                return false;
            }

            return true;
        }
    }
}
