using Thot_Librery.Conexiones;

namespace Thot_Librery.Codigo_Factura
{
    public class Agregar_Factura
    {
        private readonly Conexion conexion = new Conexion();
        public void Agregar(int id, int Id_cliente, string Nombre_producto, string Precio, string Cantidad, string Monto, string Precio_total, int ID_Empleado, string Fecha_del_Registro)
        {
            conexion.Open();
            SqlCommand command = new SqlCommand
            {
                Connection = conexion.SqlConnectio,
                CommandText = "sp_insertar_Factura",
                CommandType = CommandType.StoredProcedure
            };

            int precio = Convert.ToInt32(Precio);
            int cantidad = Convert.ToInt32(Cantidad);
            int monto = Convert.ToInt32(Monto);

            command.Parameters.AddWithValue("@idfactura", id);
            command.Parameters.AddWithValue("@Id_cliente", Id_cliente);
            command.Parameters.AddWithValue("@Nombre_producto", Nombre_producto);
            command.Parameters.AddWithValue("@Precio", precio);
            command.Parameters.AddWithValue("@Cantidad", cantidad);
            command.Parameters.AddWithValue("@Monto", monto);
            command.Parameters.AddWithValue("@Precio_total", Precio_total);
            command.Parameters.AddWithValue("@Empleado", ID_Empleado);
            command.Parameters.AddWithValue("@Fecha_del_Registro", Fecha_del_Registro);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            conexion.Close();
        }
    }
}
