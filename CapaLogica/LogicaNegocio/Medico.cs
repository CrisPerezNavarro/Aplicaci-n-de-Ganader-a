using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogicaNegocio
{
    public class Medico
    {
        #region Atributos
        protected int codigoRes;
        protected int codigoVac;
        protected string nombre;
        protected DateTime fecha;
        protected string dosis;
        protected string diagnostico;
        protected string detalle;
        #endregion

        #region CONSTRUCTORES
        public Medico()
        {
            // Constructor sin parámetros
        }

        public Medico(int codigoRes,  string nombre, DateTime fecha, string dosis, string diagnostico, string detalle)
        {
            // Constructor con parámetros
            this.codigoVac = 0;
            this.codigoRes = codigoRes;  
            this.nombre = nombre;
            this.fecha = fecha;
            this.dosis = dosis;
            this.diagnostico = diagnostico;
            this.detalle = detalle;
        }

        // Otros constructores si es necesario
        #endregion CONSTRUCTORES

        #region GET'S Y SET'S
        public int CodigoRes { get => codigoRes; set => codigoRes = value; }
        public int CodigoVac { get => codigoVac; set => codigoVac = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime Facha { get => fecha; set => fecha = value; }
        public string Dosis { get => dosis; set => dosis = value; }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        #endregion GET'S Y SET'S

        // Otros métodos de la clase si es necesario
    }
}
