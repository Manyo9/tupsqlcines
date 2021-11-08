using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackend.Acceso_a_Datos
{
    class DaoHelper
    {
        private string cadenaConexion;
        private SqlConnection conexion;
        private SqlCommand comando;

        public DaoHelper()
        {
            cadenaConexion = @"";
            conexion = new SqlConnection(cadenaConexion);
        }

        public DataTable ConsultarDB(string nombreSP)
        {
            DataTable tabla = new DataTable();
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            try
            {
                conexion.Open();
                tabla.Load(comando.ExecuteReader());
                conexion.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return tabla;
        }
        public DataTable ConsultarConParametro(string nombreSP, Parametro parametro)
        {
            DataTable tabla = new DataTable();
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            comando.Parameters.AddWithValue(parametro.Nombre, parametro.Valor);
            try
            {
                conexion.Open();
                tabla.Load(comando.ExecuteReader());
                conexion.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return tabla;
        }
        public DataTable EjecutarSPSalida(string sp, string nomParametro)
        {
            DataTable tabla = new DataTable();
            comando = new SqlCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            comando.CommandText = sp;
            SqlParameter param = new SqlParameter();
            param.ParameterName = nomParametro;
            param.Direction = ParameterDirection.Output;
            param.SqlDbType = SqlDbType.Int;
            comando.Parameters.Add(param);
            try
            {
                conexion.Open();
                comando.ExecuteReader();
                conexion.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return tabla;
        }


    }
}
