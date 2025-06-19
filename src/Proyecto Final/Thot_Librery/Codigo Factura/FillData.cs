using Thot_Librery.Conexiones;
namespace Thot_Librery.Codigo_Factura
{
    public class FillData
    {
        public DataTable Datos(string Id_Factura)
        {
            using Conexion conexiones = new();
            using SqlConnection conn = conexiones.Open();
            using SqlCommand command = new()
            {
                Connection = conn,
                CommandText = "sp_Fill_Data_Factura",
                CommandType = CommandType.StoredProcedure
            };
            int idfactura = Convert.ToInt32(Id_Factura);
            _ = command.Parameters.AddWithValue("@Idfactura", idfactura);
            using SqlDataReader leer = command.ExecuteReader();
            DataTable datos = new();
            datos.Load(leer);
            return datos;
        }
    }
}
