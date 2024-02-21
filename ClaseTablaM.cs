using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios4
{
    internal class ClaseTablaM
    {
        public void Mul(int num1)
        {
            string resultados = "Tabla de multiplicar del " + num1 + ":\n";
            for (int i = 1; i <= 10; i++)
            {
                resultados += num1 + " x " + i + " = " + (num1 * i) + "\n";
            }
            MessageBox.Show(resultados);
        }

    }
}