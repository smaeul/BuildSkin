using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BuildSkin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); //Must be here to exist before Builder object is created
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fBuildSkin());
        }
    }
}
