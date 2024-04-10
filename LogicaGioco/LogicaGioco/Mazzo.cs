using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaGioco
{
   public class Mazzo
    {
        Carte carte;
        public List<Carte> listaMazzo;
        Random random;
        public Carte briscolaMazzo;
        public Mazzo()
        {            
            this.listaMazzo = new List<Carte>();
            this.random = new Random();           
        }
        public void generaMazzo()
        {
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    //crea una nuova istanza di tipo carta
                    if(j == 2 || j == 4 || j == 5 || j == 6 || j == 7)
                    {
                        this.carte = new CarteLisci(i,j);
                        this.carte.setCarta();
                        this.carte.setNomeSeme();
                        this.carte.setNomeCompleto();
                    }
                    if (j == 1|| j== 3 || j == 8 || j == 9 || j == 10)
                    {
                        this.carte = new CartePunti(i, j);
                        this.carte.setCarta();
                        this.carte.setNomeSeme();
                        this.carte.setNomeCompleto();
                    }
                    this.listaMazzo.Add(carte);
                }
            }
        }
        //funzione mescolaMazzo
        public void mescolaMazzo()
        {
            
            
            int posizCasuale;
            for (int i = this.listaMazzo.Count; i > 0; i--)
            {
                posizCasuale = random.Next(i - 1);
                Carte daCambiare;
                try
                {
                    daCambiare = this.listaMazzo[i];
                    this.listaMazzo[i] = this.listaMazzo[posizCasuale];
                    this.listaMazzo[posizCasuale] = daCambiare;
                }
                catch (System.ArgumentOutOfRangeException)
                {

                }
            }
            //scambio di posto le carte..
        }
        public void impostaBriscola()
        {
            int a = 0;
            briscolaMazzo = this.listaMazzo.FirstOrDefault();
            
            this.listaMazzo.Remove(briscolaMazzo);
            this.listaMazzo.Add(briscolaMazzo);
            
            Console.WriteLine(" BRISCOLA "+briscolaMazzo.getnomeCompleto());
            
            
            for(int i = 0; i < this.listaMazzo.Count; i++)
            { 
                Carte corrente = this.listaMazzo[i];
                if(corrente.getSeme() == briscolaMazzo.getSeme())
                {
                    this.listaMazzo[i].setBriscola();
                    Console.WriteLine(" " +listaMazzo[i].getnomeCompleto());
                    a++;
                    
                }
            }
            Console.WriteLine("Esistono " + 
                a + " briscole");
        }
        public void stampaMazzo()
        {
            for(int i = 0; i < listaMazzo.Count; i++)
            {
                Console.WriteLine(" " + listaMazzo[i].getnomeCompleto());
            }
        }
    }
}
