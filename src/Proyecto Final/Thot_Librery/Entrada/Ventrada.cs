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

        public string num { get; set; }
        public string clinte { get; set; }
        public string atendido { get; set; }
        public string trabajado { get; set; }
        public string condicion { get; set; }
        public string Servicio { get; set; }

        public void Insetar(string num,string cliente,string atendido,string trabajado,string condicion, DataRow entrada)
        {
            Conexiones.Open();

            SqlCommand command = new SqlCommand("SP_Entradas", Conexiones.SqlConnectio);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Num", num);
            command.Parameters.AddWithValue("@Cliente", cliente);
            command.Parameters.AddWithValue("@Atendido", atendido);
            command.Parameters.AddWithValue("@Trabajado", trabajado);
            command.Parameters.AddWithValue("@Condicion", condicion);
            command.Parameters.AddWithValue("@Fecha", DateTime.Now.ToString());
            command.Parameters.AddWithValue("@Servicio", entrada["Servicio"]);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            Conexiones.Close();
        }
    }
}
