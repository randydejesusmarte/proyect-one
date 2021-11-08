using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thot_Librery.Conexiones;

namespace Thot_Librery.Entrada
{
    public class Auto_increment : Attribute
    {
        private readonly Conexion Conexiones = new Conexion();

        public int Cont()
        {
            try
            {
                Conexiones.Open();
                SqlCommand command = new SqlCommand("SP_auto_increment_Id", Conexiones.SqlConnectio);
                command.CommandType = CommandType.StoredProcedure;
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
