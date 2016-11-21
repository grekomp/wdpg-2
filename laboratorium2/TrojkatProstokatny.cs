using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorium2
{
    class TrojkatProstokatny<T, K> : Triangle<T, K> where T : struct, System.IComparable where K : struct, System.IComparable<K>
    {
        public TrojkatProstokatny(T a, T b) : base(a, b, (T)Math.Sqrt(Math.Pow((dynamic)a, 2) + Math.Pow((dynamic)b, 2))) { }

        public TrojkatProstokatny(T a, K alpha) : base(a, alpha: alpha, beta: (K)(dynamic)1) { }
    }
}
