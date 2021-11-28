using System.Data;
using System.Data.SqlClient;
using Thot_Librery.Conexiones;

namespace Thot_Librery.Codigo_del_Login
{
    public class Id_Login : Attribute
    {
        private readonly Conexion conexion = new Conexion();
        public int get_id(string Nombre, string Contraceña)
        {
            try
            {
                conexion.Open();
                SqlCommand command = new("sp_get_id", conexion.SqlConnectio)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@Clave", Contraceña);
                SqlDataReader DataReader = command.ExecuteReader();
                if (DataReader.Read())
                {
                    return DataReader.GetInt32(0);
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            finally
            {
                conexion.Close();
            }
            return -1;
        }
        public string get_name(string Nombre, string Contraceña)
        {
            try
            {
                conexion.Open();
                SqlCommand command = new SqlCommand("sp_get_id", conexion.SqlConnectio)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@Clave", Contraceña);
                SqlDataReader DataReader = command.ExecuteReader();
                if (DataReader.Read())
                {
                    return DataReader.GetString(1);
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            finally
            {
                conexion.Close();
            }
            return "";
        }
    }
}
