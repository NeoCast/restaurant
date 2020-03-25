using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;


namespace accdatos
{
    class consulta
    {

      private conexionbd conexion = new conexionbd();

        public void insert(string sql)
        {
            try
            { 
            SqlCommand comando = new SqlCommand();

            comando.Connection = conexion.abrircn();
            comando.CommandText = sql;
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;

            }
            finally
            {
                conexion.cerrarcn();
            }
}

        public void delete(string sql)
        {
            try
            {

            SqlCommand comando = new SqlCommand();

            comando.Connection = conexion.abrircn();
            comando.CommandText = sql;
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable select(string sql)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                DataTable tabla = new DataTable();
                SqlDataReader reader;

                comando.Connection = conexion.abrircn();
                comando.CommandText = sql;
                comando.CommandType = CommandType.Text;
                reader = comando.ExecuteReader();
                tabla.Load(reader);

                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarcn();
            }

        
        }

        protected DataTable ejecutarSP(string sp, object parametros)
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            SqlDataReader reader;

            return tabla;
        }


    }
}
