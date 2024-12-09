using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CMJ.Capa_Conexion
{
    

        public class Servicio
        {
            private SqlConnection conexion;

            public Servicio()
            {
                
                conexion = new SqlConnection(@"workstation id=CMJsystem.mssql.somee.com;packet size=4096;
                                            user id=Fer;pwd=1234Fer*;data source=CMJsystem.mssql.somee.com;
                                            persist security info=False;initial catalog=CMJsystem");

            }
            protected void abrirConexion()
            {
                conexion.Open();
            }

            protected void cerrarConexion()
            {
                conexion.Close();
            }

            protected string ejecutaSentencia(string sentencia)
            {
                SqlCommand comando = new SqlCommand(sentencia, conexion);

                try
                {
                    this.abrirConexion();
                    comando.ExecuteScalar();
                }
                catch (Exception error)
                {
                    this.cerrarConexion();
                    return error.Message;
                }
                this.cerrarConexion();
                return "";
            }
            protected string ejecutaSentencia(SqlCommand miComando)
            {
                miComando.Connection = conexion;
                miComando.CommandType = CommandType.StoredProcedure;
                miComando.CommandTimeout = 6000;
                try
                {
                    this.abrirConexion();
                    miComando.ExecuteScalar();
                }
                catch (Exception error)
                {
                    this.cerrarConexion();
                    return error.Message;
                }
                this.cerrarConexion();
                return "";
            }

            protected DataSet selecccionarInformacion(string sentencia)
            {
                DataSet miDataSet = new DataSet();
                SqlCommand miSqlCommand = conexion.CreateCommand();

                miSqlCommand.CommandText = sentencia;
                SqlDataAdapter miSqlDataAdapter = new SqlDataAdapter();

                miSqlDataAdapter.SelectCommand = miSqlCommand;
                miSqlDataAdapter.Fill(miDataSet);

                return miDataSet;
            }

            protected DataSet seleccionarInformacion(SqlCommand miComando)
            {
                DataSet miDataSet = new DataSet();
                SqlDataAdapter miSqlAdapter = new SqlDataAdapter();

                miComando.CommandTimeout = 2000;
                miComando.Connection = conexion;

                miComando.CommandType = CommandType.StoredProcedure;
                miSqlAdapter.SelectCommand = miComando;
                miSqlAdapter.Fill(miDataSet);

                return miDataSet;
            }
        }
    }
