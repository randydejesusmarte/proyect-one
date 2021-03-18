using System;
using System.Data;
using System.Data.SqlClient;


namespace Thot_Librery
{
    internal class Conexion : Attribute
    {
        internal SqlConnection SqlConnectio = new SqlConnection();
        internal string cadena =  Properties.Settings.Default.Conecctionstring;
        
        internal Conexion()
        {
            SqlConnectio.ConnectionString = cadena;
        }
        public SqlConnection Open()
        {
            if (SqlConnectio.State == ConnectionState.Closed)
            {
                SqlConnectio.Open();
            }
            return SqlConnectio;
        }

        public SqlConnection Close()
        {
            if (SqlConnectio.State == ConnectionState.Open)
            {
                SqlConnectio.Close();
            }
            return SqlConnectio;
        }
    }
}
