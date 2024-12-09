using CapaLogica.LogicaNegocio;
using CMJ.Capa_Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Servicios
{
    public class ServicioMedicamento : Servicio, IDisposable
    {
        private SqlCommand miComando;
        private string respuesta;

        public void Dispose()
        {
            // Implementación de Dispose si es necesario
        }

        public ServicioMedicamento()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }
        //Insertar Compras
        public string InsertarCompraM(Medicamento elMedicamento)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor insertar Medicamento");
            miComando.CommandText = "InsertarCompraM";

            miComando.Parameters.Add("Nombre", SqlDbType.VarChar);
            miComando.Parameters["Nombre"].Value = elMedicamento.Nombre;

            miComando.Parameters.Add("Contenido", SqlDbType.Float);
            miComando.Parameters["Contenido"].Value = elMedicamento.Contenido;

            miComando.Parameters.Add("Tipo", SqlDbType.VarChar);
            miComando.Parameters["Tipo"].Value = elMedicamento.Tipo;

            miComando.Parameters.Add("Temperatura", SqlDbType.Int);
            miComando.Parameters["Temperatura"].Value = elMedicamento.Temperatura;

            miComando.Parameters.Add("Fecha", SqlDbType.Date);
            miComando.Parameters["Fecha"].Value = elMedicamento.Fecha.Date;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
                respuesta += "se ha realizado correctamente la transaccion insertar el medicamento";

            Console.WriteLine("Fin Servicio Insertar Medicamento");

            return respuesta;
        }
        //Insertar Gastos y ajustes
        public string InsertarGastoM(Medicamento elMedicamento)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor insertar Medicamento");
            miComando.CommandText = "InsertarGastoM";

            miComando.Parameters.Add("Nombre", SqlDbType.VarChar);
            miComando.Parameters["Nombre"].Value = elMedicamento.Nombre;

            miComando.Parameters.Add("Contenido", SqlDbType.Float);
            miComando.Parameters["Contenido"].Value = elMedicamento.Contenido;

            miComando.Parameters.Add("Fecha", SqlDbType.Date);
            miComando.Parameters["Fecha"].Value = elMedicamento.Fecha.Date;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
                respuesta += "se ha realizado correctamente la transaccion insertar el medicamento";

            Console.WriteLine("Fin Servicio Insertar Medicamento");

            return respuesta;
        }
       
        //Ver inventario restante y actulizacion de vacio
        public DataTable ListaInventario()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Lista de Inventario");

            miComando.CommandText = "ConsultarInventario";

            DataSet inventario = new DataSet();
            this.abrirConexion();

            inventario = this.seleccionarInformacion(miComando);
            DataTable miTabla = inventario.Tables[0];

            return miTabla;
        }

        public DataTable ListaC()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Lista de Inventario");

            miComando.CommandText = "Medicamento";

            DataSet inventario = new DataSet();
            this.abrirConexion();

            inventario = this.seleccionarInformacion(miComando);
            DataTable miTabla = inventario.Tables[0];

            return miTabla;
        }
        //Eliminar inventario caduco

        public DataTable Vencido(DateTime fecha)
        {
            miComando.CommandText = "Vencido";
            miComando.Parameters.AddWithValue("@Fecha", SqlDbType.Date);
            miComando.Parameters["@Fecha"].Value = fecha.Date;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();
            miDataSet = this.seleccionarInformacion(miComando);
            DataTable miTabla = miDataSet.Tables[0];
            this.cerrarConexion();

            return miTabla;
        }
        public string EliminarVencido(){
            miComando = new SqlCommand();
            Console.WriteLine("Lista de Inventario");

            miComando.CommandText = "EliminarVencido";

            string response = string.Empty;
            this.abrirConexion();
            using (SqlDataReader reader = miComando.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        response = reader.GetString(reader.GetOrdinal("Resultado")); // Lee el valor de la columna "Resultado"
                    }
                }
            }

            this.cerrarConexion();

            return response;
        }
        //Eliminar inventario vacio
        public string EliminarVacio()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Lista de Inventario");

            miComando.CommandText = "EliminarVacio";

            string response = string.Empty;
            this.abrirConexion();
            using (SqlDataReader reader = miComando.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        response = reader.GetString(reader.GetOrdinal("Resultado")); // Lee el valor de la columna "Resultado"
                    }
                }
            }

            this.cerrarConexion();

            return response;
        }

    }
       
    
}
