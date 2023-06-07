using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using EnteroR;

namespace VectoresR
{
    class Vector
    {
        private int n;
        private const int MAX = 50;
        int[] v;

        public Vector()
        {
            n = 0;
            v = new int[MAX];
        }

        public void Cargar(int n1, int a, int b)
        {
            b++;
            n = n1;
            Random r = new Random();
            for (int i = 1; i <= n; i++)
            {
                v[i] = r.Next(a, b);
            }
        }

        public string Descargar()
        {
            string s="";
            for (int i = 1; i <= n; i++)
            {
                s = s + v[i] + "|";
            }
            return s;
        }

        public void CargarEleXEle(int dim)
        {
            n = dim;

            for (int i = 1; i <= n; i++)
            {
                v[i] = int.Parse(Interaction.InputBox($"Introduce valor {i}:"));
            }
        }

        //---------------------------------VECTOR PARTE 1--------------------------------

        public void ExpReg(int ne, int b)
        {
            int i = 1; ;
            n = ne+1;
            while (ne>=0)
            {
                v[i] = (int)Math.Pow(b, ne--);
                i++;
            }

        }

        public void RaizReg()
        {
            int exp = 2;
            bool sw = true;
            for (int i = 1; i <= n; i++)
            {
                if (sw)
                {
                    v[i] = -(int)Math.Pow(v[i], 1 / exp);
                }
                else
                {
                    v[i] = (int)Math.Pow(v[i], 1 / exp);
                }
                exp++;
                sw = !sw;
                
            }
        }

        public int ContFivo(int m)
        {   Entero n1 = new Entero();
            int m2 = m;
            int c=0;
            while (m<=n)
            {   n1.Cargar(v[m]);
                if (n1.EsFivo())
                {
                    c++;
                }
                m = m + m2;
            }
            return c;
        }

        public double Media(int e, int r)
        {
            
            int ed = r;
            int c = 1;
            int i = e + r;
            int s = v[e];
            while (i<=n)
            {
                s = s + v[i];
                c++;
                i = i + ed;
            }
            return (double) s / c;
        }

        public void Add(int dato)
        {
            n++;
            v[n] = dato;
        }

        public void PrimNoPrim(Vector p, Vector np)
        {   Entero n1 = new Entero();
            for (int i = 1; i <= n; i++)
            {
                n1.Cargar(v[i]);
                if (n1.EsPrim())
                {
                    p.Add(v[i]);
                }
                else
                {
                    np.Add(v[i]);
                }
            }
        }

        public void Inter(int a, int b)
        {
            int temp = v[a];
            v[a] = v[b];
            v[b] = temp;
        }

        public void InvRang(int a, int b)
        {
            for (int i = a; i <= b; i++)
            {
                this.Inter(v[a], v[b]);
                a++;
                b--;
            }
        }

        public int BusqSec(int ele, int a, int b)
        {
            for (int i = a; i <= b; i++)
            {
                if (v[i] == ele)
                {
                    return i;
                }
            }
            return 0;
        }

        public int Exist(int ele)
        {
            for (int i = 1; i <= n; i++)
            {
                if (v[i] == ele)
                {
                    return i;
                }
            }
            return 0;
        }

        public void Intersec(Vector v2, Vector v3)
        {
            for (int x = 1; x <= v2.n; x++)
            {
                for (int y = 1; y <= v3.n; y++)
                {
                    if ((v2.v[x]==v3.v[y]) && !(this.Exist(v2.v[x])>0))
                    {
                        this.Add(v2.v[x]);
                    }
                }
            }
        }

        public void Ord()
        {
            for (int p = 1; p <= n-1; p++)
            {
                for (int d = p+1; d <= n; d++)
                {
                    if (v[p] > v[d])
                    {
                        int temp = v[p];
                        v[p] = v[d];
                        v[d] = temp;
                    }
                }
            }
        }

        public void OrdXRang(int a, int b)
        {
            for (int p = a; p <= b - 1; p++)
            {
                for (int d = p + 1; d <= b; d++)
                {
                    if (v[p] > v[d])
                    {
                        int temp = v[p];
                        v[p] = v[d];
                        v[d] = temp;
                    }
                }
            }
        }

        public void OrdBurb()
        {
            int t, d;

            for (t = n; t >= 2; t--)
            {
                for (d = 1; d <= t-1; d++)
                {
                    if (v[d] > v[d+1])
                    {
                        int temp = v[d];
                        v[d] = v[d + 1];
                        v[d + 1] = temp;
                    }
                }
            }
        }

        //public void Depurar(Vector v2)
        //{
        //    this.OrdBurb();
        //    int ele, i;
        //    i = 1;
        //    v2.n = 0;
        //    while (i<=n)
        //    {   ele = v[i];
        //        while ((i<=n) && (v[i] == ele))
        //        {
        //            i++;
        //        }
        //        v2.n++;  v2.v[v2.n] = ele;
        //    }
        //}


        public void Union(Vector v2, Vector v3)
        {   //this.Ord();
            //this.Depurar();

            for (int i = 1; i <= v2.n; i++)
            {
                this.Add(v2.v[i]);
            }

            for (int y = 1; y <= v3.n; y++)
            {
                if (!(this.Exist(v3.v[y]) > 0))
                {
                    this.Add(v3.v[y]);
                }
            }

        }

        public bool VerifOrd(int a, int b)
        {
            for (int d = a; d <= b-1; d++)
            {
                if (!(v[d] <= v[d + 1]))
                {
                    return false;
                }
            }
            return true;
        }

        //---------------------------------VECTOR PARTE 2--------------------------------

        public void InsertObj(int p, Vector y)
        {
            Vector aux = new Vector();
            for (int i = p; i <= n; i++)
            {
                aux.Add(v[i]);
            }
            n = p - 1;
            for (int x = 1; x <= y.n; x++)
            {
                this.Add(y.v[x]);
            }
            for (int z = 1; z <= aux.n; z++)
            {
                this.Add(aux.v[z]);
            }
        }

        public void ElimXRango(int a, int b)
        {
            int aux = n;
            n = a - 1;

            for (int i = b + 1; i <= aux; i++)
            {
                this.Add(v[i]);
            }
        }

        public void Girar(int g)
        {
            for (int i = 1; i <= g; i++)
            {
                for (int d = 1; d <= n - 1; d++)
                {
                    int temp = v[d];
                    v[d] = v[d + 1];
                    v[d + 1] = temp;
                }
            }
        }
        public void OrdBurbXRang(int a, int b)
        {
            int t, d;

            for (t = b; t >= a + 2; t--)
            {
                for (d = a; d <= t - 1; d++)
                {
                    if (v[d] > v[d + 1])
                    {
                        int temp = v[d];
                        v[d] = v[d + 1];
                        v[d + 1] = temp;
                    }
                }
            }
        }

        public int ContDif()
        {
            this.OrdBurb();
            int i, c, ele;
            i = 1;
            c = 0;
            while (i <= n)
            {
                ele = v[i];

                while ((i <= n) && (v[i] == ele))
                {
                    i++;
                }

                c++;
            }

            return c;
        }

        public int ContDif(int a, int b)
        {
            this.OrdBurbXRang(a, b);
            int c, ele;
            c = 0;
            while (a <= b)
            {
                ele = v[a];

                while ((a <= b) && (v[a] == ele))
                {
                    a++;
                }

                c++;
            }

            return c;
        }

        public int Menor()
        {
            int ele, i;
            i = 1;
            ele = v[i];

            for (i = 1; i <= n; i++)
            {
                if (v[i] <= ele)
                {
                    ele = v[i];
                }
            }

            return ele;
        }

        public int Index(int ele)
        {
            int index = 0;

            for (int i = 1; i <= n; i++)
            {
                if (ele == v[i])
                {
                    index = i;
                }
            }

            return index;
        }

        public int MinRep()
        {
            this.OrdBurb();

            int i, c, ele, min, index;

            i = 1;

            Vector aux = new Vector();

            Vector aux2 = new Vector();

            while (i <= n)
            {
                ele = v[i]; c = 0;

                while ((i <= n) && (ele == v[i]))
                {
                    i++;
                    c++;
                }

                aux.Add(c);
                aux2.Add(v[c]);
            }

            min = aux.Menor();
            index = aux.Index(min);
            return aux2.v[index];
        }

        public void IntercalVect(Vector v2, Vector v3)
        {
            int x, y;
            x = 1; y = 1;
            bool sw = true;
            while ((x <= v2.n) || (y <= v3.n))
            {
                if ((sw) && (x <= v2.n))
                {
                    this.Add(v2.v[x]);
                    x++;
                }
                else
                {
                    if (y <= v3.n)
                    {
                        this.Add(v3.v[y]);
                        y++;
                    }
                }
                sw = !sw;
            }
        }

        public void SegPrimYNoPrim(int a, int b)
        {
            Entero n1 = new Entero();
            Entero n2 = new Entero();

            for (int p = a; p <= b - 1; p++)
            {
                for (int d = p + 1; d <= b; d++)
                {
                    n1.Cargar(v[p]); n2.Cargar(v[d]);
                    if (!n1.EsPrim() && (n2.EsPrim()) ||
                        (n1.EsPrim()) && (n2.EsPrim()) && (v[d] > v[p]) ||
                        (!n1.EsPrim() && (!n2.EsPrim()) && (v[d]) > v[p]))
                    {
                        int temp = v[p];
                        v[p] = v[d];
                        v[d] = temp;
                    }
                }
            }
        }

        public void SegCap()
        {
            Entero n1 = new Entero();
            Entero n2 = new Entero();

            for (int p = 1; p <= n - 1; p++)
            {
                for (int d = p + 1; d <= n; d++)
                {
                    n1.Cargar(v[p]); n2.Cargar(v[d]);

                    if (!n1.EsCap() && (n2.EsCap()) ||
                        (n1.EsCap()) && (n2.EsCap()) && (v[d] < v[p]) ||
                        (!n1.EsCap() && (!n2.EsCap()) && (v[p]) < v[d]))
                    {
                        int temp = v[p];
                        v[p] = v[d];
                        v[d] = temp;
                    }
                }
            }
        }

        public void InterPrim()
        {
            Entero n1 = new Entero();
            Entero n2 = new Entero();
            bool sw = true;
            for (int p = 1; p <= n - 1; p++)
            {
                if (sw)
                {
                    for (int d = p + 1; d <= n; d++)
                    {
                        n1.Cargar(v[d]);
                        if (v[d] < v[p] && n1.EsPrim())
                        {
                            int temp = v[d];
                            v[d] = v[p];
                            v[p] = temp;
                        }
                    }
                }
                else
                {
                    for (int d = p + 1; d <= n; d++)
                    {
                        n1.Cargar(v[d]);
                        if (v[d] > v[p] && !n1.EsPrim())
                        {
                            int temp = v[d];
                            v[d] = v[p];
                            v[p] = temp;
                        }
                    }
                }

                sw = !sw;

            }
        }


    }
}
