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
        Matriz m;
        Matriz m2;
        Matriz m3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m = new Matriz();
            m2 = new Matriz();
            m3 = new Matriz();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m.Cargar(int.Parse(txt_cargar.Text),
                int.Parse(txt_cargar2.Text),
                int.Parse(txt_cargar3.Text),
                int.Parse(txt_cargar4.Text));
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_descargar.Text = m.Descargar();
        }

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m2.Cargar(int.Parse(txt_cargar.Text),
                int.Parse(txt_cargar2.Text),
                int.Parse(txt_cargar3.Text),
                int.Parse(txt_cargar4.Text));
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txt_descargar2.Text = m2.Descargar();
        }

        private void cargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            m3.Cargar(int.Parse(txt_cargar.Text),
                int.Parse(txt_cargar2.Text),
                int.Parse(txt_cargar3.Text),
                int.Parse(txt_cargar4.Text));
        }

        private void descargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            txt_descargar3.Text = m3.Descargar();
        }

        private void sumarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m.Sumar(m2, m3);
            txt_descargar4.Text = m.Descargar();
        }
    }
}
