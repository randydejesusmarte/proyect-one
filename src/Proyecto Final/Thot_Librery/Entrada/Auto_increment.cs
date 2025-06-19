using Thot_Librery.Conexiones;

namespace Thot_Librery.Entrada
{
    public class Auto_increment : Attribute
    {
        public int Cont()
        {
            try
            {
                using Conexion conexion = new();
                using SqlConnection conn = conexion.Open();
                using SqlCommand command = new("SP_auto_increment_Id", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
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
            return -1;
        }
    }
}
