using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thot_Librery.Conexiones;

namespace Thot_Librery.Codigo_Factura
{
    public class FillData
    {
        private readonly Conexion conexiones = new Conexion();
        private readonly SqlCommand command = new SqlCommand();
        private readonly DataTable datos = new DataTable();
        public DataTable Datos(string Id_Factura)
        {
            int idfactura = Convert.ToInt32(Id_Factura);
            command.Connection = conexiones.Open();
            command.CommandText = "sp_Fill_Data_Factura";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Idfactura", idfactura);
            SqlDataReader leer = command.ExecuteReader();
            datos.Load(leer);
            conexiones.Close();
            return datos;
        }
    }
}
