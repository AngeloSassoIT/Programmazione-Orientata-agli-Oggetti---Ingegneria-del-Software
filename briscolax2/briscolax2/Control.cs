using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace briscolax2
{
    public class Control
    {
        public Fine fine;
        public View view;
        LogicaGioco.Carte daButtare;
        LogicaGioco.Carte daPrendere;
        public LogicaGioco.Partita partita;
        public LogicaGioco.Giocatore corrente;
        public LogicaGioco.Giocatore correnteP;
        String coppa = "coppa";
        String retr = "retr";
        public void SetCartaResources(PictureBox image,string nomeCarta)
        {
            switch (nomeCarta)
            {
                case "AssoOro":
                    image.Image = briscolax2.Properties.Resources.AssoOro;                  
                   
                    break;
                case "AssoCoppe":
                    image.Image = briscolax2.Properties.Resources.AssoCoppe;
                    break;
                case "AssoBastoni":
                    image.Image = briscolax2.Properties.Resources.AssoBastoni;
                    break;
                case "AssoSpade":
                    image.Image = briscolax2.Properties.Resources.AssoSpade;
                    break;
                case "DueOro":
                    image.Image = briscolax2.Properties.Resources.DueOro;
                    break;
                case "DueCoppe":
                    image.Image = briscolax2.Properties.Resources.DueCoppe;
                    break;
                case "DueBastoni":
                    image.Image = briscolax2.Properties.Resources.DueBastoni;
                    break;
                case "DueSpade":
                    image.Image = briscolax2.Properties.Resources.DueSpade;
                    break;
                case "TreOro":
                    image.Image = briscolax2.Properties.Resources.TreOro;
                    break;
                case "TreCoppe":
                    image.Image = briscolax2.Properties.Resources.TreCoppe;
                    break;
                case "TreBastoni":
                    image.Image = briscolax2.Properties.Resources.TreBastoni;
                    break;
                case "TreSpade":
                    image.Image = briscolax2.Properties.Resources.TreSpade;
                    break;
                case "QuattroOro":
                    image.Image = briscolax2.Properties.Resources.QuattroOro;
                    break;
                case "QuattroCoppe":
                    image.Image = briscolax2.Properties.Resources.QuattroCoppe;
                    break;
                case "QuattroBastoni":
                    image.Image = briscolax2.Properties.Resources.QuattroBastoni;
                    break;
                case "QuattroSpade":
                    image.Image = briscolax2.Properties.Resources.QuattroSpade;
                    break;
                case "CinqueOro":
                    image.Image = briscolax2.Properties.Resources.CinqueOro;
                    break;
                case "CinqueCoppe":
                    image.Image = briscolax2.Properties.Resources.CinqueCoppe;
                    break;
                case "CinqueBastoni":
                    image.Image = briscolax2.Properties.Resources.CinqueBastoni;
                    break;
                case "CinqueSpade":
                    image.Image = briscolax2.Properties.Resources.CinqueSpade;
                    break;
                case "SeiOro":
                    image.Image = briscolax2.Properties.Resources.SeiOro;
                    break;
                case "SeiCoppe":
                    image.Image = briscolax2.Properties.Resources.SeiCoppe;
                    break;
                case "SeiBastoni":
                    image.Image  = briscolax2.Properties.Resources.SeiBastoni;
                    break;
                case "SeiSpade":
                    image.Image = briscolax2.Properties.Resources.SeiSpade;
                    break;
                case "SetteOro":
                    image.Image = briscolax2.Properties.Resources.SetteOro;
                    break;
                case "SetteCoppe":
                    image.Image = briscolax2.Properties.Resources.SetteCoppe;
                    break;
                case "SetteBastoni":
                    image.Image = briscolax2.Properties.Resources.SetteBastoni;
                    break;
                case "SetteSpade":
                    image.Image  = briscolax2.Properties.Resources.SetteSpade;
                    break;
                case "DonnaOro":
                    image.Image = briscolax2.Properties.Resources.DonnaOro;
                    break;
                case "DonnaCoppe":
                    image.Image = briscolax2.Properties.Resources.DonnaCoppe;
                    break;
                case "DonnaBastoni":
                    image.Image = briscolax2.Properties.Resources.DonnaBastoni;
                    break;
                case "DonnaSpade":
                    image.Image = briscolax2.Properties.Resources.DonnaSpade;
                    break;
                case "CavalloOro":
                    image.Image = briscolax2.Properties.Resources.CavalloOro;
                    break;
                case "CavalloCoppe":
                    image.Image = briscolax2.Properties.Resources.CavalloCoppe;
                    break;
                case "CavalloBastoni":
                    image.Image = briscolax2.Properties.Resources.CavalloBastoni;
                    break;
                case "CavalloSpade":
                    image.Image = briscolax2.Properties.Resources.CavalloSpade;
                    break;
                case "ReOro":
                    image.Image = briscolax2.Properties.Resources.ReOro;
                    break;
                case "ReCoppe":
                    image.Image = briscolax2.Properties.Resources.ReCoppe;
                    break;
                case "ReBastoni":
                    
                    image.Image = briscolax2.Properties.Resources.ReBastoni;
                    break;
                case "ReSpade":
                    image.Image = briscolax2.Properties.Resources.ReSpade;
                    break;
                case "retr":
                    image.Image = briscolax2.Properties.Resources.retr;
                    break;
                case "coppa":
                    image.Image = briscolax2.Properties.Resources.coppa;
                    break;
                case "amicizia":
                    image.Image = briscolax2.Properties.Resources.amicizia;
                    break;
            }

        }
        public Control(View view, LogicaGioco.Partita partita)
        {
            this.view = view;
            this.partita = partita;
            //   view.briscolaGui.Image = Image.FromFile(indexLocation + partita.mazzo.briscolaMazzo.getnomeCompleto() + ".png");
            SetCartaResources(view.briscolaGui,partita.mazzo.briscolaMazzo.getnomeCompleto());
            
            view.label1.Text = "Giocatore 1";
            view.label2.Text = "Giocatore 2";
            SetCartaResources(view.mazzoGui, retr);

        }

        public void settaCarteGui()
        {
            //controllo se il giocatore è il giocatore1

            corrente = partita.getGCorrente(partita.g1, partita.g2);
            //se giocatore1 è il giocatore corrente
            if (corrente == partita.g1)
            {
                //controllo quante carte ha in mano il giocatore, precisamente se ne hameno di 3
                if (partita.g1.listaGiocatore.Count < 3)
                {
                    //controllo se il giocatore ha 2 carte in mano
                    if (partita.g1.listaGiocatore.Count == 2)
                    {   //setto le immagini da visualizzare
                        SetCartaResources(view.carta1G1, partita.g1.listaGiocatore[0].getnomeCompleto());
                        SetCartaResources(view.carta2G1, partita.g1.listaGiocatore[1].getnomeCompleto());
                        view.carta3G1.Image = null;
                    }
                    //controllo se il giocatore ha 1 carta in mano
                    else if (partita.g1.listaGiocatore.Count == 1)
                    {   //setto le immagini da visualizzare
                        SetCartaResources(view.carta1G1, partita.g1.listaGiocatore[0].getnomeCompleto());
                      
                        view.carta2G1.Image = null;
                        view.carta3G1.Image = null;
                    }
                    //controllo se il giocatore non ha carte in mano
                    else if (partita.g1.listaGiocatore.Count == 0)
                    {
                        //setto le immagini da visualizzare
                        view.carta1G1.Image = null;
                        view.carta2G1.Image = null;
                        view.carta3G1.Image = null;

                    }

                }
                //controllo se il giocatore ha 3 carte in mano
                else
                {
                    //setto le immagini da visualizzare
                    SetCartaResources(view.carta1G1, partita.g1.listaGiocatore[0].getnomeCompleto());
                    SetCartaResources(view.carta2G1, partita.g1.listaGiocatore[1].getnomeCompleto());
                    SetCartaResources(view.carta3G1, partita.g1.listaGiocatore[2].getnomeCompleto());
                    
                }

            }
            //controllo se il giocatore è diverso dal corrente
            else if (corrente != partita.g1)
            {
                //controllo se il giocatore 1 ha meno di 3 carte
                if (partita.g1.listaGiocatore.Count < 3)
                {
                    //se ha 2 carte
                    if (partita.g1.listaGiocatore.Count == 2)
                    {   //setto le immagini da visualizzare
                        view.carta3G1.Image = null;
                        SetCartaResources(view.carta1G1, retr);
                        SetCartaResources(view.carta2G1, retr);

                    }
                    //se ha 1 carta
                    if (partita.g1.listaGiocatore.Count == 1)
                    {   //setto le immagini da visualizzare
                        SetCartaResources(view.carta1G1, retr);                       
                        view.carta2G1.Image = null;
                        view.carta3G1.Image = null;
                    }
                    //se non ha carte
                    if (partita.g1.listaGiocatore.Count == 0)
                    {   //setto le immagini da visualizzare
                        view.carta1G1.Image = null;
                        view.carta2G1.Image = null;
                        view.carta3G1.Image = null;
                    }

                }
                //se ha 3 carte
                else
                {   //setto le immagini da visualizzare
                    SetCartaResources(view.carta1G1, retr);
                    SetCartaResources(view.carta2G1, retr);
                    SetCartaResources(view.carta3G1, retr);
                }

            }
            // se il giocatore è giocatore2


            //se è anche il giocatore corrente             
            if (corrente == partita.g2)
            {   //se ha meno di 3 carte
                if (partita.g2.listaGiocatore.Count < 3)
                {
                    //se ha 2 carte 
                    if (partita.g2.listaGiocatore.Count == 2)
                    {   //setto le immagini da visualizzare
                        SetCartaResources(view.carta1G2, partita.g2.listaGiocatore[0].getnomeCompleto());
                        SetCartaResources(view.carta2G2, partita.g2.listaGiocatore[1].getnomeCompleto());
                     
                        view.carta3G2.Image = null;
                    }
                    //se ha 1 carta
                    else if (partita.g2.listaGiocatore.Count == 1)
                    {
                        //setto le immagini da vsualizzare
                        SetCartaResources(view.carta1G2, partita.g2.listaGiocatore[0].getnomeCompleto());
                        view.carta2G2.Image = null;
                        view.carta3G2.Image = null;
                    }
                    //se non ha carte
                    else if (partita.g2.listaGiocatore.Count == 0)
                    {
                        //setto le immagini da visualizzare
                        view.carta1G2.Image = null;
                        view.carta2G2.Image = null;
                        view.carta3G2.Image = null;
                    }

                }
                //se ha invece 3 carte
                else
                {
                    //setto le immagini da visualizzare
                    SetCartaResources(view.carta1G2, partita.g2.listaGiocatore[0].getnomeCompleto());
                    SetCartaResources(view.carta2G2, partita.g2.listaGiocatore[1].getnomeCompleto());
                    SetCartaResources(view.carta3G2, partita.g2.listaGiocatore[2].getnomeCompleto());
                   
                }

                //se il giocatore non è quello corrente
            }
            else if (corrente != partita.g2)
            {   //se ha meno di 3 carte                 
                if (partita.g1.listaGiocatore.Count < 3)
                {
                    //se ha 2 carte in mano
                    if (partita.g1.listaGiocatore.Count == 2)
                    {   //setto le immagini da visualizzare
                        SetCartaResources(view.carta1G2, retr);
                        SetCartaResources(view.carta2G2, retr);
                        view.carta3G2.Image = null;

                    }
                    //se ho 1 carta
                    if (partita.g1.listaGiocatore.Count == 1)
                    {   //setto le immagini da visualizzare
                        SetCartaResources(view.carta1G2, retr);
                        view.carta2G2.Image = null;
                        view.carta3G2.Image = null;
                    }
                    //se non ho carte
                    if (partita.g1.listaGiocatore.Count == 0)
                    {
                        //setto le immagini da visualizzare
                        view.carta1G2.Image = null;
                        view.carta2G2.Image = null;
                        view.carta3G2.Image = null;
                    }

                }
                //se ha 3 carte
                else
                {
                    //setto le immagini da visualizzare
                    SetCartaResources(view.carta1G2, retr);
                    SetCartaResources(view.carta2G2, retr);
                    SetCartaResources(view.carta3G2, retr);
                }
            }


        
        }
        public void settaControlli()
        {
            view.carta3G2.MouseClick += (s, es) =>
            {
                if (corrente == partita.g2)
                {
                    //scelgo la carta rappresentata dalla picturebox                  
                    daButtare = corrente.scegliCarta(corrente.listaGiocatore[2]);
                    //aggiorno il view
                    view.cartaButtataG2.Image = view.carta3G2.Image;
                    view.carta3G2.Image = null;
                    //System.Threading.Thread.Sleep(3000);
                    //se ha già tirato il primo giocatore
                    if (partita.tavolo.numTurno == 1)
                    {
                        //butto la carta selezionata e partirà il confronto
                        corrente.buttaCarta();
                        // setto adesso il giocatore corrente
                        corrente = partita.getGCorrente(partita.tavolo.vincitore, partita.tavolo.perdente);
                        //se il mazzo non ha più carte
                        if (partita.mazzo.listaMazzo.Count == 0)
                        {
                            //aggiorno view
                            view.carta1G2.Image = null;
                            view.cartaButtataG1.Image = null;
                            view.cartaButtataG2.Image = null;
                            view.briscolaGui.Image = null;

                            MessageBox.Show("Cambio turno a giocatore " + corrente.ID);

                            
                            //aggiorno view
                            settaCarteGui();
                            finePartita();

                        }
                        //se invece il mazzo contiene ancora carte e non è quindi vuoto
                        else
                        {
                            //prende una carta dal mazzo il giocatore corrente
                            daPrendere = corrente.prendiUnaCarta();
                            //prende una carta dal mazzo il giocatore che ha perso nel turno precedente
                            correnteP = partita.tavolo.perdente;
                            daPrendere = correnteP.prendiUnaCarta();
                            //aggiorno view
                            view.cartaButtataG2.Image = null;
                            view.cartaButtataG1.Image = null;

                        }
                        //aggiorno view passando ai label i punteggi dei giocatori
                        view.label3.Text = "" + partita.g1.getPunteggio();
                        view.label4.Text = "" + partita.g2.getPunteggio();
                        //setto giocatore corrente
                        corrente = partita.getGCorrente(corrente, correnteP);
                        //setto le immagini da visualizzare aggiornando il view
                        SetCartaResources(view.carta1G2, retr);
                        SetCartaResources(view.carta2G2, retr);
                        SetCartaResources(view.carta3G2, retr);
                        MessageBox.Show("Cambio turno a giocatore " + corrente.ID);
                        //System.Threading.Thread.Sleep(3000);
                        settaCarteGui();


                    }
                    //se ancora si sta tirando per primo
                    else if (partita.tavolo.numTurno == 0)
                    {
                        //setto il giocatore corrente della partita
                        corrente = partita.getGCorrente(partita.g1, partita.g2);
                        //butto la carta selezionata
                        corrente.buttaCarta();
                        //inverto il turno del giocatore
                        partita.invertiTurnoG(partita.g1, partita.g2);
                        //setto nuovamente il giocatore corrente della partita 
                        corrente = partita.getGCorrente(partita.g1, partita.g2);
                        //visualizza e aggiorna view
                        SetCartaResources(view.carta1G2, retr);
                        SetCartaResources(view.carta2G2, retr);
                        SetCartaResources(view.carta3G2, retr);

                        MessageBox.Show("Cambio turno a giocatore " + corrente.ID);
                        //System.Threading.Thread.Sleep(3000);
                        settaCarteGui();


                    }
                }
            };
            view.carta2G2.MouseClick += (s, es) =>
            {
                if (corrente == partita.g2)
                {
                    //scelgo la carta rappresentata dalla picturebox                  
                    daButtare = corrente.scegliCarta(corrente.listaGiocatore[1]);
                    //aggiorno il view
                    view.cartaButtataG2.Image = view.carta2G2.Image;
                    view.carta2G2.Image = null;
                    //System.Threading.Thread.Sleep(3000);
                    //se ha già tirato il primo giocatore
                    if (partita.tavolo.numTurno == 1)
                    {
                        //butto la carta selezionata e partirà il confronto
                        corrente.buttaCarta();
                        // setto adesso il giocatore corrente
                        corrente = partita.getGCorrente(partita.tavolo.vincitore, partita.tavolo.perdente);
                        //se il mazzo non ha più carte
                        if (partita.mazzo.listaMazzo.Count == 0)
                        {
                            //aggiorno view
                            view.carta2G2.Image = null;
                            view.cartaButtataG1.Image = null;
                            view.cartaButtataG2.Image = null;
                            view.briscolaGui.Image = null;

                            MessageBox.Show("Cambio turno a giocatore " + corrente.ID);

                            //Addormento il thread per 3 secondi dando quindi il tempo all'avversario per 
                            //posizionarsi davanti lo schermo senza guardare le carte dell'altro giocatore
                            //System.Threading.Thread.Sleep(3000);
                            //aggiorno view
                            settaCarteGui();
                            finePartita();

                        }
                        //se invece il mazzo contiene ancora carte e non è quindi vuoto
                        else
                        {
                            //prende una carta dal mazzo il giocatore corrente
                            daPrendere = corrente.prendiUnaCarta();
                            //prende una carta dal mazzo il giocatore che ha perso nel turno precedente
                            correnteP = partita.tavolo.perdente;
                            daPrendere = correnteP.prendiUnaCarta();
                            //aggiorno view
                            view.cartaButtataG2.Image = null;
                            view.cartaButtataG1.Image = null;

                        }
                        //aggiorno view passando ai label i punteggi dei giocatori
                        view.label3.Text = "" + partita.g1.getPunteggio();
                        view.label4.Text = "" + partita.g2.getPunteggio();
                        //setto giocatore corrente
                        corrente = partita.getGCorrente(corrente, correnteP);
                        //setto le immagini da visualizzare aggiornando il view
                        SetCartaResources(view.carta1G2, retr);
                        SetCartaResources(view.carta2G2, retr);
                        SetCartaResources(view.carta3G2, retr);

                        MessageBox.Show("Cambio turno a giocatore " + corrente.ID);
                        //System.Threading.Thread.Sleep(3000);
                        settaCarteGui();


                    }
                    //se ancora si sta tirando per primo
                    else if (partita.tavolo.numTurno == 0)
                    {
                        //setto il giocatore corrente della partita
                        corrente = partita.getGCorrente(partita.g1, partita.g2);
                        //butto la carta selezionata
                        corrente.buttaCarta();
                        //inverto il turno del giocatore
                        partita.invertiTurnoG(partita.g1, partita.g2);
                        //setto nuovamente il giocatore corrente della partita 
                        corrente = partita.getGCorrente(partita.g1, partita.g2);
                        //visualizza e aggiorna view

                        SetCartaResources(view.carta1G2, retr);
                        SetCartaResources(view.carta2G2, retr);

                        SetCartaResources(view.carta3G2, retr);

                        MessageBox.Show("Cambio turno a giocatore " + corrente.ID);
                        //System.Threading.Thread.Sleep(3000);
                        settaCarteGui();

                    }
                }
            };
            view.carta1G2.MouseClick += (s, es) =>
            {
                if (corrente == partita.g2)
                {
                    //scelgo la carta rappresentata dalla picturebox                  
                    daButtare = corrente.scegliCarta(corrente.listaGiocatore[0]);
                    //aggiorno il view
                    view.cartaButtataG2.Image = view.carta1G2.Image;
                    view.carta1G2.Image = null;
                    //System.Threading.Thread.Sleep(3000);
                    //se ha già tirato il primo giocatore
                    if (partita.tavolo.numTurno == 1)
                    {
                        //butto la carta selezionata e partirà il confronto
                        corrente.buttaCarta();
                        // setto adesso il giocatore corrente
                        corrente = partita.getGCorrente(partita.tavolo.vincitore, partita.tavolo.perdente);
                        //se il mazzo non ha più carte
                        if (partita.mazzo.listaMazzo.Count == 0)
                        {
                            //aggiorno view
                            view.carta1G2.Image = null;
                            view.cartaButtataG1.Image = null;
                            view.cartaButtataG2.Image = null;
                            view.briscolaGui.Image = null;

                            MessageBox.Show("Cambio turno a giocatore " + corrente.ID);

                            //Addormento il thread per 3 secondi dando quindi il tempo all'avversario per 
                            //posizionarsi davanti lo schermo senza guardare le carte dell'altro giocatore
                            //System.Threading.Thread.Sleep(3000);
                            //aggiorno view
                            settaCarteGui();
                            finePartita();

                        }
                        //se invece il mazzo contiene ancora carte e non è quindi vuoto
                        else
                        {
                            //prende una carta dal mazzo il giocatore corrente
                            daPrendere = corrente.prendiUnaCarta();
                            //prende una carta dal mazzo il giocatore che ha perso nel turno precedente
                            correnteP = partita.tavolo.perdente;
                            daPrendere = correnteP.prendiUnaCarta();
                            //aggiorno view
                            view.cartaButtataG2.Image = null;
                            view.cartaButtataG1.Image = null;

                        }
                        //aggiorno view passando ai label i punteggi dei giocatori
                        view.label3.Text = "" + partita.g1.getPunteggio();
                        view.label4.Text = "" + partita.g2.getPunteggio();
                        //setto giocatore corrente
                        corrente = partita.getGCorrente(corrente, correnteP);
                        //setto le immagini da visualizzare aggiornando il view
                        SetCartaResources(view.carta1G2, retr);
                        SetCartaResources(view.carta2G2, retr);
                        SetCartaResources(view.carta3G2, retr);
                        MessageBox.Show("Cambio turno a giocatore " + corrente.ID);
                        //System.Threading.Thread.Sleep(3000);
                        settaCarteGui();


                    }
                    //se ancora si sta tirando per primo
                    else if (partita.tavolo.numTurno == 0)
                    {
                        //setto il giocatore corrente della partita
                        corrente = partita.getGCorrente(partita.g1, partita.g2);
                        //butto la carta selezionata
                        corrente.buttaCarta();
                        //inverto il turno del giocatore
                        partita.invertiTurnoG(partita.g1, partita.g2);
                        //setto nuovamente il giocatore corrente della partita 
                        corrente = partita.getGCorrente(partita.g1, partita.g2);
                        //visualizza e aggiorna view
                        SetCartaResources(view.carta1G2, retr);
                        SetCartaResources(view.carta2G2, retr);
                        SetCartaResources(view.carta3G2, retr);
                        MessageBox.Show("Cambio turno a giocatore " + corrente.ID);
                        //System.Threading.Thread.Sleep(3000);
                        settaCarteGui();


                    }
                }

            };
            view.carta3G1.MouseClick += (s, es) =>
            {
                if (corrente == partita.g1)
                {
                    //scelgo la carta rappresentata dalla picturebox                  
                    daButtare = corrente.scegliCarta(corrente.listaGiocatore[2]);
                    //aggiorno il view
                    view.cartaButtataG1.Image = view.carta3G1.Image;
                    view.carta3G1.Image = null;
                    //System.Threading.Thread.Sleep(3000);
                    //se ha già tirato il primo giocatore
                    if (partita.tavolo.numTurno == 1)
                    {
                        //butto la carta selezionata e partirà il confronto
                        corrente.buttaCarta();
                        // setto adesso il giocatore corrente
                        corrente = partita.getGCorrente(partita.tavolo.vincitore, partita.tavolo.perdente);
                        //se il mazzo non ha più carte
                        if (partita.mazzo.listaMazzo.Count == 0)
                        {
                            //aggiorno view
                            view.carta3G1.Image = null;
                            view.cartaButtataG1.Image = null;
                            view.cartaButtataG2.Image = null;
                            view.briscolaGui.Image = null;

                            MessageBox.Show("Cambio turno a giocatore " + corrente.ID);

                            //Addormento il thread per 3 secondi dando quindi il tempo all'avversario per 
                            //posizionarsi davanti lo schermo senza guardare le carte dell'altro giocatore
                            //System.Threading.Thread.Sleep(3000);
                            //aggiorno view
                            settaCarteGui();
                            finePartita();

                        }
                        //se invece il mazzo contiene ancora carte e non è quindi vuoto
                        else
                        {
                            //prende una carta dal mazzo il giocatore corrente
                            daPrendere = corrente.prendiUnaCarta();
                            //prende una carta dal mazzo il giocatore che ha perso nel turno precedente
                            correnteP = partita.tavolo.perdente;
                            daPrendere = correnteP.prendiUnaCarta();
                            //aggiorno view
                            view.cartaButtataG2.Image = null;
                            view.cartaButtataG1.Image = null;

                        }
                        //aggiorno view passando ai label i punteggi dei giocatori
                        view.label3.Text = "" + partita.g1.getPunteggio();
                        view.label4.Text = "" + partita.g2.getPunteggio();
                        //setto giocatore corrente
                        corrente = partita.getGCorrente(corrente, correnteP);
                        //setto le immagini da visualizzare aggiornando il view
                        SetCartaResources(view.carta1G1, retr);
                        SetCartaResources(view.carta2G1, retr);
                        SetCartaResources(view.carta3G1, retr);
                        MessageBox.Show("Cambio turno a giocatore " + corrente.ID);
                        // System.Threading.Thread.Sleep(3000);
                        settaCarteGui();


                    }
                    //se ancora si sta tirando per primo
                    else if (partita.tavolo.numTurno == 0)
                    {
                        //setto il giocatore corrente della partita
                        corrente = partita.getGCorrente(partita.g1, partita.g2);
                        //butto la carta selezionata
                        corrente.buttaCarta();
                        //inverto il turno del giocatore
                        partita.invertiTurnoG(partita.g1, partita.g2);
                        //setto nuovamente il giocatore corrente della partita 
                        corrente = partita.getGCorrente(partita.g1, partita.g2);
                        //visualizza e aggiorna view
                        SetCartaResources(view.carta1G1, retr);
                        SetCartaResources(view.carta2G1, retr);
                        SetCartaResources(view.carta3G1, retr);

                        MessageBox.Show("Cambio turno a giocatore " + corrente.ID);
                        //System.Threading.Thread.Sleep(3000);
                        settaCarteGui();

                    }
                }


            };
            view.carta2G1.MouseClick += (s, es) =>
            {

                if (corrente == partita.g1)
                {
                    //scelgo la carta rappresentata dalla picturebox                  
                    daButtare = corrente.scegliCarta(corrente.listaGiocatore[1]);
                    //aggiorno il view
                    view.cartaButtataG1.Image = view.carta2G1.Image;
                    view.carta2G1.Image = null;
                    //System.Threading.Thread.Sleep(3000);
                    //se ha già tirato il primo giocatore
                    if (partita.tavolo.numTurno == 1)
                    {
                        //butto la carta selezionata e partirà il confronto
                        corrente.buttaCarta();
                        // setto adesso il giocatore corrente
                        corrente = partita.getGCorrente(partita.tavolo.vincitore, partita.tavolo.perdente);
                        //se il mazzo non ha più carte
                        if (partita.mazzo.listaMazzo.Count == 0)
                        {
                            //aggiorno view
                            view.carta2G1.Image = null;
                            view.cartaButtataG1.Image = null;
                            view.cartaButtataG2.Image = null;
                            view.briscolaGui.Image = null;

                            MessageBox.Show("Cambio turno a giocatore " + corrente.ID);

                           
                            //aggiorno view
                            settaCarteGui();
                            finePartita();

                        }
                        //se invece il mazzo contiene ancora carte e non è quindi vuoto
                        else
                        {
                            //prende una carta dal mazzo il giocatore corrente
                            daPrendere = corrente.prendiUnaCarta();
                            //prende una carta dal mazzo il giocatore che ha perso nel turno precedente
                            correnteP = partita.tavolo.perdente;
                            daPrendere = correnteP.prendiUnaCarta();
                            //aggiorno view
                            view.cartaButtataG2.Image = null;
                            view.cartaButtataG1.Image = null;

                        }
                        //aggiorno view passando ai label i punteggi dei giocatori
                        view.label3.Text = "" + partita.g1.getPunteggio();
                        view.label4.Text = "" + partita.g2.getPunteggio();
                        //setto giocatore corrente
                        corrente = partita.getGCorrente(corrente, correnteP);
                        //setto le immagini da visualizzare aggiornando il view
                        SetCartaResources(view.carta1G1, retr);
                        SetCartaResources(view.carta2G1, retr);
                        SetCartaResources(view.carta3G1, retr);
                        MessageBox.Show("Cambio turno a giocatore " + corrente.ID);
                        //System.Threading.Thread.Sleep(3000);
                        settaCarteGui();


                    }
                    //se ancora si sta tirando per primo
                    else if (partita.tavolo.numTurno == 0)
                    {
                        //setto il giocatore corrente della partita
                        corrente = partita.getGCorrente(partita.g1, partita.g2);
                        //butto la carta selezionata
                        corrente.buttaCarta();
                        //inverto il turno del giocatore
                        partita.invertiTurnoG(partita.g1, partita.g2);
                        //setto nuovamente il giocatore corrente della partita 
                        corrente = partita.getGCorrente(partita.g1, partita.g2);
                        //visualizza e aggiorna view
                        SetCartaResources(view.carta1G1, retr);
                        SetCartaResources(view.carta2G1, retr);
                        SetCartaResources(view.carta3G1, retr);

                        MessageBox.Show("Cambio turno a giocatore " + corrente.ID);
                        //System.Threading.Thread.Sleep(3000);
                        settaCarteGui();

                    }
                }

            };
            view.carta1G1.MouseClick += (s, es) =>
            {
                
                if (corrente == partita.g1)
                {
                    //scelgo la carta rappresentata dalla picturebox                  
                    daButtare = corrente.scegliCarta(corrente.listaGiocatore[0]);
                    //aggiorno il view
                    view.cartaButtataG1.Image = view.carta1G1.Image;
                    view.carta1G1.Image = null;
                    //System.Threading.Thread.Sleep(3000);
                    //se ha già tirato il primo giocatore
                    if (partita.tavolo.numTurno == 1)
                    {
                        //butto la carta selezionata e partirà il confronto
                        corrente.buttaCarta();
                        // setto adesso il giocatore corrente
                        corrente = partita.getGCorrente(partita.tavolo.vincitore, partita.tavolo.perdente);
                        //se il mazzo non ha più carte
                        if (partita.mazzo.listaMazzo.Count == 0)
                        {
                            //aggiorno view
                            view.carta1G1.Image = null;
                            view.cartaButtataG1.Image = null;
                            view.cartaButtataG2.Image = null;
                            view.briscolaGui.Image = null;

                            MessageBox.Show("Cambio turno a giocatore " + corrente.ID);

                            //Addormento il thread per 3 secondi dando quindi il tempo all'avversario per 
                            //posizionarsi davanti lo schermo senza guardare le carte dell'altro giocatore
                            //System.Threading.Thread.Sleep(3000);
                            //aggiorno view
                            settaCarteGui();
                            finePartita();

                        }
                        //se invece il mazzo contiene ancora carte e non è quindi vuoto
                        else
                        {
                            //prende una carta dal mazzo il giocatore corrente
                            daPrendere = corrente.prendiUnaCarta();
                            //prende una carta dal mazzo il giocatore che ha perso nel turno precedente
                            correnteP = partita.tavolo.perdente;
                            daPrendere = correnteP.prendiUnaCarta();
                            //aggiorno view
                            view.cartaButtataG2.Image = null;
                            view.cartaButtataG1.Image = null;

                        }
                        //aggiorno view passando ai label i punteggi dei giocatori
                        view.label3.Text = "" + partita.g1.getPunteggio();
                        view.label4.Text = "" + partita.g2.getPunteggio();
                        //setto giocatore corrente
                        corrente = partita.getGCorrente(corrente, correnteP);
                        //setto le immagini da visualizzare aggiornando il view
                        SetCartaResources(view.carta1G1, retr);
                        SetCartaResources(view.carta2G1, retr);
                        SetCartaResources(view.carta3G1, retr);
                        MessageBox.Show("Cambio turno a giocatore " + corrente.ID);
                        //System.Threading.Thread.Sleep(3000);
                        settaCarteGui();


                    }
                    //se ancora si sta tirando per primo
                    else if (partita.tavolo.numTurno == 0)
                    {
                        //setto il giocatore corrente della partita
                        corrente = partita.getGCorrente(partita.g1, partita.g2);
                        //butto la carta selezionata
                        corrente.buttaCarta();
                        //inverto il turno del giocatore
                        partita.invertiTurnoG(partita.g1, partita.g2);
                        //setto nuovamente il giocatore corrente della partita 
                        corrente = partita.getGCorrente(partita.g1, partita.g2);
                        //visualizza e aggiorna view
                        SetCartaResources(view.carta1G1, retr);
                        SetCartaResources(view.carta2G1, retr);
                        SetCartaResources(view.carta3G1, retr);
                        MessageBox.Show("Cambio turno a giocatore " + corrente.ID);
                        //System.Threading.Thread.Sleep(3000);
                        settaCarteGui();


                    }
                }

            };

        }
        public void finePartita()
        {
            
            //se i due giocatori non hanno più carte disponibili nei propri mazzi
            
            if (partita.g1.listaGiocatore.Count == 0 && partita.g2.listaGiocatore.Count == 0)
            {
                fine = new Fine();
                String vincSt = null;       //stringa che salva il punteggio del vincitore
                String perdSt = null;       //stringa che salva il punteggio del perdente
                                            //se il punteggio del g1 è > del punteggio di g2 allora la partita sarà vinta da g1
                if (partita.g1.punteggio > partita.g2.punteggio)
                {
                    vincSt = " " + partita.g1.punteggio;
                    perdSt = " " + partita.g2.punteggio;
                    MessageBox.Show("FINE PARTITA. Vince G1" + vincSt + " a " + perdSt);

                    //mostro la finestra di fine partita
                 
                    SetCartaResources(fine.pictureBox1,coppa);
                    fine.Show();
                    
                    view.Close();
                    
                }
                //se il punteggio del g2 è > del punteggio di g1 allora la partita sarà vinta da g2
                else if (partita.g1.punteggio < partita.g2.punteggio)
                {
                   
                    vincSt = " " + partita.g2.punteggio;
                    perdSt = " " + partita.g1.punteggio;
                    MessageBox.Show("FINE PARTITA. Vince G2" + vincSt + " a " + perdSt);
                   
                    SetCartaResources(fine.pictureBox1,coppa);
                    fine.Show();
                    
                    
                    view.Close();
                    

                }
                //se il punteggio del g1 è = al punteggio di g2 allora la partita non sarà vinta da nessuno
                else if (partita.g1.punteggio == partita.g2.punteggio)
                {
                    vincSt = " " + partita.g2.punteggio;
                    perdSt = " " + partita.g1.punteggio;
                    MessageBox.Show("FINE PARTITA.");
                    fine.label1.Text = "FINE PARTITA. Vince l'amicizia";

                    SetCartaResources(fine.pictureBox1, "amicizia");
                    fine.Show();
                   
                    view.Close();
                }

            }
        }
    }
}

