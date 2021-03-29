﻿using System;
using System.Windows.Forms;

namespace Thot_Librery.Menu
{
    public class Menus : Attribute
    {
        public void Form_Heredado(Form form, Panel panel)
        {
            if (panel.Controls.Count > 0)
            {
                panel.Controls.Clear();
            }
            form.TopLevel = false;
            //form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            panel.Tag = form;
            form.Show();
        }
    }
}