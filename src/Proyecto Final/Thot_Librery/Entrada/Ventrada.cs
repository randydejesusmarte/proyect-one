using Thot_Librery.Conexiones;

namespace Thot_Librery.Entrada
{
    public class Ventrada : Attribute
    {
        private readonly Conexion Conexiones = new();

        public required string num { get; set; }
        public required string clinte { get; set; }
        public required string atendido { get; set; }
        public required string trabajado { get; set; }
        public required string condicion { get; set; }
        public required string Servicio { get; set; }

        public void Insetar(string num, string cliente, string atendido, string trabajado, string condicion, DataRow entrada)
        {
            _ = Conexiones.Open();

            SqlCommand command = new("SP_Entradas", Conexiones.SqlConnectio)
            {
                CommandType = CommandType.StoredProcedure
            };
            _ = command.Parameters.AddWithValue("@Num", num);
            _ = command.Parameters.AddWithValue("@Cliente", cliente);
            _ = command.Parameters.AddWithValue("@Atendido", atendido);
            _ = command.Parameters.AddWithValue("@Trabajado", trabajado);
            _ = command.Parameters.AddWithValue("@Condicion", condicion);
            _ = command.Parameters.AddWithValue("@Fecha", DateTime.Now.ToString());
            _ = command.Parameters.AddWithValue("@Servicio", entrada["Servicio"]);
            _ = command.ExecuteNonQuery();
            command.Parameters.Clear();
            _ = Conexiones.Close();
        }
        public void cant(string num)
        {
            _ = Conexiones.Open();
            SqlCommand command = new("SP_CantEntradas", Conexiones.SqlConnectio)
            {
                CommandType = CommandType.StoredProcedure
            };
            _ = command.Parameters.AddWithValue("@Num", Convert.ToInt32(num));
            _ = command.ExecuteNonQuery();
            command.Parameters.Clear();
            _ = Conexiones.Close();
        }
    }
}
