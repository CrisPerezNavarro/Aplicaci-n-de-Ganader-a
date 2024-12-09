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
    public class GestorMedicamento: Servicio,IDisposable
    {
        public void Dispose() { }
        public GestorMedicamento() { }

        public string IngresarCompraM( string Nombre, float Contenidos, string Tipo, int Temperatura, DateTime Fecha)
        {
            Medicamento nuevaTrat = new Medicamento( Nombre, Contenidos, Tipo, Temperatura, Fecha);
            using (ServicioMedicamento laMed = new ServicioMedicamento())
                return laMed.InsertarCompraM(nuevaTrat);
        }

        public string IngresarGastoM( string Nombre, float Contenidos, DateTime Fecha)
        {
            Medicamento nuevaTrat = new Medicamento( Nombre, Contenidos, Fecha);
            using (ServicioMedicamento laMed = new ServicioMedicamento())
                return laMed.InsertarGastoM(nuevaTrat);
        }

        public DataTable InventarioC()
        {

            using (ServicioMedicamento laMed = new ServicioMedicamento())
                return laMed.ListaC();
        }

        public DataTable Inventario()
        {

            using (ServicioMedicamento laMed = new ServicioMedicamento())
                return laMed.ListaInventario();
        }
        public void Vencido(DateTime fecha)
        {

            using (ServicioMedicamento laMed = new ServicioMedicamento())
            
                 laMed.Vencido(fecha);
            
        }
        public string Vacio()
        {

            using (ServicioMedicamento laMed = new ServicioMedicamento())
                return laMed.EliminarVacio();
        }
    }
}
