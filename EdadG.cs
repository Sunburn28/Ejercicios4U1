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
    public partial class EdadG : Form
    {
        public EdadG()
        {
            InitializeComponent();
        }

        private void EdadG_Load(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            int[] edades = txtEdades.Text.Split(',')
                                           .Select(s => int.Parse(s.Trim()))
                                           .ToArray();
            var resultados = CalculadoraEdades.Calcular(edades);
            MessageBox.Show($"La media de las edades es: {resultados.media}\nLa edad mayor es: {resultados.edadMayor}\nLa edad menor es: {resultados.edadMenor}", "Resultados");
        }
    }
 }