using System;
using System.Data.SqlClient;
using System.Configuration;

namespace BD
{
    public class Conexion
    {
        SqlConnection cn;
        //singleton
        static Conexion _instance;

        public static Conexion getInstance()
        {
            if (Conexion._instance == null)
            {
                Conexion._instance = new Conexion();
            }
            return Conexion._instance;
        }


        public Conexion()
        {
            cn = null;
        }

        public SqlConnection Conection
        {
            get { return this.cn; }

        }

        public bool Connect()
        {
            try
            { 
                cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["labosys"].ConnectionString);
                cn.Open();

                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("No se ha podido conectar a la Base de Datos. Error: "+ex);
            }

        }

        public void Disconnect()
        {
            if (cn != null)
            {
                cn.Close();
                cn = null;
            }
        }



    }
}
