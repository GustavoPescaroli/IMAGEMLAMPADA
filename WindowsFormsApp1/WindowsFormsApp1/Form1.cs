using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form

    {
        private Lampada leds;
        public Form1()
        {

            InitializeComponent();
            leds = new Lampada();
            AtualizarEstadoLeds();
        }
        private void AtualizarEstadoLeds()
        {
            label1.Text = leds.getEstado().ToString();

            button1.Text = (leds.getEstado(1) ? "OFF" : "ON");
            button2.Text = (leds.getEstado(2) ? "OFF" : "ON");
            button3.Text = (leds.getEstado(3) ? "OFF" : "ON");
            button4.Text = (leds.getEstado(4) ? "OFF" : "ON");
            button5.Text = (leds.getEstado(5) ? "OFF" : "ON");
            button6.Text = (leds.getEstado(6) ? "OFF" : "ON");
            button7.Text = (leds.getEstado(7) ? "OFF" : "ON");
            button8.Text = (leds.getEstado(8) ? "OFF" : "ON");
        }

    private void picLampada(object sender, EventArgs e)
        {

        }
    }
}
