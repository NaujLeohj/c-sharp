using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnteroR
{
    public partial class Form1 : Form
    {
        Entero n;
        Entero n2;
        Entero n3;
        Entero n4;

        public Form1()
        {
            InitializeComponent();
            n = new Entero();
            n2 = new Entero();
            n3 = new Entero();
            n4 = new Entero();
        }

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            n.Cargar(int.Parse(txt_cargar.Text));
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txt_descargar.Text = n.Descargar().ToString();
        }

        private void esmultiploToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_descargar.Text = n.EsMultiplo(int.Parse(txt_cargar.Text), int.Parse(txt_cargar2.Text)).ToString();
        }

        private void esSubmultiploToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_descargar.Text = n.EsSubMultiplo(int.Parse(txt_cargar.Text), int.Parse(txt_cargar2.Text)).ToString();
        }

        private void factorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_descargar.Text = n.Factorial().ToString();
        }

        private void esCapToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            txt_descargar.Text = n.EsCap().ToString();
        }

        private void esFivoacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_descargar.Text = n.EsFivo().ToString();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            n.UnirDos(n2, n3);
            txt_descargar.Text = n.Descargar().ToString();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n2.Cargar(int.Parse(txt_cargar2.Text));
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_descargar2.Text = n2.Descargar().ToString();
        }

        private void cargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            n3.Cargar(int.Parse(txt_cargar3.Text));
        }

        private void descargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            txt_descargar3.Text = n3.Descargar().ToString();
        }

        private void entero4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n4.Cargar(int.Parse(txt_cargar4.Text));
        }

        private void descargarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            txt_descargar5.Text = n4.Descargar().ToString();
        }

        private void unirTresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n.UnirTres(n2, n3, n4);
            txt_descargar4.Text = n.Descargar().ToString();
        }

        private void nEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_descargar4.Text = n.NEmayor(n2, n3, n4).ToString();
        }

        private void digIgualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_descargar4.Text = n.DigIgual().ToString();
        }

        private void todosParesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_descargar4.Text = n.TodosPares().ToString();
        }

        private void seprarParesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n.SepPares(n2);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            n.SepPrim(n2);
        }
    }
}
