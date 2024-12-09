using CMJ.CapaLogica.LogicaNegocio;
using CMJ.CapaLogica.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMJ.Capa_Conexion;
using System.Data;

namespace CMJ.CapaIntegracion.Gestores
{
    public class GestorRes : Servicio, IDisposable
    {

        public GestorRes() { }
        public void Dispose() { }
        public string IngresarRes(int Codigo, string Estado,
                        string Raza, DateTime FechaNac,
                        float Peso, string Sexo)
        {
            
            Res nuevaRes = new Res(Codigo, Estado, Raza, FechaNac, Peso, Sexo);
            using (ServicioRes laRes = new ServicioRes())
                return laRes.insertarRes(nuevaRes);
        }
        public string ModificarRes(int Codigo, string Estado,
                        float Peso)
        {
            Res nuevaRes = new Res(Codigo, Estado, Peso);
            using (ServicioRes laRes = new ServicioRes())
                return laRes.modificarRes(nuevaRes);
        }


        public string EliminarRes(int Codigo)
        {
            
            using (ServicioRes laRes = new ServicioRes())
                return laRes.EliminarRes(Codigo);
        }
        public DataTable ConsultarRes(int Codigo)
        {

            using (ServicioRes laRes = new ServicioRes())
                return laRes.consultarRes(Codigo);
        }
        public DataTable ConsultarResE()
        {

            using (ServicioRes laRes = new ServicioRes())
                return laRes.listaRes();
        }
        public DataTable Reporte(int Codigo)
        {

            using (ServicioRes laRes = new ServicioRes())
                return laRes.Reporte(Codigo);
        }
    }
}
