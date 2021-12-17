using Thot_Librery.Conexiones;

namespace Thot_Librery.Codigo_del_Login
{
    public class Login_conect : Attribute
    {
        private readonly Conexion conexion = new Conexion();
        public int Logear(string Nombre, string Contraceña)
        {
            try
            {
                conexion.Open();
                SqlCommand command = new SqlCommand("sp_Login", conexion.SqlConnectio)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@Clave", Contraceña);

                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    return dataReader.GetInt32(0);
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
    }
}
