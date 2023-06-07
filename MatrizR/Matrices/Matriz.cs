using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Matriz
    {
        private const int MAXF = 50;
        private const int MAXC = 50;
        private int[,] x;
        private int f, c;

        public Matriz()
        {
            x = new int[MAXF, MAXC];
            f = 0;
            c = 0;
        }

        public void Cargar(int nf, int nc, int a, int b)
        {
            int f1, c1;
            f = nf;
            c = nc;
            Random r = new Random();
            for (f1 = 1; f1 <= f; f1++)
            {
                for (c1 = 1; c1 <= c; c1++)
                {
                    x[f1, c1] = r.Next(a, b);
                }
            }
        }

        public string Descargar()
        {
            int f1, c1;
            string s = "";
            for (f1 = 1; f1 <= f; f1++)
            {
                for (c1 = 1; c1 <= c; c1++)
                {
                    s = s + x[f1, c1] + "\x0009";
                }
                s = s + "\x00d" + "\x00a";
            }

            return s;
        }
    }
}
