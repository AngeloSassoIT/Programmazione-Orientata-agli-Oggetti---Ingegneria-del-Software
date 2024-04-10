using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaGioco
{
    class CartePunti : Carte
    {
        public CartePunti(int i,int j) : base(i, j)
        {

        }
        public override void setCarta()
        {
            switch (numeroNome)
            {
                case 1:
                    valore = 11;
                    nomeCarta = "Asso";
                    break;
                case 3:
                    valore = 10;
                    nomeCarta = "Tre";
                    break;
                case 8:
                    valore = 2;
                    nomeCarta = "Donna";
                    break;
                case 9:
                    valore = 3;
                    nomeCarta = "Cavallo";
                    break;
                case 10:
                    valore = 4;
                    nomeCarta = "Re";
                    break;
            }
        }
        public override void setNomeSeme()
        {
            switch (numeroSeme)
            {
                case 1:
                    nomeSeme = "Oro";
                    break;
                case 2:
                    nomeSeme = "Coppe";
                    break;
                case 3:
                    nomeSeme = "Bastoni";
                    break;
                case 4:
                    nomeSeme = "Spade";
                    break;
            }
        }
        public override void setNomeCompleto()
        {
            nomeCompleto = nomeCarta + nomeSeme;
        }
        public override int getSeme()
        {
            return numeroSeme;
        }
        public override void setBriscola()
        {
            briscola = true;
        }
        public override Boolean getBriscola()
        {

            return this.briscola;
        }
        public override int getValue()
        {
            return this.valore;
        }
        public override int getnumCarta()
        {
            return this.numeroNome;
        }
        public override String getnomeCompleto()
        {
            return this.nomeCompleto;
        }
    }
}
