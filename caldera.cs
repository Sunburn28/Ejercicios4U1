using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace Ejercicios4
{
    public partial class caldera : Form
    {
        private CalculadoraCaldera logica;

        public caldera()
        {
            InitializeComponent();
            logica = new CalculadoraCaldera();
            logica.TemperaturaCambiada += Logica_TemperaturaCambiada;
            ActualizarTemperatura();
        }

        private void button1_Click(object sender, EventArgs e) // Temperatura aceptable
        {
            logica.AjustarTemperatura(true);
            MessageBox.Show("Gracias por usar el programa");
            Close();
        }

        private void button2_Click(object sender, EventArgs e) // Temperatura no aceptable
        {
            logica.AjustarTemperatura(false);
        }

        private void Logica_TemperaturaCambiada(object sender, EventArgs e)
        {
            ActualizarTemperatura();
        }

        private void ActualizarTemperatura()
        {
            int temperatura = logica.ObtenerTemperaturaActual();
            textBox1.Text = temperatura.ToString() + "°C";

            // Habilitar o deshabilitar los botones según la temperatura actual
            button1.Enabled = temperatura >= CalculadoraCaldera.TemperaturaMinimaAceptable;
            button2.Enabled = true; // Opcional: siempre permitir ajustar la temperatura hacia abajo
        }
    }
}
