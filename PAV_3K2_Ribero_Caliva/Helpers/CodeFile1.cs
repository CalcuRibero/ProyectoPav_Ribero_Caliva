using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace PAV_3K2_Ribero_Caliva.Helper
{
    public class PlayaBD
    {
        OleDbConnection conexion = new OleDbConnection();

        OleDbCommand cmd = new OleDbCommand();

        string cadena_conexion = "Data Source=PlayaXibiXibi.mssql.somee.com;Initial Catalog=PlayaXibiXibi;User ID=Calcu_SQLLogin_1;pwd=b2d8t73sfu";
        private void conectar()
        {
            conexion.ConnectionString = cadena_conexion;
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
        }
        private void cerrar()
        {
            conexion.Close();
        }
        public DataTable consulta(string comando)
        {
            conectar();
            cmd.CommandText = comando;
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            return tabla;
        }
        public bool EjecutarSQL(string comando)
        {
            conectar();
            cmd.CommandText = comando;
            var filasAfectadas = cmd.ExecuteNonQuery();
            cerrar();
            return filasAfectadas > 0;
        }
    }
}