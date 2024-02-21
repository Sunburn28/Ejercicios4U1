using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios4
{
    public class CalculadoraEdades
    {
        public static (double media, int edadMayor, int edadMenor) Calcular(int[] edades)
        {
            double media = edades.Sum() / (double)edades.Length;
            int edadMayor = edades.Max();
            int edadMenor = edades.Min();
            return (media, edadMayor, edadMenor);
        }
    }
}
