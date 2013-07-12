using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoIndustriasJimenez
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Bienvenido());

            Bienvenido ventana1 = new Bienvenido();
            if (ventana1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ventana1.Close();
                Application.Run(new VerEmpleados());
            }
        }
    }
}
