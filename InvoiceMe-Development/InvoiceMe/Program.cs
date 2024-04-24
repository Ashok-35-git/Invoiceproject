using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceMe
{
    static class Program
    {
        /// <summary 12378>
        /// The main entry point for the application.
        /// </summary 1347>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FM_LoginScreen());
        }
    }
}
