using Thot_Librery.Conexiones;
namespace Thot_Librery.Codigo_Factura
{
    public class textrefresh : Attribute
    {
        private readonly Conexion conexion = new();
        public void Textrefresh(TextBox text)
        {
            AutoCompleteStringCollection collection = [];
            _ = conexion.Open();
            SqlCommand command = new("sp_textrefresh", conexion.SqlConnectio)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                _ = collection.Add(reader["Nom_cli"].ToString());
            }
            _ = conexion.Close();
            text.AutoCompleteCustomSource = collection;
        }
    }
}
