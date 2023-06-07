using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnteroR
{
    class Entero
    {
        private int n;

        public Entero()
        {
            n = 0;
        }

        public void Cargar(int n1)
        {
            n = n1;
        }

        public int Descargar()
        {
            return n;
        }

        public bool EsMultiplo(int multiplo, int numero)
        {
            if(multiplo % numero == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EsSubMultiplo(int submultiplo, int numero)
        {
            if(numero % submultiplo  == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public int Factorial()
        {
            int f=1;
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            return f;
        }

        public int Reverse()
        {
            int aux=n;
            int d, s;
            s = 0;
            do
            {
                d = n % 10;
                n = n / 10;
                s = (s * 10) + d;
            } while (n > 0);
            n = aux;
            return s;
        }

        public bool EsCap()
        {
            int r = this.Reverse();
            return n == r;
        }

        public bool EsFivo()
        {
            int a, b, c;
            a = 0;
            b = 1;
            c = a + b;
            for (int i = 1; i <= n; i++)
            {
                if (n == c)
                {
                    return true;
                }
                a = b;
                b = c;
                c = a + b;
            }
            return false;
        }

        public int CantDig()
        { int d,i;
            int aux = n;
            i = 0;
            do
            {
                d = n % 10;
                n = n / 10;
                i++;
            } while (n > 0);

            n = aux;
            return i;
        }

        public void UnirDos(Entero n2, Entero n3)
        {
            if (n2.n>n3.n)
            {
                n = (n3.n * (int)Math.Pow(10, n2.CantDig())) + n2.n;
            }
            else
            {
                n = (n2.n * (int)Math.Pow(10, n3.CantDig())) + n3.n;
            }
        }

        public void UnirTres(Entero n2, Entero n3, Entero n4)
        {
            if (n2.n > n3.n && n2.n>n4.n)
            {   this.UnirDos(n3, n4);
                 n = (n * (int)Math.Pow(10, n2.CantDig())) + n2.n;
            }
            else if (n3.n > n4.n && n3.n > n2.n)
            {
                this.UnirDos(n2, n4);
                n = (n * (int)Math.Pow(10, n3.CantDig())) + n3.n;
            }
            else
            {
                this.UnirDos(n2, n3);
                n = (n * (int)Math.Pow(10, n4.CantDig())) + n4.n;
            }
        }

        public int NEmayor(Entero n2, Entero n3, Entero n4)
        {
            if (n2.n > n3.n && n2.n > n4.n)
            {
                return 1;
            }
            else if (n3.n > n4.n && n3.n > n2.n)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        public bool DigIgual()
        {
            bool b = false;
            int d, aux, i;
            aux = n;
            i = n % 10;
            n = n / 10;
            do
            {
                d = n % 10;
                n = n / 10;
                if (i==d)
                {
                    b = true;
                }
                else
                {
                    return false;
                }

            } while (n>0);
            n = aux;
            return b;
        }

        public bool TodosPares()
        {
            bool b = false;
            int d, aux;
            aux = n;
            do
            {
                d = n % 10;
                n = n / 10;
                if (d%2==0)
                {
                    b = true;
                }
                else
                {
                    return false;
                }

            } while (n > 0);
            n = aux;
            return b;
        }

        public void Ordenar()
        {

        }

        public void SepPares(Entero n2)
        {
            int d, aux, s;
            aux = n;
            s = 0;
            do
            {
                d = n % 10;
                n = n / 10;
                if (d % 2 == 0)
                {
                    s = (s * 10) + d;
                }

            } while (n > 0);
            n = aux;
            n2.Cargar(s);
        }

        public bool EsPrim()
        {
            if (n==1)
            {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n%i==0)
                {
                    return false;
                }
            }
            return true;
        }

        public void SepPrim(Entero n2)
        {
            int d, aux, s;
            aux = n;
            s = 0;
            do
            {
                d = n % 10;
                n = n / 10;
                n2.Cargar(d);
                if (n2.EsPrim())
                {
                    s = (s * 10) + d;
                }

            } while (n > 0);
            n = aux;
            n2.Cargar(s);
        }
    }
}
