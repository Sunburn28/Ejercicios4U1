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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TablaM frm = new TablaM();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NumerosPrimos frm = new NumerosPrimos();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NumeroE frm = new NumeroE();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EdadG frm = new EdadG();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            caldera frm = new caldera();
            frm.Show();
        }
    }
}
