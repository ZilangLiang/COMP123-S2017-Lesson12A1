using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name:Zilang Liang
 * Date: August 1, 2017
 * Description: This is a Demo Application to showcase User interface
 * version 0.1 - created the project
 */

namespace COMP123_S2017_Lesson12A
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Demo());
        }
    }
}
