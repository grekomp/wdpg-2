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

            T r = (dynamic)a * b * c * 2 / (4 * (dynamic)getField());

            alpha = Math.Asin((dynamic)b / r) * 180 / Math.PI;
            beta = Math.Asin((dynamic)c / r) * 180 / Math.PI;
            gamma = Math.Asin((dynamic)a / r) * 180 / Math.PI;
        }

        public Triangle(T a, K alpha, K beta)
        {
            this.a = a;

            this.alpha = alpha;
            this.beta = beta;
            this.gamma = 2 - (dynamic)alpha - beta;

            T r = a / Math.Sin((dynamic)gamma); // 2R
            this.b = r * Math.Sin((dynamic)alpha);
            this.c = r * Math.Sin((dynamic)beta);
        }

        public Triangle(T a, T b, K beta)
        {
            this.a = a;
            this.b = b;
            this.c = Math.Sqrt(Math.Pow((dynamic)a, 2) + Math.Pow((dynamic)b, 2) - 2 * ((dynamic)a * b * Math.Cos((dynamic)beta)));

            T r = (dynamic)a * b * c * 2 / (4 * (dynamic)getField());

            alpha = Math.Asin((dynamic)b / r) * 180 / Math.PI;
            gamma = Math.Asin((dynamic)a / r) * 180 / Math.PI;
        }

        public T getField()
        {
            dynamic p = 0.5 * ((dynamic)a + (dynamic)b + (dynamic)c);

            T area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        }

        public T getPerimeter()
        {
            return (dynamic)a + b + c;
        }


    }
}
