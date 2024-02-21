using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

using System;

using System;
using System.Windows.Forms;

namespace Ejercicios4
{
    public class CalculadoraCaldera
    {
        private const int TemperaturaMaxima = 180;
        public const int TemperaturaMinima = 32;
        public const int TemperaturaMinimaAceptable = 28;

        private int temperaturaActual;
        private int resta;
        public event EventHandler TemperaturaCambiada;

        public CalculadoraCaldera()
        {
            Random random = new Random();
            resta = random.Next(1, 11);
            temperaturaActual = random.Next(TemperaturaMinima, TemperaturaMaxima + 1);
        }

        public int ObtenerTemperaturaActual()
        {
            return temperaturaActual;
        }

        public bool VerificarTemperaturaAceptable()
        {
            return temperaturaActual >= TemperaturaMinimaAceptable;
        }

        public void AjustarTemperatura(bool aceptable)
        {
            if (!aceptable)
            {
                temperaturaActual -= resta;
                if (temperaturaActual <= TemperaturaMinima || temperaturaActual < TemperaturaMinimaAceptable)
                {
                    temperaturaActual = TemperaturaMinima;
                }
                MessageBox.Show("Felicidades, la caldera esta en una temperatura optima");
            }

            OnTemperaturaCambiada();
        }

        protected virtual void OnTemperaturaCambiada()
        {
            TemperaturaCambiada?.Invoke(this, EventArgs.Empty);
        }
    }
}

