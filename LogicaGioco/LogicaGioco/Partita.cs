using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaGioco
{
    public class Partita
    {
        public Tavolo tavolo;
        Random random;
        public Mazzo mazzo;
        public Giocatore g1;
        public Giocatore g2;
        public int cambio;
        public Giocatore corrente;
        int turnoIniziale;
        public Partita()
        {
            tavolo = new Tavolo();
            mazzo = new Mazzo();
            g1 = new Giocatore(1, mazzo, tavolo);
            g2 = new Giocatore(2, mazzo, tavolo);
            random = new Random();
            turnoIniziale = 0;
            cambio = 0;

        }
        public void inizializzaPartita()
        {
            //per prima cosa setto il turno di chi starta
            //in maniera random
            turnoIniziale = random.Next(2);
            if (turnoIniziale == 0)
            {
                g1.setTurnoGiocatore(true);
                g2.setTurnoGiocatore(false);
            } else if (turnoIniziale == 1) {
                g1.setTurnoGiocatore(false);
                g2.setTurnoGiocatore(true);
            }
            mazzo.generaMazzo();
            mazzo.mescolaMazzo();
            mazzo.stampaMazzo();
            mazzo.impostaBriscola();
            if (turnoIniziale == 0)
            {
                g1.prendiTreCarte();
                g2.prendiTreCarte();
            } else if (turnoIniziale == 1)
            {
                g2.prendiTreCarte();
                g1.prendiTreCarte();
            }
        }
        //la seguente funzione viene
        //lanciata solo nell'applicazione 
        //da terminale essendo una vera e
        //propria forma di debug
        public void inizioGioco() { 

            while(mazzo.listaMazzo.Count > 0)
            {
                corrente = getGCorrente(g1, g2);
                Console.WriteLine("Tocca a " + corrente.ID);
                //sceglie la carta tra quelle che ha in lista
                Console.WriteLine("inserire 0, 1 o 2 per scegliere " +
                    "una delle carte della lista");
                int index = int.Parse(Console.ReadLine());
                Carte scelta = corrente.scegliCarta(corrente.listaGiocatore[index]);
                Console.WriteLine("hai scelto " + corrente.cartaGiocata.getnomeCompleto());
                Console.WriteLine("hai buttato " + corrente.cartaGiocata.getnomeCompleto());
                corrente.buttaCarta();

                cambio++;
                if (cambio == 1)
                {
                    invertiTurnoG(g1, g2);
                }
                corrente = getGCorrente(g1, g2);
                Console.WriteLine("Tocca a " + corrente.ID);
                //sceglie la carta tra quelle che ha in lista
                Console.WriteLine("inserire 0, 1 o 2 per scegliere una delle carte della lista");
                index = int.Parse(Console.ReadLine());
                scelta = corrente.scegliCarta(corrente.listaGiocatore[index]);
                Console.WriteLine("hai scelto " + corrente.cartaGiocata.getnomeCompleto());
                Console.WriteLine("hai buttato " + corrente.cartaGiocata.getnomeCompleto());
                corrente.buttaCarta();
                //aggiorno il turno e prendo una carta
                corrente = getGCorrente(g1, g2);
                Console.WriteLine("Può prendere una carta " + corrente.ID);
                Carte presaCorr = corrente.prendiUnaCarta();
                Console.WriteLine("" + presaCorr.getnomeCompleto());
                Console.WriteLine("Stampa lista giocatore "+corrente.ID+" corrente :");
                corrente.stampaListaGiocatore();
                invertiTurnoG(g1, g2);
                corrente = getGCorrente(g1,g2);
                presaCorr = corrente.prendiUnaCarta();
                Console.WriteLine("" + presaCorr.getnomeCompleto());
                Console.WriteLine("Stampa lista giocatore " + corrente.ID + " corrente :");
                corrente.stampaListaGiocatore();
                invertiTurnoG(g1, g2);
                cambio = 0;
            }
            fineGioco();
            

        }
        private void fineGioco()
        {
            if(g1.getPunteggio() > g2.getPunteggio())
            {
                Console.WriteLine("Vince " + g1.ID + " per " + g1.getPunteggio() + "a " + g2.getPunteggio());
            }else if (g1.getPunteggio() < g2.getPunteggio())
            {
                Console.WriteLine("Vince " + g2.ID + " per " + g2.getPunteggio() + "a " + g1.getPunteggio());
            }else if(g1.getPunteggio() == g2.getPunteggio())
            {
                Console.WriteLine("Pareggio " + g1.getPunteggio() + " a " + g2.getPunteggio());
            }
           
        }
        //funzione che ritorna il giocatore che può effettuare la mossa
        public Giocatore getGCorrente(Giocatore g1,Giocatore g2)
        {
            if (g1.getTurnoGiocatore())
            {
                corrente = g1;
            }else if (g2.getTurnoGiocatore())
            {
                corrente = g2;
            }
            return corrente;
        }
        public void invertiTurnoG(Giocatore g1,Giocatore g2)
        {
            if(corrente == g1)
            {
                g1.setTurnoGiocatore(false);
                g2.setTurnoGiocatore(true);
            }else if(corrente == g2)
            {
                g2.setTurnoGiocatore(false);
                g1.setTurnoGiocatore(true);
            }
           
        }
    }
}
