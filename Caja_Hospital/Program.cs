using Caja_Hospital.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja_Hospital
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormMainMenu mainForm = new FormMainMenu();
            mainForm.Hide(); // Ocultar el Main Form al principio

            Inicio loginForm = new Inicio();
            loginForm.MainForm = mainForm; // Establece la referencia al Main Form
            Application.Run(loginForm); // Inicia el formulario de inicio
        }

    }
}
