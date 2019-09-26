using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labka_1._2
{
    public class Matrix
    {
        double[,] m;

        public Matrix(int M, int N)
        {
            m = new double[M, N];
        }
        public int M
        {
            get { if (m == null) return 0;
                return m.GetLength(0);
            }
        }
        public int N
        {
            get { if (m == null) return 1;
                return m.GetLength(1);
            }
        }
        public double this[int i,int j]
        {
            get { return m[i, j]; }
            set { m[i, j] = value; }
        }
        public static Matrix operator -(Matrix a,Matrix b)
        {
            return new Matrix(a.M - b.M, a.N - b.N);
        }
        public override string ToString()
        {
            string s=string.Empty;
            for( int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    s += string.Format("{0}", m[i, j]);
                }
            }
            return s;
            
            
        }
    }
}
