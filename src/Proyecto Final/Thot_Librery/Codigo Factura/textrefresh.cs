﻿using System.Runtime.Versioning;
using Thot_Librery.Conexiones;

namespace Thot_Librery.Codigo_Factura
{
    [AttributeUsage(AttributeTargets.All)]
    public class TextrefreshAttribute : Attribute
    {
        [SupportedOSPlatform("windows6.1")]
        public void RefreshText(TextBox text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text), "El parámetro 'text' no puede ser nulo.");
            }

            AutoCompleteStringCollection collection = new();

            try
            {
                using Conexion conexion = new();
                using SqlConnection conn = conexion.Open();
                using SqlCommand command = new("sp_textrefresh", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string? value = reader["Nom_cli"]?.ToString();
                        if (!string.IsNullOrEmpty(value))
                        {
                            collection.Add(value);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones (puedes registrar el error o mostrar un mensaje al usuario)
                MessageBox.Show($"Error al refrescar el texto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            text.AutoCompleteCustomSource = collection;
        }
    }
}
