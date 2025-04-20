using Thot_Librery.Conexiones;
namespace Thot_Librery.Codigo_Factura
{
    public class Agregar_Factura
    {
        private readonly Conexion conexion = new();
        public void Agregar(int id, int Id_cliente, string Nombre_producto, string Precio, string Cantidad, string Monto, string Precio_total, int ID_Empleado, string Fecha_del_Registro)
        {
            _ = conexion.Open();
            SqlCommand command = new()
            {
                Connection = conexion.SqlConnectio,
                CommandText = "sp_insertar_Factura",
                CommandType = CommandType.StoredProcedure
            };

            int precio = Convert.ToInt32(Precio);
            int cantidad = Convert.ToInt32(Cantidad);
            int monto = Convert.ToInt32(Monto);

            _ = command.Parameters.AddWithValue("@idfactura", id);
            _ = command.Parameters.AddWithValue("@Id_cliente", Id_cliente);
            _ = command.Parameters.AddWithValue("@Nombre_producto", Nombre_producto);
            _ = command.Parameters.AddWithValue("@Precio", precio);
            _ = command.Parameters.AddWithValue("@Cantidad", cantidad);
            _ = command.Parameters.AddWithValue("@Monto", monto);
            _ = command.Parameters.AddWithValue("@Precio_total", Precio_total);
            _ = command.Parameters.AddWithValue("@Empleado", ID_Empleado);
            _ = command.Parameters.AddWithValue("@Fecha_del_Registro", Fecha_del_Registro);
            _ = command.ExecuteNonQuery();
            command.Parameters.Clear();
            _ = conexion.Close();
        }
    }
}
