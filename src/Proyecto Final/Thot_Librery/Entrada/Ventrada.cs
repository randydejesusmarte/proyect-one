using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using Thot_Librery.Conexiones;
using System.Data.SqlClient;

namespace Thot_Librery.Entrada
{
    public class Ventrada : Attribute
    {
        private readonly Conexion Conexiones = new Conexion();

        public string Sas { get; set; }
        public string Sopa { get; set; }

        public void Insetar(DataRow entrada)
        {
            Conexiones.Open();

            SqlCommand command = new SqlCommand("SP_Entradas", Conexiones.SqlConnectio);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@sas", entrada["Sas"]);
            command.Parameters.AddWithValue("@sopa", entrada["Sopa"]);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            Conexiones.Close();
        }
    }
}
