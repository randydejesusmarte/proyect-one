using Thot_Librery.Conexiones;

namespace Thot_Librery.Codigo_del_Login
{
    public class Id_Login : Attribute
    {
        // Elimina la conexión de nivel de clase para evitar problemas de concurrencia
        public int get_id(string Nombre, string Contraceña)
        {
            try
            {
                using Conexion conexion = new();
                using SqlConnection conn = conexion.Open();
                using SqlCommand command = new("sp_get_id", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                _ = command.Parameters.AddWithValue("@Nombre", Nombre);
                _ = command.Parameters.AddWithValue("@Clave", Contraceña);
                using SqlDataReader DataReader = command.ExecuteReader();
                if (DataReader.Read())
                {
                    return DataReader.GetInt32(0);
                }
            }
            catch (Exception es)
            {
                _ = MessageBox.Show(es.Message);
            }
            return 0;
        }
        public string get_name(string Nombre, string Contraceña)
        {
            try
            {
                using Conexion conexion = new();
                using SqlConnection conn = conexion.Open();
                using SqlCommand command = new("sp_get_id", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                _ = command.Parameters.AddWithValue("@Nombre", Nombre);
                _ = command.Parameters.AddWithValue("@Clave", Contraceña);
                using SqlDataReader DataReader = command.ExecuteReader();
                if (DataReader.Read())
                {
                    return DataReader.GetString(1);
                }
            }
            catch (Exception es)
            {
                _ = MessageBox.Show(es.Message);
            }
            return "";
        }
    }
}
