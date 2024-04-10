using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicaGioco
{
    public class Tavolo
    {
        public Giocatore vincitore;
        public Giocatore perdente;
        public Giocatore primo;
        public Giocatore secondo;
        public int numTurno;            
        public int sommaPresa;
        public Tavolo()
        {

            this.numTurno = 0;
            this.sommaPresa = 0;
        }
        //ritorna il giocatore che vince

        public void setPrimo(Giocatore p)
        {
            primo = p;
        }
        public void setSecondo(Giocatore p)
        {
            secondo = p;
        }
        public void confrontaCarte(Giocatore primo, Giocatore secondo)
        {
            Console.WriteLine(" " + primo.cartaGiocata.getnomeCompleto() + " " + primo.cartaGiocata.getValue());
            Console.WriteLine(" " + secondo.cartaGiocata.getnomeCompleto() + " " + secondo.cartaGiocata.getValue());
            sommaPresa = primo.cartaGiocata.getValue() + secondo.cartaGiocata.getValue();
            //SEMI DIVERSI

            if (primo.cartaGiocata.getSeme() != secondo.cartaGiocata.getSeme())
            {
               // MessageBox.Show("SEMI DIVERSI");   
                //CASO CHE SOLO LA PRIMA E' BRISCOLA
                if ((primo.cartaGiocata.getBriscola()) && (secondo.cartaGiocata.getBriscola() == false))
                {
                  //  MessageBox.Show("PRIMA BRISCOLA SECONDA NO");
                    //vince la prima carta
                    Console.WriteLine("Vince " + primo.ID);
                    primo.punteggio += sommaPresa;
                    vincitore = primo;
                    
                    perdente = secondo;
                }
                //CASO CHE SOLO LA SECONDA E'BRISCOLA
                else if ((primo.cartaGiocata.getBriscola() == false) && (secondo.cartaGiocata.getBriscola()))
                {
                    //vince la seconda carta
                 //   MessageBox.Show("PRIMA no SECONDA Briscola");
                    Console.WriteLine("Vince " + secondo.ID);
                    secondo.punteggio += sommaPresa;
                    vincitore = secondo;
                    
                    perdente = primo;
                }
                //CASO CHE ENTRAMBE NON SONO BRISCOLE
                else if ((primo.cartaGiocata.getBriscola() == false) && (secondo.cartaGiocata.getBriscola() == false))
                {
                    //vince la prima carta
                  //  MessageBox.Show("PRIMA no SECONDA NO");
                    Console.WriteLine("Vince " + primo.ID);
                    primo.punteggio += sommaPresa;
                    vincitore = primo;
                    
                    perdente = secondo;
                }


            }
            //SEMI UGUALI
            else if (primo.cartaGiocata.getSeme() == secondo.cartaGiocata.getSeme())
            {
              //  MessageBox.Show("SEMI UGUALI");
                //CASO CHE ENTRAMBE SONO BRISCOLE---------> vince il valore più grande<----------CASO CHE ENTRAMBE NON SONO BRISCOLE
                if (primo.cartaGiocata.getBriscola() && secondo.cartaGiocata.getBriscola())
                {
                  //  MessageBox.Show("ENTRAMBE BRISCOLE");
                    if (primo.cartaGiocata.getValue() > secondo.cartaGiocata.getValue())
                    {
                        //vince il primo
                        
                        Console.WriteLine("Vince " + primo.ID);
                        primo.punteggio += sommaPresa;
                        vincitore = primo;
                        
                        perdente = secondo;
                    }
                    else if (primo.cartaGiocata.getValue() < secondo.cartaGiocata.getValue())
                    {
                        //vince il secondo
                        
                        Console.WriteLine("Vince " + secondo.ID);
                        secondo.punteggio += sommaPresa;
                        vincitore = secondo;
                       
                        perdente = primo;
                    }
                    else if (primo.cartaGiocata.getValue() == secondo.cartaGiocata.getValue())
                    {
                     //   MessageBox.Show("PRIMA = SECONDA");
                        //nel caso siano uguali i valori e i semi uguali....vuol dire che ci troviamo in presenza di due lisci
                        //tra due lisci vince quello per distinguerlo con numCarta più alto...
                        if (primo.cartaGiocata.getnumCarta() > secondo.cartaGiocata.getnumCarta())
                        {
                            //vince il primo
                           
                            Console.WriteLine("Vince " + primo.ID);
                            primo.punteggio += sommaPresa;
                            vincitore = primo;
                           
                            perdente = secondo;
                        }
                        else if (primo.cartaGiocata.getnumCarta() < secondo.cartaGiocata.getnumCarta())
                        {
                            //vince il secondo
                           
                            Console.WriteLine("Vince " + secondo.ID);
                            secondo.punteggio += sommaPresa;
                            vincitore = secondo;
                           
                            perdente = primo;
                        }
                    }

                }
                else if (primo.cartaGiocata.getBriscola() == false && secondo.cartaGiocata.getBriscola() == false)
                {
                   // MessageBox.Show("PRIMO no,SECONDA no");
                    if (primo.cartaGiocata.getValue() > secondo.cartaGiocata.getValue())
                    {
                        
                        //vince il primo
                        Console.WriteLine("Vince " + primo.ID);
                        primo.punteggio += sommaPresa;
                        vincitore = primo;
                        
                        perdente = secondo;
                    }
                    else if (primo.cartaGiocata.getValue() < secondo.cartaGiocata.getValue())
                    {
                       
                        //vince il secondo
                        Console.WriteLine("Vince " + secondo.ID);
                        secondo.punteggio += sommaPresa;
                        vincitore = secondo;
                        
                        perdente = primo;
                    }
                    else if (primo.cartaGiocata.getValue() == secondo.cartaGiocata.getValue())
                    {
                       
                        //nel caso siano uguali i valori e i semi uguali....vuol dire che ci troviamo in presenza di due lisci
                        //tra due lisci vince quello per distinguerlo con numCarta più alto...
                        if (primo.cartaGiocata.getnumCarta() > secondo.cartaGiocata.getnumCarta())
                        {
                            
                            //vince il primo
                            Console.WriteLine("Vince " + primo.ID);
                            primo.punteggio += sommaPresa;
                            vincitore = primo;
                           
                            perdente = secondo;
                        }
                        else if (primo.cartaGiocata.getnumCarta() < secondo.cartaGiocata.getnumCarta())
                        {
                            //vince il secondo
                            
                            Console.WriteLine("Vince " + secondo.ID);
                            secondo.punteggio += sommaPresa;
                            vincitore = secondo;
                           
                            perdente = primo;
                        }
                    }
                }
                
               
            }
            //funzione che ogni volta che un giocatore tira la carta aumenta un contatore numTurno...
            //appena numTurno == 2 allora vorrà dire che 
            this.numTurno = 0;
           
            vincitore.setTurnoGiocatore(true);
            perdente.setTurnoGiocatore(false);

           

        }
    }
}
