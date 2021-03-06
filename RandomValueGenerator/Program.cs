﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using RandomValueGenerator.Model;
using RandomValueGenerator.View;

namespace RandomValueGenerator
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseAdapter a = new DatabaseAdapter();
            DataModel model = new DataModel(a);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ValueView(model, model));
        }
    }
}
