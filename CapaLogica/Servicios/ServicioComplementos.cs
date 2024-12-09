using CapaLogica.LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMJ.Capa_Conexion;

namespace CapaLogica.Servicios
{
    public class ServicioComplementos : Servicio, IDisposable
    {
        private SqlCommand miComando;
        private string respuesta;

        public void Dispose()
        {
            // Implementación de Dispose si es necesario
        }

        public ServicioComplementos()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        // Método para insertar una compra de complemento en la base de datos
        public string InsertarCompra(Complementos elComplemento)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor insertar Complemento");
            miComando.CommandText = "InsertarCompra";

            // Agregar parámetros al comando SQL

            miComando.Parameters.Add("Nombre", SqlDbType.VarChar);
            miComando.Parameters["Nombre"].Value = elComplemento.Nombre;

            miComando.Parameters.Add("Cantidad", SqlDbType.Float);
            miComando.Parameters["Cantidad"].Value = elComplemento.Cantidad;

            // Ejecutar el comando y obtener la respuesta
            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
                respuesta += "se ha realizado correctamente la transacción para insertar el complemento";

            Console.WriteLine("Fin Servicio Insertar Complemento");

            return respuesta;
        }

        // Método para insertar un gasto de complemento en la base de datos
        public string InsertarGasto(Complementos elComplemento)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor insertar Complemento");
            miComando.CommandText = "InsertarGasto";

            // Agregar parámetros al comando SQL

            miComando.Parameters.Add("Nombre", SqlDbType.VarChar);
            miComando.Parameters["Nombre"].Value = elComplemento.Nombre;

            miComando.Parameters.Add("Cantidad", SqlDbType.Int);
            miComando.Parameters["Cantidad"].Value = elComplemento.Cantidad;

            // Ejecutar el comando y obtener la respuesta
            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
                respuesta += "se ha realizado correctamente la transacción para insertar el complemento";

            Console.WriteLine("Fin Servicio Insertar Complemento");

            return respuesta;
        }
        public DataTable ListaC()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Lista de Inventario");

            miComando.CommandText = "Complemento";

            DataSet inventario = new DataSet();
            this.abrirConexion();

            inventario = this.seleccionarInformacion(miComando);
            DataTable miTabla = inventario.Tables[0];

            return miTabla;
        }
    }
}
