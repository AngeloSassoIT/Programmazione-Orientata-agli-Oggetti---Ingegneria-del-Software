using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace briscolax2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogicaGioco.Partita partita = new LogicaGioco.Partita();
            partita.inizializzaPartita();

            View view = new View();
            //dichiaro il control 
            Control control = new Control(view, partita);
            control.settaControlli();
            control.settaCarteGui();
            view.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Istruzioni istruzioni = new Istruzioni();
            istruzioni.Show();
        }

        
    }
}
