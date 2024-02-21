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
    public partial class TablaM : Form
    {
        public TablaM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(NumeroMul.Text);
            ClaseTablaM tablaMultiplicacion = new ClaseTablaM();
            tablaMultiplicacion.Mul(num1);
        }
    }
}
