using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaGioco
{
    public abstract class Carte
    {
        protected String nomeCarta;
        protected String nomeCompleto;
        protected String nomeSeme;
        protected int numeroNome;
        protected int valore;
        protected int numeroSeme;
        protected Boolean briscola;
     

        public Carte(int i, int j)
        {
            this.numeroNome = j;
            this.numeroSeme = i;
            this.briscola = false;

        }
        public Carte()
        {

        }
        public virtual void setCarta()
        {

        }
        public virtual void setNomeSeme()
        {
            
        }
        public virtual void setNomeCompleto()
        {

        }
        public virtual int getSeme()
        {
            return numeroSeme;
        }
        public virtual void setBriscola()
        {
            this.briscola = true;
        }      
        public virtual Boolean getBriscola()
        {
            
            return this.briscola;
        }
        public virtual int getValue()
        {
            return this.valore;
        }
        public virtual int getnumCarta()
        {
            return this.numeroNome;
        }
        public virtual String getnomeCompleto()
        {
            return this.nomeCompleto;
        }

    }
}
