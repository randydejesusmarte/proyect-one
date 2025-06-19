using Thot_Librery.Conexiones;

namespace Thot_Librery.Codigo_del_Login
{
    public class Login_conect : Attribute
    {
        // Elimina la conexión de nivel de clase para evitar problemas de concurrencia
        public int Logear(string Nombre, string Contraceña)
        {
            try
            {
                using Conexion conexion = new();
                using SqlConnection conn = conexion.Open();
                using SqlCommand command = new("sp_Login", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                _ = command.Parameters.AddWithValue("@Nombre", Nombre);
                _ = command.Parameters.AddWithValue("@Clave", Contraceña);

                using SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    return dataReader.GetInt32(0);
                }
            }
            catch (Exception es)
            {
                _ = MessageBox.Show(es.Message);
            }
            return -1;
        }
    }
}
