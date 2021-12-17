using Thot_Librery.Conexiones;

namespace Thot_Librery.Codigo_Factura
{
    public class Auto_increment : Attribute
    {
        private readonly Conexion Conexiones = new Conexion();

        public int Cont()
        {
            try
            {
                Conexiones.Open();
                SqlCommand command = new SqlCommand("SP_auto_increment_FacId", Conexiones.SqlConnectio)
                {
                    CommandType = CommandType.StoredProcedure
                };
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
                Conexiones.Close();
            }
            return -1;
        }
    }
}
