using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMJ.CapaLogica.LogicaNegocio
{
    public class Res
    {
        #region Atributos
        protected int codigo;
        protected string estado;
        protected string raza;
        protected DateTime fechaNac;
        protected float peso;
        protected string sexo;
        #endregion

        #region CONSTRUCTORES
        public Res()
        {

        }

        /// manejo procedimiento almacenado para insertar veterinario
        ///  /// <summary>
        /// manejo procedimiento almacenado para insertar veterinario
        /// </summary>
        /// <param name="PCodigo"></param>
        /// <param name="PEstado"></param>
        /// <param name="PRaza"></param>
        /// <param name="PFechaNac"></param>
        /// <param name="PPeso"></param>
        /// <param name="PSexo"></param>
        public Res(     int PCodigo, string PEstado,
                        string PRaza, DateTime PFechaNac,
                        float PPeso, string PSexo)
        {
            codigo = PCodigo;
            estado = PEstado;
            raza = PRaza;
            fechaNac = PFechaNac;
            peso = PPeso;
            sexo = PSexo;
        }

        /// manejo procedimiento almacenado para modificar veterinario

        public Res(     int PCodigo,
                        string PEstado,
                        float PPeso)
        {
            codigo = PCodigo;
            estado = PEstado;
            peso = PPeso;
        }
        #endregion CONSTRUCTORES

        #region GET´S Y SET´S
        public int Codigo { get => codigo; set => codigo = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Raza { get => raza; set => raza = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public float Peso { get => peso; set => peso = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        #endregion GET´S Y SET´S

    }
}
