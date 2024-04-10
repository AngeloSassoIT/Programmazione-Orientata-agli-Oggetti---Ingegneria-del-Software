using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace briscolax2
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //dichiaro i model 
            Application.SetCompatibleTextRenderingDefault(false);
            
            //dichiaro la view
            Home home = new Home();
           
            Application.EnableVisualStyles();

            Application.Run(home);
         
        }
    }
}
