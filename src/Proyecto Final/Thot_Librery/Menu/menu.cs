namespace Thot_Librery.Menu
{
    public class Menus
    {
        /// <summary>
        /// Muestra un formulario dentro de un panel, limpiando previamente el contenido del panel.
        /// </summary>
        /// <param name="form">Formulario a mostrar.</param>
        /// <param name="panel">Panel donde se mostrará el formulario.</param>
        public void Form_Heredado(Form form, Panel panel)
        {
            if (form == null)
            {
                throw new ArgumentNullException(nameof(form), "El formulario no puede ser nulo.");
            }

            if (panel == null)
            {
                throw new ArgumentNullException(nameof(panel), "El panel no puede ser nulo.");
            }

            Limpiar(panel);

            form.TopLevel = false;
            form.Dock = DockStyle.Fill; // Asegura que el formulario se ajuste al tamaño del panel
            form.FormBorderStyle = FormBorderStyle.None; // Elimina bordes para una mejor integración
            panel.Controls.Add(form);
            panel.Tag = form;
            form.Show();
        }

        /// <summary>
        /// Limpia todos los controles dentro de un panel.
        /// </summary>
        /// <param name="panel">Panel a limpiar.</param>
        public void Limpiar(Panel panel)
        {
            if (panel == null)
            {
                throw new ArgumentNullException(nameof(panel), "El panel no puede ser nulo.");
            }

            panel.Controls.Clear();
        }
    }
}
