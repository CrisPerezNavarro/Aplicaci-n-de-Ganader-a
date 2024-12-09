using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogicaNegocio
{
    public class Medicamento
    {
        #region Atributos
        protected int codigoM;
        protected string nombre;
        protected float contenidos;
        protected string tipo;
        protected int temperatura;
        protected DateTime fecha;
        #endregion

        #region CONSTRUCTORES
        public Medicamento()
        {
            // Constructor sin parámetros
        }

        public Medicamento( string PNombre, float PContenidos, string PTipo, int PTemperatura, DateTime PFecha)
        {
            // Constructor con parámetros
            codigoM = 0;
            nombre = PNombre;
            contenidos = PContenidos;
            tipo = PTipo;
            temperatura = PTemperatura;
            fecha = PFecha;
        }
        public Medicamento( string PNombre, float PContenidos,  DateTime PFecha)
        {
            // Constructor con parámetros
            nombre = PNombre;
            contenidos = PContenidos;
            fecha = PFecha;
        }

        // Otros constructores si es necesario
        #endregion CONSTRUCTORES

        #region GET'S Y SET'S
        public int CodigoM { get => codigoM; set => codigoM = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float Contenido { get => contenidos; set => contenidos = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Temperatura { get => temperatura; set => temperatura = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        #endregion GET'S Y SET'S

        // Otros métodos de la clase si es necesario
    }
}

