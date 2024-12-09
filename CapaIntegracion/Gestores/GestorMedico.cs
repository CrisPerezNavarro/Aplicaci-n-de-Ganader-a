using CapaLogica.LogicaNegocio;
using CapaLogica.Servicios;
using CMJ.Capa_Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMJ.CapaIntegracion.Gestores
{
    public class GestorMedico: Servicio, IDisposable
    {

        public void Dispose() { }
        public GestorMedico() { }

        public string IngresarVac (int codigoRes, string nombre, DateTime fecha, string dosis, string diagnostico, string detalle)
        {
            Medico nuevaVac = new Medico(codigoRes, nombre, fecha, dosis, diagnostico, detalle);
            using (ServicioMedico laVac = new ServicioMedico())
                return laVac.InsertarVacuna(nuevaVac);
        }
        public string EliminarVac(int codigoRes)
        {
            using (ServicioMedico laVac = new ServicioMedico())
                return laVac.EliminarVacuna(codigoRes);
        }
        public DataTable ConsultarVac(int codigoRes)
        {
            using (ServicioMedico laVac = new ServicioMedico())
                return laVac.ConsultarVacuna(codigoRes);
        }
        public DataTable ListaVac()
        {
            using (ServicioMedico laVac = new ServicioMedico())
                return laVac.ListaVacunas();
        }






    }
}
