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
    public partial class Fine : Form
    {
       
       
       
        public Fine()
        {
            InitializeComponent();
           
           
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }
        
               
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;                      
            LogicaGioco.Partita partita = new LogicaGioco.Partita();
            partita.inizializzaPartita();

            View view = new View();
            //dichiaro il control 
            Control control = new Control(view, partita);
            control.settaControlli();
            control.settaCarteGui();
            view.Show();
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Fine_Load(object sender, EventArgs e)
        {

        }
    }
}
