using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proecto_Final
{
    public static class conecion
    {
        public static DataSet Ejecutar(string cmd)
        {


            SqlConnection com = new SqlConnection("");
            com.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter dp = new SqlDataAdapter(cmd, com);
            dp.Fill(ds);
            com.Close();
            return ds;



        }
    }
}
