using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turnos.Forms;

namespace Turnos
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //para poner el desarrollo en el form deseado
            //Application.Run(new AreaSolicitada());
            Application.Run(new frmInicio());
           // Application.Run(new frmRegistro());

        }
    }
}
