using Thot_Librery.Conexiones;
namespace Thot_Librery.Codigo_Factura
{
    public class Agregar_Factura
    {
        public void Agregar(int id, int Id_cliente, string Nombre_producto, string Precio, string Cantidad, string Monto, string Precio_total, int ID_Empleado, string Fecha_del_Registro)
        {
            using Conexion conexion = new();
            using SqlConnection conn = conexion.Open();
            using SqlCommand command = new()
            {
                Connection = conn,
                CommandText = "sp_insertar_Factura",
                CommandType = CommandType.StoredProcedure
            };

            double precio = Convert.ToDouble(Precio);
            double cantidad = Convert.ToDouble(Cantidad);
            double monto = Convert.ToDouble(Monto);

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
        }
    }
}
