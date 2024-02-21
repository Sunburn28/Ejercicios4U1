using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicios4
{
    internal class NP
    {

        public void CalcularPrimos()
        {
            string primos = "Números primos entre 1 y 1000:\n\n";

            for (int i = 2; i <= 1000; i++)
            {
                int divisor = 2;
                while (i % divisor != 0 && divisor < i)
                {
                    divisor++;
                }

                if (divisor == i)
                {
                    primos += i + ",";
                }
            }
            MessageBox.Show(primos);
        }

    }
}