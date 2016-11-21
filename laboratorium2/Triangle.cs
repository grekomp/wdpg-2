using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorium2
{
    class Triangle<T,K> where T : struct, System.IComparable where K : struct, System.IComparable<K>
    {
        public T a { get; protected set; }
        public T b { get; protected set; }
        public T c { get; protected set; }

        public K alpha { get; protected set; }
        public K beta { get; protected set; }
        public K gamma { get; protected set; }

        public Triangle(T a, T b, T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            alpha = default(K);
            beta = default(K);
            gamma = default(K);
        }

        public Triangle(T a = default(T), T b = default(T), T c = default(T), K alpha = default(K), K beta = default(K), K gamma = default(K))
        {
            this.a = a;
            this.b = b;
            this.c = c;

            this.alpha = alpha;
            this.beta = beta;
            this.gamma = gamma;
        }

        public bool calculateMissingSides()
        {
            if (a.CompareTo(default(T)) == 0 && b.CompareTo(default(T)) != 0 && c.CompareTo(default(T)) != 0 && gamma.CompareTo(default(K)) != 0)
            {
                this.a = Math.Sqrt(Math.Pow((dynamic)b,2) + Math.Pow((dynamic)c,2) - 2 * ((dynamic)b * c * Math.Cos((dynamic)gamma)));
                return true;
            }

            return false;
        }

        public T getArea()
        {
            dynamic p = 0.5 * ((dynamic)a + (dynamic)b + (dynamic)c);

            T area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        }



    }
}
