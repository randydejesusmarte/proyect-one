using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Thot_Librery.Conexiones;

namespace Thot_Librery.Codigo_Factura
{
    public class textrefresh : Attribute
    {
        private readonly Conexion conexion = new Conexion();
        public void Textrefresh(TextBox text)
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            conexion.Open();
            SqlCommand command = new SqlCommand("sp_textrefresh", conexion.SqlConnectio);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                collection.Add(reader["Nom_cli"].ToString());
            }
            conexion.Close();
            text.AutoCompleteCustomSource = collection;
        }
    }
}
