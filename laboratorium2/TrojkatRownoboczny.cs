using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorium2
{
    class TrojkatRownoboczny<T, K> : Triangle<T, K> where T : struct, System.IComparable where K : struct, System.IComparable<K>
    {
        public TrojkatRownoboczny(T a) : base(a, a, a) { }
    }
}
