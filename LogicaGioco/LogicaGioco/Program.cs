using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaGioco
{
    class Program
    {
        static void Main(string[] args)
        {
            Partita partita = new Partita();
            partita.inizializzaPartita();
            partita.inizioGioco();
           
          
            Console.ReadKey();
           
        }
    }
}
