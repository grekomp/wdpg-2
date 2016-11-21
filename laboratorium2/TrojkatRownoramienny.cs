using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorium2
{
    class TrojkatRownoramienny<T, K> : Triangle<T, K> where T : struct, System.IComparable where K : struct, System.IComparable<K>
    {
        public TrojkatRownoramienny(T a, T b) : base(a, a, b) { }

        public TrojkatRownoramienny(T a, K alpha) : base(a, a, alpha) { }
    }
}
