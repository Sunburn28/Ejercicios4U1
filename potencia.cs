using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios4
{
    internal class potencia
    {
        public static void CalcularPotencia(double numero, int exponente)
        {
            double resultado = Math.Pow(numero, exponente);
            MessageBox.Show("Tu número elevado a la potencia es: " + resultado);
        }
       
    }
}
