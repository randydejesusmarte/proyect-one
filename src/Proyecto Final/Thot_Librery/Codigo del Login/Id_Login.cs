﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thot_Librery.Conexiones;

namespace Thot_Librery.Codigo_del_Login
{
    public class Id_Login : Attribute
    {
        private readonly Conexion conexion = new Conexion();
        public int get_id(string Nombre, string Contraceña)
        {
            try
            {
                conexion.Open();
                SqlCommand command = new SqlCommand("sp_get_id", conexion.SqlConnectio);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@Clave", Contraceña);
                SqlDataReader DataReader = command.ExecuteReader();
                if (DataReader.Read())
                {
                    return DataReader.GetInt32(0);
                }
            }
            catch(Exception es)
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