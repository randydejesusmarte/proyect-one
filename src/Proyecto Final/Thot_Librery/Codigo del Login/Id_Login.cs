using Thot_Librery.Conexiones;

namespace Thot_Librery.Codigo_del_Login
{
    public class Id_Login : Attribute
    {
        private readonly Conexion conexion = new();
        public int get_id(string Nombre, string Contraceña)
        {
            try
            {
                _ = conexion.Open();
                SqlCommand command = new("sp_get_id", conexion.SqlConnectio)
                {
                    CommandType = CommandType.StoredProcedure
                };
                _ = command.Parameters.AddWithValue("@Nombre", Nombre);
                _ = command.Parameters.AddWithValue("@Clave", Contraceña);
                SqlDataReader DataReader = command.ExecuteReader();
                if (DataReader.Read())
                {
                    return DataReader.GetInt32(0);
                }
            }
            catch (Exception es)
            {
                _ = MessageBox.Show(es.Message);
            }
            finally
            {
                _ = conexion.Close();
            }
            return 0;
        }
        public string get_name(string Nombre, string Contraceña)
        {
            try
            {
                _ = conexion.Open();
                SqlCommand command = new("sp_get_id", conexion.SqlConnectio)
                {
                    CommandType = CommandType.StoredProcedure
                };
                _ = command.Parameters.AddWithValue("@Nombre", Nombre);
                _ = command.Parameters.AddWithValue("@Clave", Contraceña);
                SqlDataReader DataReader = command.ExecuteReader();
                if (DataReader.Read())
                {
                    return DataReader.GetString(1);
                }
            }
            catch (Exception es)
            {
                _ = MessageBox.Show(es.Message);
            }
            finally
            {
                _ = conexion.Close();
            }
            return "";
        }
    }
}
