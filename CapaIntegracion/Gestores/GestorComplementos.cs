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
    public class GestorComplementos: Servicio, IDisposable
    {
        public void Dispose() { }
        public GestorComplementos() { }

        public string IngresarCompra(string nombre, float cantidad)
        {
            Complementos nuevaTrat = new Complementos(nombre, cantidad);
            using (ServicioComplementos laCom = new ServicioComplementos())
                return laCom.InsertarCompra(nuevaTrat);
        }

        public string IngresarGasto(string nombre, float cantidad)
        {
            Complementos nuevaTrat = new Complementos(nombre, cantidad);
            using (ServicioComplementos laCom = new ServicioComplementos())
                return laCom.InsertarGasto(nuevaTrat);
        }
        public DataTable InventarioC()
        {

            using (ServicioComplementos laMed = new ServicioComplementos())
                return laMed.ListaC();
        }
    }
}
