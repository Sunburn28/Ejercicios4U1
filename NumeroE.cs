using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios4
{
    public partial class NumeroE : Form
    {
        public NumeroE()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double num = Double.Parse(Numero.Text);
            int exponente = int.Parse(Potencia.Text);
            potencia p = new potencia();
            potencia.CalcularPotencia(num, exponente);
        }
    }
}
