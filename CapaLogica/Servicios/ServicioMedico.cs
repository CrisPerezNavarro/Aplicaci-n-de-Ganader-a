using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMJ.Capa_Conexion;
using CMJ.CapaLogica.LogicaNegocio;
using System.Data.SqlClient;
using CapaLogica.LogicaNegocio;
using System.Data;
namespace CapaLogica.Servicios
{
    public class ServicioMedico : Servicio, IDisposable
    {
        private SqlCommand miComando;
        private string respuesta;

        public void Dispose()
        {
            // Implementación de Dispose si es necesario
        }

        public ServicioMedico()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        // Insertar Vacuna
        public string InsertarVacuna(Medico laVacuna)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor insertar Vacuna");
            miComando.CommandText = "InsertarVac";

            // Agregar parámetros al comando
            miComando.Parameters.Add("CodigoRes", SqlDbType.Int);
            miComando.Parameters["CodigoRes"].Value = laVacuna.CodigoRes;


            miComando.Parameters.Add("Nombre", SqlDbType.VarChar);
            miComando.Parameters["Nombre"].Value = laVacuna.Nombre;

            miComando.Parameters.Add("Facha", SqlDbType.Date);
            miComando.Parameters["Facha"].Value = laVacuna.Facha.Date;

            miComando.Parameters.Add("Dosis", SqlDbType.VarChar);
            miComando.Parameters["Dosis"].Value = laVacuna.Dosis;

            miComando.Parameters.Add("Diagnostico", SqlDbType.VarChar);
            miComando.Parameters["Diagnostico"].Value = laVacuna.Diagnostico;

            miComando.Parameters.Add("Detalle", SqlDbType.VarChar);
            miComando.Parameters["Detalle"].Value = laVacuna.Detalle;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
                respuesta += "se ha realizado correctamente la transaccion insertar la vacuna";

            Console.WriteLine("Fin Servicio Insertar Vacuna");

            return respuesta;
        }

        public DataTable ConsultarVacuna(int codigoRes)
        {
            miComando.CommandText = "ConsultarVac";
            miComando.Parameters.AddWithValue("@CodigoRes", SqlDbType.Int);
            miComando.Parameters["@CodigoRes"].Value = codigoRes;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();
            miDataSet = this.seleccionarInformacion(miComando);
            DataTable miTabla = miDataSet.Tables[0];
            this.cerrarConexion();

            return miTabla;
        }

        public DataTable ListaVacunas()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Lista de Vacunas");

            miComando.CommandText = "ConsultarVacE";

            DataSet vacunas = new DataSet();
            this.abrirConexion();

            vacunas = this.seleccionarInformacion(miComando);
            DataTable miTabla = vacunas.Tables[0];

            return miTabla;
        }

        public string EliminarVacuna(int codigoRes)
        {
            miComando.CommandText = "EliminarVac";
            miComando.CommandType = CommandType.StoredProcedure;
            miComando.Parameters.AddWithValue("@CodigoRes", codigoRes);

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
