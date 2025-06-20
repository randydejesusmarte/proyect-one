using Thot_Librery.Conexiones;

namespace Thot_Librery.Entrada
{
    public class Ventrada : Attribute
    {
        public string num { get; set; }
        public string clinte { get; set; }
        public string atendido { get; set; }
        public string trabajado { get; set; }
        public string condicion { get; set; }
        public string Servicio { get; set; }

        public void Insetar(string num, string clinte, string atendido, string trabajado, string condicion, DataRow row)
        {
            try
            {
                using Conexion conexion = new();
                using SqlConnection conn = conexion.Open();
                using SqlCommand command = new("SP_Entradas", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                _ = command.Parameters.AddWithValue("@Num", num);
                _ = command.Parameters.AddWithValue("@Cliente", clinte);
                _ = command.Parameters.AddWithValue("@Atendido", atendido);
                _ = command.Parameters.AddWithValue("@Trabajado", trabajado);
                _ = command.Parameters.AddWithValue("@Condicion", condicion);
                _ = command.Parameters.AddWithValue("@Fecha", DateTime.Now);
                _ = command.Parameters.AddWithValue("@Servicio", row["Servicio"]);
                _ = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.Message);
            }
        }

        public void cant(string num)
        {
            try
            {
                using Conexion conexion = new();
                using SqlConnection conn = conexion.Open();
                using SqlCommand command = new("SP_CantEntradas", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                _ = command.Parameters.AddWithValue("@num", num);
                _ = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.Message);
            }
        }
    }
}
