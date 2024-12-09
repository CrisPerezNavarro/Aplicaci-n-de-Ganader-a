using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMJ.Capa_Conexion;
using CMJ.CapaLogica.LogicaNegocio;
namespace CMJ.CapaLogica.Servicios
{
    public class ServicioRes : Servicio, IDisposable
    {
        private SqlCommand miComando;
        private string respuesta;

        public void Dispose()
        {

        }

        public ServicioRes()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }
        //insertar Res
        public string insertarRes(Res laRes)
        {
            
            miComando = new SqlCommand();
            Console.WriteLine("Gestor insertar Res");
            miComando.CommandText = "InsertarRes";

            miComando.Parameters.Add("Codigo", SqlDbType.Int);
            miComando.Parameters["Codigo"].Value = laRes.Codigo;

            miComando.Parameters.Add("Estado", SqlDbType.VarChar);
            miComando.Parameters["Estado"].Value = laRes.Estado;

            miComando.Parameters.Add("Raza", SqlDbType.VarChar);
            miComando.Parameters["Raza"].Value = laRes.Raza;

            miComando.Parameters.Add("FechaNac", SqlDbType.Date);
            miComando.Parameters["FechaNac"].Value = laRes.FechaNac.Date;

            miComando.Parameters.Add("Peso", SqlDbType.Float);
            miComando.Parameters["Peso"].Value = laRes.Peso;

            miComando.Parameters.Add("Sexo", SqlDbType.VarChar);
            miComando.Parameters["Sexo"].Value = laRes.Sexo;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
                respuesta += "se ha realizado correctamente la transaccion insertar la res";

            Console.WriteLine("Fin Servicio Insertar Res");

            return respuesta;
        }
        //modificar veterinario
        public string modificarRes(Res laRes)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Res");
            miComando.CommandText = "ModificarRes";

            miComando.Parameters.Add("Codigo", SqlDbType.Int);
            miComando.Parameters["Codigo"].Value = laRes.Codigo;

            miComando.Parameters.Add("Estado", SqlDbType.VarChar);
            miComando.Parameters["Estado"].Value = laRes.Estado;

            miComando.Parameters.Add("Peso", SqlDbType.Float);
            miComando.Parameters["Peso"].Value = laRes.Peso;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
                respuesta += "se ha realizado correctamente la transaccion modificar res";

            Console.WriteLine("Fin Servicio Modificar Res");

            return respuesta;
        }


        public DataTable consultarRes(int Codigo)
        {
            miComando.CommandText = "ConsultarResE";
            miComando.Parameters.AddWithValue("@Codigo", SqlDbType.Int);
            miComando.Parameters["@Codigo"].Value = Codigo;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();
            miDataSet = this.seleccionarInformacion(miComando);
            DataTable miTabla = miDataSet.Tables[0];
            this.cerrarConexion();

            return miTabla;
        }

        public DataTable listaRes()
        {
            miComando = new SqlCommand();
            Console.WriteLine("lista de Reses");

            miComando.CommandText = "ConsultarRes";

            DataSet lares = new DataSet();
            this.abrirConexion();

            lares = this.seleccionarInformacion(miComando);
            DataTable miTabla = lares.Tables[0];

            return miTabla;
        }

        public string EliminarRes(int Codigo)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Eliminar Res");

            miComando.CommandText = "EliminarRes";
            miComando.CommandType = CommandType.StoredProcedure;

            miComando.Parameters.AddWithValue("@Codigo", Codigo);
            miComando.Parameters.Add("@Resultado", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;

            respuesta = this.ejecutaSentencia(miComando);

            // Obtener el valor del parámetro de salida

            string resultado = miComando.Parameters["@Resultado"].Value.ToString();
            if (resultado == null)
            {
                // El parámetro es nulo, manejar el caso apropiadamente
            }
            else if (resultado == "")
            {
                respuesta += " Se ha realizado correctamente la transición Eliminar vaca";
            }
            else
            {
                respuesta += resultado;
            }


            Console.WriteLine("Fin Gestor Eliminar vaca");
            return respuesta;
        }

      
        public DataTable Reporte(int Codigo)
        {
            miComando.CommandText = "Reporte";
            miComando.Parameters.AddWithValue("@Codigo", SqlDbType.Int);
            miComando.Parameters["@Codigo"].Value = Codigo;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();
            miDataSet = this.seleccionarInformacion(miComando);
            DataTable miTabla = miDataSet.Tables[0];
            this.cerrarConexion();

            return miTabla;
        }


    }
}
