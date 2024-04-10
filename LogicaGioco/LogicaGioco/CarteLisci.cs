using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaGioco
{
    class CarteLisci : Carte
    {
        public CarteLisci(int i,int j) : base(i, j)
        {

        }
        public override void setCarta()
        {
            switch (numeroNome)
            {
                case 2:
                    valore = 0;
                    nomeCarta = "Due";
                    break;
                case 4:
                    valore = 0;
                    nomeCarta = "Quattro";
                    break;
                case 5:
                    valore = 0;
                    nomeCarta = "Cinque";
                    break;
                case 6:
                    valore = 0;
                    nomeCarta = "Sei";
                    break;
                case 7:
                    valore = 0;
                    nomeCarta = "Sette";
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
