using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

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
                cn = new SqlConnection("Data Source=POTASIO-PC\\SQLEXPRESS;Initial Catalog=Labosys;Integrated Security=True");
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
