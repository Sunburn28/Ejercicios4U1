using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicios4
{
    public partial class NumerosPrimos : Form
    {
        public NumerosPrimos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            NP NumerosP = new NP();
            NumerosP.CalcularPrimos();
        }
    }
}
