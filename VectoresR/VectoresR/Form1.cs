using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectoresR
{
    public partial class Form1 : Form
    {
        Vector v;
        Vector v2;
        Vector v3;
        public Form1()
        {
            InitializeComponent();
            v = new Vector();
            v2 = new Vector();
            v3 = new Vector();
        }

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v.Cargar(int.Parse(txt_cargar.Text), int.Parse(txt_cargar2.Text), int.Parse(txt_cargar3.Text));
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v2.Cargar(int.Parse(txt_cargar.Text), int.Parse(txt_cargar2.Text), int.Parse(txt_cargar3.Text));
        }

        private void cargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            v3.Cargar(int.Parse(txt_cargar.Text), int.Parse(txt_cargar2.Text), int.Parse(txt_cargar3.Text));
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txt_descargar.Text = v.Descargar();
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_descargar2.Text = v2.Descargar();
        }

        private void descargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            txt_descargar3.Text = v3.Descargar();
        }

        private void cargarElemXElemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int dim = int.Parse(txt_cargar.Text);
            v.CargarEleXEle(dim);
            txt_descargar.Text = v.Descargar();
        }

        private void cargarEleXEleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int dim = int.Parse(txt_cargar.Text);
            v2.CargarEleXEle(dim);
            txt_descargar2.Text = v2.Descargar();
        }

        private void cargarEleXEleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int dim = int.Parse(txt_cargar.Text);
            v3.CargarEleXEle(dim);
            txt_descargar3.Text = v3.Descargar();
        }

        private void expregresivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.ExpReg(int.Parse(txt_cargar2.Text), int.Parse(txt_cargar3.Text));
            txt_descargar4.Text = v.Descargar(); 
        }

        private void expRegresivoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v.RaizReg();
            txt_descargar4.Text = v.Descargar();
        }

        private void contFivoMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_descargar4.Text = v.ContFivo(int.Parse(txt_cargar2.Text)).ToString();
        }

        private void mediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_descargar4.Text = v.Media(int.Parse(txt_cargar2.Text), int.Parse(txt_cargar3.Text)).ToString();
        }

        private void sepPrimosNoPrimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.PrimNoPrim(v2, v3);
        }

        private void invertirRangoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.InvRang(int.Parse(txt_cargar2.Text), int.Parse(txt_cargar3.Text));
            txt_descargar4.Text = v.Descargar();
        }

        private void busquedaSecuencialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_descargar4.Text = v.BusqSec(int.Parse(txt_cargar.Text), int.Parse(txt_cargar2.Text), int.Parse(txt_cargar3.Text)).ToString();
        }

        private void interseccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.Intersec(v2, v3);
            txt_descargar4.Text = v.Descargar();
        }

        private void unionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.Union(v2, v3);
            txt_descargar4.Text = v.Descargar();
        }

        private void ordenarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.Ord();
            txt_descargar4.Text = v.Descargar();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            txt_descargar4.Text = v.VerifOrd(int.Parse(txt_cargar2.Text), int.Parse(txt_cargar3.Text)).ToString();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            v2.ElimXRango(int.Parse(txt_cargar2.Text), int.Parse(txt_cargar3.Text));
            txt_descargar4.Text = v2.Descargar();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            v2.InsertObj(int.Parse(txt_cargar2.Text), v);
            txt_descargar4.Text = v2.Descargar();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            v2.Girar(int.Parse(txt_cargar2.Text));
            txt_descargar4.Text = v2.Descargar();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            v2.OrdBurbXRang(int.Parse(txt_cargar2.Text), int.Parse(txt_cargar3.Text));
            txt_descargar4.Text = v2.Descargar();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            txt_descargar4.Text = v2.ContDif(int.Parse(txt_cargar2.Text), int.Parse(txt_cargar3.Text)).ToString();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            v2.IntercalVect(v, v3);
            txt_descargar4.Text = v2.Descargar();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            v2.SegPrimYNoPrim(int.Parse(txt_cargar2.Text), int.Parse(txt_cargar3.Text));
            txt_descargar4.Text = v2.Descargar();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            v2.SegCap();
            txt_descargar4.Text = v2.Descargar();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            v2.InterPrim();
            txt_descargar4.Text = v2.Descargar();
        }
    }
}
