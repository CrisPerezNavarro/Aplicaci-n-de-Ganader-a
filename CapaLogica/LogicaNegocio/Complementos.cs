using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogicaNegocio
{
    public class Complementos
    {

        #region Atributos
        protected int codigoC;
        protected string nombre;
        protected float cantidad;
        #endregion

        #region CONSTRUCTORES
        public Complementos()
        {
            // Constructor sin parámetros
        }

        public Complementos( string nombre, float cantidad)
        {
            // Constructor con parámetros
            this.codigoC = 0;
            this.nombre = nombre;
            this.cantidad = cantidad;
        }
      

        // Otros constructores si es necesario
        #endregion CONSTRUCTORES

        #region GET'S Y SET'S
        public int CodigoC { get => codigoC; set => codigoC = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float Cantidad { get => cantidad; set => cantidad = value; }
        #endregion GET'S Y SET'S

        // Otros métodos de la clase si es necesario
    }
}
