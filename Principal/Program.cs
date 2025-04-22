using System;
using System.Windows.Forms;

namespace Principal
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new ActualizarProducto());
=======
            Application.Run(new Principal());
>>>>>>> mariana
        }
    }
}

