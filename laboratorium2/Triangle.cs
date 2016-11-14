using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorium2
{
    class Triangle<T> where T : struct
    {
        public T a { get; protected set; }
        public T b { get; protected set; }
        public T c { get; protected set; }

        public double alpha { get; protected set; }
        public double beta { get; protected set; }
        public double gamma { get; protected set; }

        public Triangle(T a, T b, T c)
        {

        }

    }
}
