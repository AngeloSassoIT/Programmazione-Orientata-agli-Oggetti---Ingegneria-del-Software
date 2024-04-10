using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaGioco
{
    public class Giocatore
    {
      
        public int ID;
        public String nome;
        public List<Carte> listaGiocatore;
        public Boolean turno;
        public Mazzo mazzo;
        public Tavolo tavolo;
        public Carte cartaGiocata;
        Carte daPrendere;
    
        public int punteggio;
        public Giocatore(int ID,Mazzo mazzo,Tavolo tavolo)
        {
            this.ID = ID;
            this.turno = false;
            this.listaGiocatore = new List<Carte>();
            this.mazzo = mazzo;
            this.tavolo = tavolo;
            this.punteggio = 0;
           // this.a = 0;
        }
        public Giocatore(String nome,Mazzo mazzo,Tavolo tavolo)
        {
            this.nome = nome;
            this.turno = false;
            this.listaGiocatore = new List<Carte>();
            this.mazzo = mazzo;
            this.tavolo = tavolo;
            this.punteggio = 0;
        }
        public void setTurnoGiocatore(Boolean turno)
        {
            this.turno = turno;
        }
        public Boolean getTurnoGiocatore()
        {
            return this.turno;
        }
        
        //funzione che seleziona una carta dal proprio mazzo
        //funzione che prende tre carte dal mazzo principale(ALL'INIZIO)
        public void prendiTreCarte()
        {
            Carte daPrendere;
            for(int i = 0; i < 3; i++)
            {
                daPrendere = prendiUnaCarta();
                Console.WriteLine(" "+ID+" prende " + daPrendere.getnomeCompleto());
            }           

            
        }
        //funzione che prende una carta dal mazzo principale(OGNI PRESA)
        public Carte prendiUnaCarta()
        {
            if (this.mazzo.listaMazzo.Count == 0)
            {
                         //non posso prendere la prossima carta quindi 
            }
            else {
                daPrendere = this.mazzo.listaMazzo.FirstOrDefault();          ///oppure provare con [0] o [1]
                this.mazzo.listaMazzo.Remove(daPrendere);
                this.listaGiocatore.Add(daPrendere);
            }
            return daPrendere;
        }
        //funzione che butta una carta dal proprio mazzo
        public Carte scegliCarta(Carte carte)
        {
            this.cartaGiocata = carte;
            return cartaGiocata;
        }
        public void buttaCarta()
        {
            
            //se numTurno è = 0...all'inizio
            if(tavolo.numTurno == 0)
            {
                tavolo.setPrimo(this);
                tavolo.numTurno++;
                this.listaGiocatore.Remove(cartaGiocata);
            }else if(tavolo.numTurno == 1)
            {

                tavolo.setSecondo(this);
                this.listaGiocatore.Remove(cartaGiocata);
                //e si fa il confronto
                
                this.tavolo.confrontaCarte(tavolo.primo, tavolo.secondo);
            }
                    
        }
        public void stampaListaGiocatore()
        {            
            for(int i = 0; i < this.listaGiocatore.Count; i++)
            {
                Console.WriteLine(" "+listaGiocatore[i].getnomeCompleto());
            }
           
        }
        public int getPunteggio()
        {
            return punteggio;
        }
    }
}
