using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrices
{
    public partial class Form1 : Form
    {
        Matriz x;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x = new Matriz();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.Cargar(int.Parse(txt_cargar.Text), int.Parse(txt_cargar2.Text), int.Parse(txt_cargar3.Text), int.Parse(txt_cargar4.Text));
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_descargar.Text = x.Descargar();
        }
    }
}
